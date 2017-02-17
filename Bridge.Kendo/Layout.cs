using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Kendo
{
    /// <summary>
    /// The Layout class inherits from the View and provides the additional functionality of rendering other views/layouts in the element.
    /// </summary>
    [External]
    [Name("kendo.Layout")]
    public class Layout : View
    {
        public Layout(string html) : base(html) {}

        public Layout(string html, ViewOptions options) : base(html, options) {}

        /// <summary>
        /// Renders the View element in the element specified by the selector.
        /// </summary>
        /// <param name="container">The selector of the container in which the view element will be appended.</param>
        /// <param name="view">The view instance that will be rendered.</param>
        /// <param name="transitionClass">Optional. If provided, the new view will replace the current one with a replace effect.</param>
        public void ShowIn(string container, View view, string transitionClass = null) { }
    }
}
