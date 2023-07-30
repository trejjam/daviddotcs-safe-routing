﻿//HintName: ControllerRoutes.g.cs
// <auto-generated/>

#pragma warning disable
#nullable enable

namespace Routes
{
  namespace Controllers
  {
    /// <summary>
    /// Generates route values for <see cref="global::ProductsController"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static class Products
    {
      /// <summary>
      /// Generates route values for <see cref="global::ProductsController.Index(int)"/>.
      /// </summary>
      public static Support.Controllers_Products.IndexRouteValues Index(int id, string? name)
      {
        return new Support.Controllers_Products.IndexRouteValues(new global::Microsoft.AspNetCore.Routing.RouteValueDictionary()
        {
          ["area"] = "",
          ["id"] = id,
          ["Name"] = name
        });
      }
    }
  }

  namespace Support.Controllers_Products
  {
    /// <summary>
    /// Represents route keys for the properties of <see cref="global::ProductsController"/>.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public sealed class PropertyData
    {
      /// <summary>
      /// Route key for the property <see cref="global::ProductsController.Name"/>.
      /// </summary>
      public global::SafeRouting.RouteKey<PropertyData, string?> Name { get; } = new global::SafeRouting.RouteKey<PropertyData, string?>("Name");
    }

    /// <summary>
    /// Represents route values for routes to <see cref="global::ProductsController.Index(int)"/>.
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
      public string ControllerName => "Products";
      /// <summary>
      /// The name of the action for the route.
      /// </summary>
      public string ActionName => "Index";
      /// <summary>
      /// Values for the route.
      /// </summary>
      public global::Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get; }

      /// <summary>
      /// Properties of <see cref="global::ProductsController"/> which can be used in the route.
      /// </summary>
      public PropertyData Properties { get; } = new PropertyData();
      /// <summary>
      /// Removes a property value from the route.
      /// </summary>
      /// <typeparam name="T">The type of values applicable to the key.</typeparam>
      /// <param name="key">The key for the route.</param>
      /// <returns><see langword="true"/> if the element is successfully found and removed; otherwise <see langword="false"/>.</returns>
      public bool Remove<T>(global::SafeRouting.RouteKey<PropertyData, T> key) => RouteValues.Remove(key.Name);
      /// <summary>
      /// Sets a property value for the route.
      /// </summary>
      /// <typeparam name="T">The type of values applicable to the key.</typeparam>
      /// <param name="key">The key for the route.</param>
      /// <param name="value">The value for the route.</param>
      public void Set<T>(global::SafeRouting.RouteKey<PropertyData, T> key, T value) => RouteValues[key.Name] = value;
      /// <summary>
      /// Sets a property value for the route.
      /// </summary>
      /// <param name="key">The key for the route.</param>
      public string? this[global::SafeRouting.RouteKey<PropertyData, string?> key] { set => RouteValues[key.Name] = value; }

      /// <summary>
      /// Parameters of <see cref="global::ProductsController.Index(int)"/> which can be used in the route.
      /// </summary>
      public Index.ParameterData Parameters { get; } = new Index.ParameterData();
      /// <summary>
      /// Removes a parameter value from the route.
      /// </summary>
      /// <typeparam name="T">The type of values applicable to the key.</typeparam>
      /// <param name="key">The key for the route.</param>
      /// <returns><see langword="true"/> if the element is successfully found and removed; otherwise <see langword="false"/>.</returns>
      public bool Remove<T>(global::SafeRouting.RouteKey<Index.ParameterData, T> key) => RouteValues.Remove(key.Name);
      /// <summary>
      /// Sets a parameter value for the route.
      /// </summary>
      /// <typeparam name="T">The type of values applicable to the key.</typeparam>
      /// <param name="key">The key for the route.</param>
      /// <param name="value">The value for the route.</param>
      public void Set<T>(global::SafeRouting.RouteKey<Index.ParameterData, T> key, T value) => RouteValues[key.Name] = value;
      /// <summary>
      /// Sets a parameter value for the route.
      /// </summary>
      /// <param name="key">The key for the route.</param>
      public int this[global::SafeRouting.RouteKey<Index.ParameterData, int> key] { set => RouteValues[key.Name] = value; }
    }

    namespace Index
    {
      /// <summary>
      /// Represents route keys for parameters to <see cref="global::ProductsController.Index(int)"/>.
      /// </summary>
      [global::System.CodeDom.Compiler.GeneratedCode("SafeRouting.Generator", "1.0.0.0")]
      [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
      public sealed class ParameterData
      {
        /// <summary>
        /// Route key for the <c>id</c> parameter in <see cref="global::ProductsController.Index(int)"/>.
        /// </summary>
        public global::SafeRouting.RouteKey<ParameterData, int> Id { get; } = new global::SafeRouting.RouteKey<ParameterData, int>("id");
      }
    }
  }
}
