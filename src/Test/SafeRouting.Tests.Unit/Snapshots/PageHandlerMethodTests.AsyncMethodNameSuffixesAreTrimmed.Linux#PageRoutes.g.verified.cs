﻿//HintName: PageRoutes.g.cs
// <auto-generated/>

#pragma warning disable
#nullable enable

namespace Routes
{
  namespace Pages
  {
    /// <summary>
    /// Generates route values for <see cref="global::EditModel"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static class Products_Edit
    {
      /// <summary>
      /// Generates route values for <see cref="global::EditModel.OnGetAsync()"/>.
      /// </summary>
      public static Support.Pages_Products_Edit.GetRouteValues Get()
      {
        return new Support.Pages_Products_Edit.GetRouteValues(new global::Microsoft.AspNetCore.Routing.RouteValueDictionary()
        {
          ["area"] = ""
        });
      }
    }
  }

  namespace Support.Pages_Products_Edit
  {
    /// <summary>
    /// Represents route values for routes to <see cref="global::EditModel.OnGetAsync()"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public sealed class GetRouteValues : global::SafeRouting.IPageRouteValues
    {
      /// <summary>
      /// Initialises a new instance of the <see cref="GetRouteValues"/> class.
      /// </summary>
      /// <param name="routeValues">The initial values for the route.</param>
      public GetRouteValues(global::Microsoft.AspNetCore.Routing.RouteValueDictionary routeValues)
      {
        RouteValues = routeValues;
      }

      /// <summary>
      /// The name of the page for the route.
      /// </summary>
      public string PageName => "/Products/Edit";
      /// <summary>
      /// The name of the handler for the route.
      /// </summary>
      public string? HandlerName => null;
      /// <summary>
      /// Values for the route.
      /// </summary>
      public global::Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get; }
    }
  }
}