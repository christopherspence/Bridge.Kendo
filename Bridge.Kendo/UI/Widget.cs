using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Kendo.UI
{
    [External]
    public class Widget : Observable
    {
        /// <summary>
        /// The element, from which the widget is initialized. Depending on the widget, it may be visible, such as in the AutoComplete, Calendar, DatePicker, inline Editor and others, or hidden, such as in the DropDownList, classic Editor and Upload. A reference to this element is also returned by the initialization statement.
        /// </summary>
        public jQuery Element { get; set; }

        /// <summary>
        /// The outermost element, which is part of the widget. Depending on the widget and the exact scenario, the wrapper and the element may match.
        /// </summary>
        public jQuery Wrapper { get; set; }

        /// <summary>
        /// Readjusts the layout of the widget. For more information, refer to the article on responsive web design.
        /// </summary>
        public void Resize() { }

        /// <summary>
        /// Allows changing the widget configuration after initialization. Depending on the widget, some properties may not be changed, and the method's implementation varies for each widget.
        /// </summary>
        /// <param name="newOptions">The options to be changed or added.</param>
        public void SetOptions(dynamic newOptions) { }        
    }
}
