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
    public class ButtonOptions
    {
        public bool Enable { get; set; }
        public string Icon { get; set; }
        public string ImageUrl { get; set; }
        public string SpriteCssClass { get; set; }

        public Func<HtmlEventTarget> Click { get; set; }

    }

    [External]
    public class Button : jQuery
    {
        public void Enable(bool toggle) { }

        public void Bind(string name, Action<HtmlEventTarget> action) { }    
    }

    [External]
    public static class jQueryExtensions
    {
        public static Button KendoButton(this jQuery jQuery) { return null; }
    }
}
