﻿//HintName: ControllerRoutes.g.cs
// <auto-generated/>

#pragma warning disable
#nullable enable

namespace Routes
{
  namespace Controllers
  {
    /// <summary>
    /// Generates route values for <see cref="global::AController"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static class A
    {
      /// <summary>
      /// Generates route values for <see cref="global::AController.Index()"/>.
      /// </summary>
      public static Support.Controllers_A.IndexRouteValues Index()
      {
        return new Support.Controllers_A.IndexRouteValues(new global::Microsoft.AspNetCore.Routing.RouteValueDictionary()
        {
          ["area"] = ""
        });
      }
    }
  }
  
  namespace Support.Controllers_A
  {
    /// <summary>
    /// Represents route values for routes to <see cref="global::AController.Index()"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public sealed class IndexRouteValues : global::SafeRouting.IControllerRouteValues
    {
      /// <summary>
      /// Initialises a new instance of the <see cref="IndexRouteValues"/> class.
      /// </summary>
      /// <param name="routeValues">The initial values for the route.</param>
      public IndexRouteValues(global::Microsoft.AspNetCore.Routing.RouteValueDictionary routeValues)
      {
        RouteValues = routeValues;
      }
      
      /// <summary>
      /// The name of the controller for the route.
      /// </summary>
      public string ControllerName => "A";
      /// <summary>
      /// The name of the action for the route.
      /// </summary>
      public string ActionName => "Index";
      /// <summary>
      /// Values for the route.
      /// </summary>
      public global::Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get; }
    }
  }
  
  namespace Controllers
  {
    /// <summary>
    /// Generates route values for <see cref="global::BController"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static class B
    {
      /// <summary>
      /// Generates route values for <see cref="global::BController.Index()"/>.
      /// </summary>
      public static Support.Controllers_B.IndexRouteValues Index()
      {
        return new Support.Controllers_B.IndexRouteValues(new global::Microsoft.AspNetCore.Routing.RouteValueDictionary()
        {
          ["area"] = ""
        });
      }
    }
  }
  
  namespace Support.Controllers_B
  {
    /// <summary>
    /// Represents route values for routes to <see cref="global::BController.Index()"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public sealed class IndexRouteValues : global::SafeRouting.IControllerRouteValues
    {
      /// <summary>
      /// Initialises a new instance of the <see cref="IndexRouteValues"/> class.
      /// </summary>
      /// <param name="routeValues">The initial values for the route.</param>
      public IndexRouteValues(global::Microsoft.AspNetCore.Routing.RouteValueDictionary routeValues)
      {
        RouteValues = routeValues;
      }
      
      /// <summary>
      /// The name of the controller for the route.
      /// </summary>
      public string ControllerName => "B";
      /// <summary>
      /// The name of the action for the route.
      /// </summary>
      public string ActionName => "Index";
      /// <summary>
      /// Values for the route.
      /// </summary>
      public global::Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get; }
    }
  }
}
