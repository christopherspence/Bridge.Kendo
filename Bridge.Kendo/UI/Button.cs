using Bridge.Html5;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Kendo.UI
{
    [External]
    [ObjectLiteral]
    public class ButtonConfiguration
    {
        /// <summary>
        /// Indicates whether the Button should be enabled or disabled. By default, it is enabled, unless a disabled="disabled" attribute is detected.
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// Defines a name of an existing icon in the Kendo UI theme sprite. The icon will be applied as background image of a span element inside the Button. 
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Defines a URL, which will be used for an img element inside the Button. The URL can be relative or absolute. In case it is relative, it will be evaluated with relation to the web page URL.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Defines a CSS class (or multiple classes separated by spaces), which will be used for applying a background image to a span element inside the Button. In case you want to use an icon from the Kendo UI theme sprite background image, it is easier to use the icon property.
        /// </summary>
        public string SpriteCssClass { get; set; }

        /// <summary>
        /// Fires when the Button is clicked with the mouse, touched on a touch device, or ENTER (or SPACE) is pressed while the Button is focused.
        /// </summary>
        public Func<HtmlEventTarget> Click { get; set; }

    }

    [External]
    public class Button : jQuery
    {
        /// <summary>
        /// Enables or disables the Button.
        /// </summary>
        /// <param name="toggle">Indicates whether the Button should be enabled or disabled. true and false arguments are accepted. If no argument is supplied, the Button will assume true and will be enabled.</param>
        public void Enable(bool toggle = true) { }    
    }

    [External]
    public static partial class jQueryExtensions
    {
        /// <summary>
        /// Create an instance of a Kendo Button
        /// </summary>
        /// <typeparam name="Button"></typeparam>
        /// <param name="jQuery"></param>
        /// <returns></returns>
        [Name("kendoButton")]
        public static jQuery CreateButton(this jQuery jQuery, ButtonConfiguration config) { return null; }

        /// <summary>
        /// Get Kendo button from jQuery element
        /// </summary>
        /// <typeparam name="Button"></typeparam>
        /// <param name="jQuery"></param>
        /// <returns></returns>
        [Template("{this}.data(\"kendoButton\")")]
        public static extern Button GetButton(this jQuery jQuery);
    }
}
