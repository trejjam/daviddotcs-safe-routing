﻿//HintName: PageRoutes.g.cs
// <auto-generated/>

#nullable enable

namespace Routes
{
  namespace Pages
  {
    /// <summary>
    /// Generates route values for <see cref="global::EditModel"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    public static class Products_Edit
    {
      /// <summary>
      /// Generates route values for <see cref="global::EditModel.OnGetAsync()"/>.
      /// </summary>
      public static Support.Pages_Products_Edit.GetRouteValues Get()
      {
        var routeInfo = new Support.Pages_Products_Edit.GetRouteValues();
        routeInfo.RouteValues["area"] = "";
        return routeInfo;
      }
    }
  }
  
  namespace Support.Pages_Products_Edit
  {
    /// <summary>
    /// Represents route values for routes to <see cref="global::EditModel.OnGetAsync()"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    public sealed class GetRouteValues : global::SafeRouting.IPageRouteValues
    {
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
      public global::Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get; } = new global::Microsoft.AspNetCore.Routing.RouteValueDictionary();
    }
  }
}
