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
    public class TileSizeDimensions
    {
        /// <summary>
        /// The width of the color cell. Default is 14.
        /// </summary>
        [FieldProperty]
        public int Width { get; set; }

        /// <summary>
        /// The height of the color cell. Default is 14.
        /// </summary>
        [FieldProperty]
        public int Height { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class ColorPickerMessages
    {
        /// <summary>
        /// Allows customization of the "Apply" button text. Default is "Apply"
        /// </summary>
        [FieldProperty]
        public string Apply { get; set; }

        /// <summary>
        /// Allows customization of the "Cancel" button text. Default is "Cancel"
        /// </summary>
        [FieldProperty]
        public string Cancel { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class ColorPickerConfiguration
    {
        /// <summary>
        /// Specifies whether the widget should display the Apply / Cancel buttons.
        /// Applicable only for the HSV selector, when a pallete is not specified. Default is true
        /// </summary>
        [FieldProperty]
        public bool Buttons { get; set; }

        /// <summary>
        /// Specifies whether the widget should display the 'Clear color' button.
        /// Applicable only for the HSV selector, when a pallete is not specified. Default is false.    
        /// </summary>
        [FieldProperty]
        public bool ClearButton { get; set; }

        /// <summary>
        /// The number of columns to show in the color dropdown when a pallete is specified. This is automatically initialized for the "basic" and "websafe" palettes. If you use a custom palette then you can set this to some value that makes sense for your colors.
        /// </summary>
        [FieldProperty]
        public int Columns { get; set; }

        /// <summary>
        /// The size of a color cell. Default is 14.
        /// </summary>
        [FieldProperty]
        public int TileSize { get; set; }

        /// <summary>
        /// The size of a color cell. Default is 14.
        /// </summary>
        [FieldProperty]
        [Name("tileSize")]
        public TileSizeDimensions TileSizeObj { get; set; }

        /// <summary>
        /// Allows localization of the strings that are used in the widget.
        /// </summary>
        [FieldProperty]
        public ColorPickerMessages Messages { get; set; }

        /// <summary>
        /// When a non-null palette argument is supplied, the drop-down will be a simple color picker that lists the colors. The following are supported:
        /// "basic" -- displays 20 basic colors
        /// "websafe" -- display the "web-safe" color palette
        /// otherwise, pass a string with colors in HEX representation separated with commas, or an array of colors, and it will display that palette instead.If you pass an array it can contain strings supported by parseColor or Color objects.
        /// </summary>
        [FieldProperty]
        public string Palette { get; set; }

        /// <summary>
        /// When a non-null palette argument is supplied, the drop-down will be a simple color picker that lists the colors. The following are supported:
        /// "basic" -- displays 20 basic colors
        /// "websafe" -- display the "web-safe" color palette
        /// otherwise, pass a string with colors in HEX representation separated with commas, or an array of colors, and it will display that palette instead.If you pass an array it can contain strings supported by parseColor or Color objects.
        /// </summary>
        [FieldProperty]
        [Name("palette")]
        public string[] PaletteArr { get; set; }

        /// <summary>
        /// Only for the HSV selector. If true, the widget will display the opacity slider. Note that currently in HTML5 the <input type="color"> does not support opacity. Default is false.
        /// </summary>
        [FieldProperty]
        public bool Opacity { get; set; }

        /// <summary>
        /// Only applicable for the HSV selector.
        ///Displays the color preview element, along with an input field where the end user can paste a color in a CSS-supported notation. Default is false.
        /// </summary>
        [FieldProperty]
        public bool Preview { get; set; }

        /// <summary>
        /// A CSS class name to display an icon in the color picker button. Default is null
        /// </summary>
        [FieldProperty]
        public bool? ToolIcon { get; set; }

        /// <summary>
        /// The initially selected color. Note that when initializing the widget from an <input> element, the initial color will be decided by the field instead. Default is null.
        /// </summary>
        [FieldProperty]
        public string Value { get; set; }

        /// <summary>
        /// The initially selected color. Note that when initializing the widget from an <input> element, the initial color will be decided by the field instead. Default is null.
        /// </summary>
        [FieldProperty]
        [Name("value")]
        public Color ValueObj { get; set; }

        #region Events

        /// <summary>
        /// Fires when a color was selected, either by clicking on it (in the simple picker), by clicking ENTER or by pressing "Apply" in the HSV picker.
        /// </summary>
        [FieldProperty]
        public Action<EventArgs> Change { get; set; }

        /// <summary>
        /// Fires as a new color is displayed in the drop-down picker. This is not necessarily the "final" value; for example this event triggers when the sliders in the HSV selector are dragged, but then pressing ESC would cancel the selection and the color will revert to the original value.
        /// </summary>
        [FieldProperty]
        public Action<EventArgs> Select { get; set; }

        /// <summary>
        /// Fires when the picker popup is opening.
        /// </summary>
        public Action Open { get; set; }

        /// <summary>
        /// Fires when the picker popup is closing.
        /// </summary>
        public Action Close { get; set; }

        #endregion
    }

    [External]
    public class ColorPicker
    {
        /// <summary>
        /// Closes the popup.
        /// </summary>
        public void Close() { }

        /// <summary>
        /// Opens the popup element with the color selector.
        /// </summary>
        public void Open() { }

        /// <summary>
        /// Toggles the popup.
        /// </summary>
        public void Toggle() { }

        /// <summary>
        /// Get or set the selected color. If no argument is given, this returns the currently selected color as a string in format #FFFFFF when the opacity option is off, or rgba(255, 255, 255, 1) when opacity is requested.
        /// If one argument is given, it selects the new color and updates the UI.The argument can be a string in hex, rgb or rgba format, or a Color object. This does not trigger the "change" event.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public string Value() { return null; }

        /// <summary>
        /// Get or set the selected color. If no argument is given, this returns the currently selected color as a string in format #FFFFFF when the opacity option is off, or rgba(255, 255, 255, 1) when opacity is requested.
        /// If one argument is given, it selects the new color and updates the UI.The argument can be a string in hex, rgb or rgba format, or a Color object. This does not trigger the "change" event.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public Color Value(string color) { return null; }

        /// <summary>
        /// Get or set the selected color. If no argument is given, this returns the currently selected color as a kendo.Color object.
        /// </summary>
        /// <param name="color">The color that should be set as the current value</param>
        /// <returns> the current value</returns>
        public Color Color(Color color = null) { return null;  }

        /// <summary>
        /// Enables or disables the widget.
        /// </summary>
        /// <param name="enable">Whether the widget should be enabled (true) or disabled (false). If not specified, the method will enable the widget.</param>
        public void Enable(bool enable = false) { }
    }

    [External]
    public static partial class jQueryExtensions
    {
        /// <summary>
        /// Create an instance of a Kendo ColorPicker widget
        /// </summary>        
        /// <param name="options">The options for the widget</param>
        /// <returns></returns>
        [Name("kendoColorPicker")]
        public extern static jQuery CreateColorPicker(this jQuery jQuery, ColorPickerConfiguration config);

        /// <summary>
        /// Get Kendo ColorPicker from jQuery element
        /// </summary>        
        /// <param name="jQuery"></param>
        /// <returns></returns>
        [Template("{this}.data(\"kendoColorPicker\")")]
        public extern static Confirm GetColorPicker(this jQuery jQuery);
    }
}
