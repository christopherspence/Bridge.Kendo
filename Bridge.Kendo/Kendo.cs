using Bridge.Html5;
using Bridge.jQuery2;
using Bridge.Kendo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Kendo
{
    [External]
    [Namespace(false)]
    public class Kendo
    {
        /// <summary>
        /// Opens a Kendo UI Alert popup. Similar to the native window.alert() method.
        /// </summary>
        /// <param name="text">The text to be shown in the Alert popup.</param>
        public static void Alert(string text) { }

        /// <summary>
        /// Returns an object that contains common CSRF tokens found on the page.
        /// </summary>
        /// <returns>An object that contains common CSRF tokens found on the page.</returns>
        public static object AntiForgeryTokens() { return default(object); }

        #region Bind methods

        /// <summary>
        /// Binds a HTML View to a View-Model and initializes Kendo UI widgets from DOM elements based on data-role attributes, similar to kendo.init().
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wrapped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace to look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Bind(string element, object viewModel, object @namespace = null) {}
        
        /// <summary>
        /// Binds a HTML View to a View-Model and initializes Kendo UI widgets from DOM elements based on data-role attributes, similar to kendo.init().
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wrapped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace to look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Bind(jQuery element, object viewModel, object @namespace = null) { }

        /// <summary>
        /// Binds a HTML View to a View-Model and initializes Kendo UI widgets from DOM elements based on data-role attributes, similar to kendo.init().
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wrapped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace to look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Bind(HTMLElement element, object viewModel, object @namespace = null) { }

        /// <summary>
        /// Binds a HTML View to a View-Model and initializes Kendo UI widgets from DOM elements based on data-role attributes, similar to kendo.init().
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wrapped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace to look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Bind(string element, ObservableObject viewModel, object @namespace = null) { }

        /// <summary>
        /// Binds a HTML View to a View-Model and initializes Kendo UI widgets from DOM elements based on data-role attributes, similar to kendo.init().
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wrapped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace to look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Bind(jQuery element, ObservableObject viewModel, object @namespace = null) { }

        /// <summary>
        /// Binds a HTML View to a View-Model and initializes Kendo UI widgets from DOM elements based on data-role attributes, similar to kendo.init().
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wrapped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace to look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Bind(HTMLElement element, ObservableObject viewModel, object @namespace = null) { }

        #endregion

        #region Init methods

        /// <summary>
        /// Instantiates Kendo UI widgets in a given DOM element based on role data attributes.
        /// </summary>
        /// <param name="element">The root element(s) from which the instantiation starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="namespace">Optional namespace too look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Init(string element, object @namespace = null) { }

        /// <summary>
        /// Instantiates Kendo UI widgets in a given DOM element based on role data attributes.
        /// </summary>
        /// <param name="element">The root element(s) from which the instantiation starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="namespace">Optional namespace too look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Init(jQuery element, object @namespace = null) { }

        /// <summary>
        /// Instantiates Kendo UI widgets in a given DOM element based on role data attributes.
        /// </summary>
        /// <param name="element">The root element(s) from which the instantiation starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All descendant elements are traversed.</param>
        /// <param name="namespace">Optional namespace too look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. If omitted kendo.ui will be used. Multiple namespaces can be passed.</param>
        public static void Init(HTMLElement element, object @namespace = null) { }

        #endregion

        /// <summary>
        /// Creates an ObservableArray instance that is bound to a HierarchicalDataSource. Required to bind a HierarchicalDataSource-enabled widget (such as the Kendo UI TreeView) to a view-model.
        /// </summary>
        /// <param name="array">The array that will be converted to an ObservableArray.</param>
        /// <returns></returns>
        public static ObservableArray ObservableHierarcy(Array array) { return null; }

        /// <summary>
        /// Opens a Kendo UI Confirm popup. Similar to the native window.confirm() method.
        /// </summary>
        /// <param name="text">The text to be shown in the Confirm popup.</param>
        /// <returns>Promise a jQuery promise instance, which can be used for callbacks, or passed to jQuery.when.        
        public static Promise Confirm(string text) { return null; }

        /// <summary>
        /// Sets or gets the current culture. Uses the passed culture name to select a culture from the culture scripts that you have included and then sets the current culture. If there is no corresponding culture then the method will try to find culture which is equal to the country part of the culture name. If no culture is found the default one is used.        
        /// The culture must be set before any Kendo UI widgets that rely on it, are initialized.
        /// </summary>
        /// <param name="culture">The culture to set.</param>
        /// <returns></returns>
        public static dynamic Culture(string culture) { return new { name = string.Empty }; }

        /// <summary>
        /// Finds all Kendo widgets that are children of the specified element and calls their destroy method.
        /// </summary>
        /// <param name="element"></param>
        public static void Destroy(string element) { }

        /// <summary>
        /// Finds all Kendo widgets that are children of the specified element and calls their destroy method.
        /// </summary>
        /// <param name="element"></param>
        public static void Destroy(jQuery element) { }

        /// <summary>
        /// Finds all Kendo widgets that are children of the specified element and calls their destroy method.
        /// </summary>
        /// <param name="element"></param>
        public static void Destroy(HTMLElement element) { }
    }
}
