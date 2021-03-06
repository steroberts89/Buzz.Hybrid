﻿using System;
using Buzz.Hybrid.Routing.DashedRouting;

namespace Buzz.Hybrid.Routing
{
    using System.Diagnostics.CodeAnalysis;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Helpers for MVC routes taken from https://github.com/Shandem/Articulate/blob/master/Articulate/RouteCollectionExtensions.cs
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public static class RouteCollectionExtensions
    {
        /// <summary>
        /// The map umbraco route.
        /// </summary>
        /// <param name="routes">
        /// The routes.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <param name="defaults">
        /// The defaults.
        /// </param>
        /// <param name="virtualNodeHandler">
        /// The virtual node handler.
        /// </param>
        /// <param name="constraints">
        /// The constraints.
        /// </param>
        /// <param name="namespaces">
        /// The namespaces.
        /// </param>
        /// <returns>
        /// The <see cref="Route"/>.
        /// </returns>
        public static Route MapUmbracoRoute(
            this RouteCollection routes,
            string name, 
            string url, 
            object defaults, 
            UmbracoVirtualNodeRouteHandler virtualNodeHandler,
            object constraints = null, 
            string[] namespaces = null)
        {

            //var route = RouteTable.Routes.MapRoute(name, url, defaults, constraints, namespaces);
            var route = new LowercaseDashedRoute(url,new RouteValueDictionary(defaults),new RouteValueDictionary(constraints), new RouteValueDictionary(), virtualNodeHandler,namespaces);
            routes.Add(name,route);
            return route;
        }
    }
}
