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
    [ObjectLiteral]
    public class ViewOptions
    {
        /// <summary>
        /// If set to true, the view template will be treated as kendo template and evaluated against the provided model instance. Default is false.
        /// </summary>
        [FieldProperty]
        public virtual bool EvalTemplate { get; set; }

        /// <summary>
        /// The MVVM model to bind the element to.
        /// </summary>
        [FieldProperty]
        public virtual ObservableObject Model { get; set; }

        /// <summary>
        /// The tag used for the root element of the view. Default is "div".
        /// </summary>
        [FieldProperty]
        public virtual string TagName { get; set; }

        /// <summary>
        /// If set to false, the view will not wrap its contents in a root element. In that case, the view element will point to the root element in the template. If false, the view template should have a single root element. Default is "true".
        /// </summary>
        [FieldProperty]
        public virtual bool Wrap { get; set; }        
    }

    [External]
    [Name("kendo.View")]
    public class View
    {
        /// <summary>
        /// The element of the View. Gets instantiated after the render method is called.
        /// </summary>
        [FieldProperty]
        public jQuery Element { get; set; }

        public View(string html) { }

        public View(string html, ViewOptions options) { }

        /// <summary>
        /// Removes the View element from the DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public virtual void Destroy() { }

        /// <summary>
        /// Renders the view contents. Accepts a jQuery selector (or jQuery object) to which the contents will be appended. Alternatively, the render method can be called without parameters in order to retrieve the View element for manual insertion/further manipulation. 
        /// </summary>
        /// <param name="container"></param>
        /// <returns>(optional) the element in which the view element will be appended.</returns>
        public virtual jQuery Render(string container = null) { return null; }

        /// <summary>
        /// Renders the view contents. Accepts a jQuery selector (or jQuery object) to which the contents will be appended. Alternatively, the render method can be called without parameters in order to retrieve the View element for manual insertion/further manipulation. 
        /// </summary>
        /// <param name="container"></param>
        /// <returns>(optional) the element in which the view element will be appended.</returns>
        public virtual jQuery Render(jQuery selector) { return null; }
    }    
}
