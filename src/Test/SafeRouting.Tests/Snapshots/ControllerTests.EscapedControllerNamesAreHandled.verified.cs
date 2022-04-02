﻿//HintName: ControllerRoutes.g.cs
// <auto-generated/>

#pragma warning disable
#nullable enable

namespace Routes
{
  namespace Controllers
  {
    /// <summary>
    /// Generates route values for <see cref="global::@class"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static class @class
    {
      /// <summary>
      /// Generates route values for <see cref="global::@class.Index()"/>.
      /// </summary>
      public static Support.Controllers_class.IndexRouteValues Index()
      {
        var routeInfo = new Support.Controllers_class.IndexRouteValues();
        routeInfo.RouteValues["area"] = "";
        return routeInfo;
      }
    }
  }
  
  namespace Support.Controllers_class
  {
    /// <summary>
    /// Represents route values for routes to <see cref="global::@class.Index()"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public sealed class IndexRouteValues : global::SafeRouting.IControllerRouteValues
    {
      /// <summary>
      /// The name of the controller for the route.
      /// </summary>
      public string ControllerName => "class";
      /// <summary>
      /// The name of the action for the route.
      /// </summary>
      public string ActionName => "Index";
      /// <summary>
      /// Values for the route.
      /// </summary>
      public global::Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get; } = new global::Microsoft.AspNetCore.Routing.RouteValueDictionary();
    }
  }
}
