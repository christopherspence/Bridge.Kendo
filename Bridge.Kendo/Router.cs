using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Kendo
{
    [External]
    [ObjectLiteral]
    public class RouterConfiguration
    {
        /// <summary>
        /// Triggered when the URL does not match any of the provided routes.
        /// <param name="e.Url">The fragment part of the URL</param>
        /// <param name="e.params">The parsed query string parameters of the URL</param> 
        /// </summary>
        public Action RouteMissing { get; set; }
    }

    [External]
    [Name("kendo.Router")]
    public class Router
    {
        public Router(RouterConfiguration config) { }

        /// <summary>
        /// Introduced with Q3 2014. If set to false, the router instance will perform case sensitive match of the url against the defined routes.
        /// </summary>
        public virtual bool IgnoreCase { get; set; }

        /// <summary>
        /// If set to true, the router will use the history pushState API.
        /// </summary>
        public virtual bool PushState { get; set; }

        /// <summary>
        /// Applicable if pushState is used and the application is deployed to a path different than /. If the application start page is hosted on http://foo.com/myapp/, the root option should be set to /myapp/.
        /// </summary>
        public virtual string Root { get; set; }

        /// <summary>
        /// Introduced in the 2014 Q1 Service Pack 1 release. If set to true, the hash based navigation will parse and prefix the fragment value with !, which should be SEO friendly, and allows non-prefixed anchor links to work as expected.
        /// </summary>
        public virtual bool HashBang { get; set; }

        /// <summary>
        /// Activates the router binding to the URL changes.
        /// </summary>
        public virtual void Start() { }

        public virtual void Bind<T>(string eventName, Action<T> callback) { }

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route definition.</param>
        /// <param name="callback">The callback to be executed when the route is matched.</param>
        public virtual void Route<T>(string route, Action<T> callback) { }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route definition.</param>
        /// <param name="callback">The callback to be executed when the route is matched.</param>
        public virtual void Route<T, U>(string route, Action<T, U> callback) { }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route definition.</param>
        /// <param name="callback">The callback to be executed when the route is matched.</param>
        public virtual void Route<T, U, V>(string route, Action<T, U, V> callback) { }

        /// <summary>
        /// Navigates to the given route.
        /// </summary>
        /// <param name="route">The route to navigate to.</param>
        /// <param name="silent">If set to true, the router callbacks will not be called.</param>
        public virtual void Navigate(string route, bool silent = false) { }

        /// <summary>
        /// Navigates to the given route, replacing the current view in the history stack (like window.history.replaceState or location.replace work).
        /// </summary>
        /// <param name="route">The route to navigate to.</param>
        /// <param name="silent">If set to true, the router callbacks will not be called.</param>
        public virtual void Replace(string route, bool silent = false) { }

        /// <summary>
        /// Unbinds the router instance listeners from the URL fragment part changes.
        /// </summary>
        public virtual void Destroy() { }
    }
}
