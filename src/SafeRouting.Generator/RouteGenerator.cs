﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace SafeRouting.Generator;

[Generator(LanguageNames.CSharp)]
public sealed class RouteGenerator : IIncrementalGenerator
{
  public void Initialize(IncrementalGeneratorInitializationContext context)
  {
    var languageVersionProvider = context.ParseOptionsProvider
      .Select(static (x, _) => (x as CSharpParseOptions)?.LanguageVersion);

    var isGlobalUsingsSupportedProvider = languageVersionProvider
      .Select(static (x, _) => x >= LanguageVersion.CSharp10);

    context.RegisterConditionalOutput(isGlobalUsingsSupportedProvider, static context =>
    {
      var source = @"// <auto-generated/>

global using static SafeRouting.Extensions.RouteValueExtensions;";

      context.AddSource("globalusings.g.cs", SourceText.From(source, Encoding.UTF8));
    });

    var isSupportedLanguageVersionProvider = languageVersionProvider
      .Select(static (x, _) => x >= LanguageVersion.CSharp8);

    context.RegisterConditionalOutput(isSupportedLanguageVersionProvider.Not(), static context =>
    {
      context.ReportDiagnostic(Diagnostics.CreateUnsupportedLanguageVersionDiagnostic());
    });

    // Options
    var optionsProvider = context.AnalyzerConfigOptionsProvider
      .Select(static (x, _) => Parser.GetOptions(x));

    var optionsDiagnosticsProvider = optionsProvider
      .SelectMany(static (x, _) => x.Diagnostics);

    context.ReportDiagnostics(optionsDiagnosticsProvider);

    // Controllers and Pages
    var candidateClassProvider = context.SyntaxProvider
      .CreateSyntaxProvider(static (x, _) => Parser.IsCandidateNode(x), Parser.TransformCandidateClassNode)
      .Filter(isSupportedLanguageVersionProvider)
      .Where(static x => x is not null)!
      .WithComparer(CandidateClassInfoEqualityComparer.Default);

    RegisterControllerSourceOutput(context, candidateClassProvider, optionsProvider);
    RegisterPageSourceOutput(context, candidateClassProvider, optionsProvider);
  }

  private static void RegisterControllerSourceOutput(IncrementalGeneratorInitializationContext context, IncrementalValuesProvider<CandidateClassInfo> candidateClassProvider, IncrementalValueProvider<GeneratorOptions> optionsProvider)
  {
    var controllerInfoAndDiagnosticsProvider = candidateClassProvider
      .Where(static x => x.IsController)
      .Select(static (x, cancellationToken) => Parser.GetControllerInfo(x, cancellationToken));

    var controllerDiagnosticsProvider = controllerInfoAndDiagnosticsProvider
      .SelectMany(static (x, _) => x.Diagnostics);

    context.ReportDiagnostics(controllerDiagnosticsProvider);

    IncrementalValuesProvider<ControllerInfo> controllerInfoProvider = controllerInfoAndDiagnosticsProvider
      .Select(static (x, _) => x.ControllerInfo)
      .Where(static x => x is not null)!;

    var uniqueControllersAndDiagnosticsProvider = controllerInfoProvider
      .Collect()
      .Select(static (x, _) => Parser.GetUniqueControllers(x));

    var uniqueControllersDiagnosticsProvider = uniqueControllersAndDiagnosticsProvider
      .SelectMany(static (x, _) => x.Diagnostics);

    context.ReportDiagnostics(uniqueControllersDiagnosticsProvider);

    var controllerClassProvider = uniqueControllersAndDiagnosticsProvider
      .Select(static (x, _) => x.Controllers)
      .Combine(optionsProvider);

    context.RegisterSourceOutput(controllerClassProvider, static (context, values) =>
    {
      var (controllers, options) = values;

      if (controllers.Length == 0)
      {
        return;
      }

      var source = Emitter.Emit(controllers, options, context.CancellationToken);

      context.AddSource("ControllerRoutes.g.cs", SourceText.From(source, Encoding.UTF8));
    });
  }

  private static void RegisterPageSourceOutput(IncrementalGeneratorInitializationContext context, IncrementalValuesProvider<CandidateClassInfo> candidateClassProvider, IncrementalValueProvider<GeneratorOptions> optionsProvider)
  {
    var pageInfoAndDiagnosticsProvider = candidateClassProvider
      .Where(static x => x.IsPage)
      .Select(static (x, cancellationToken) => Parser.GetPageInfo(x, cancellationToken));

    var pageDiagnosticsProvider = pageInfoAndDiagnosticsProvider
      .SelectMany(static (x, _) => x.Diagnostics);

    context.ReportDiagnostics(pageDiagnosticsProvider);

    IncrementalValuesProvider<PageInfo> pageInfoProvider = pageInfoAndDiagnosticsProvider
      .Select(static (x, _) => x.PageInfo)
      .Where(static x => x is not null)!;

    var uniquePagesAndDiagnosticsProvider = pageInfoProvider
      .Collect()
      .Select(static (x, _) => Parser.GetUniquePages(x));

    var uniquePagesDiagnosticsProvider = uniquePagesAndDiagnosticsProvider
      .SelectMany(static (x, _) => x.Diagnostics);

    context.ReportDiagnostics(uniquePagesDiagnosticsProvider);

    var pageClassProvider = uniquePagesAndDiagnosticsProvider
      .Select(static (x, _) => x.Pages)
      .Combine(optionsProvider);

    context.RegisterSourceOutput(pageClassProvider, static (context, values) =>
    {
      var (pages, options) = values;

      if (pages.Length == 0)
      {
        return;
      }

      var source = Emitter.Emit(pages, options, context.CancellationToken);

      context.AddSource("PageRoutes.g.cs", SourceText.From(source, Encoding.UTF8));
    });
  }
}
