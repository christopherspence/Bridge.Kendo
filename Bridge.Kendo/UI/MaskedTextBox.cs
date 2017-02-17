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
    public class MaskedTextBoxConfiguration
    {
        /// <summary>
        /// Specifies whether the widget will replace the prompt characters with spaces on blur. Prompt chars will be shown again on focus (available since Q2 2014 SP1). Default is false.
        /// </summary>
        [FieldProperty]
        public bool ClearPromptChar { get; set; }

        /// <summary>
        /// Specifies the culture info used by the widget. Default is "en-US".
        /// </summary>
        [FieldProperty]
        public string Culture { get; set; }

        /// <summary>
        /// Specifies the input mask. Default is ""
        /// </summary>
        [FieldProperty]
        public string Mask { get; set; }

        /// <summary>
        /// Specifies the character used to represent the absence of user input in the widget. Default is "_"
        /// </summary>
        [FieldProperty]
        public string PromptChar { get; set; }

        /// <summary>
        /// Defines an object of custom mask rules.
        /// </summary>
        [FieldProperty]
        public Dictionary<object, object> Rules { get; set; }

        /// <summary>
        /// Defines an object of custom mask rules.
        /// </summary>
        [FieldProperty]
        [Name("rules")]
        public Dictionary<object, Action> RulesFn { get; set; }

        /// <summary>
        /// Specifies whether the widget will unmask the input value on form post (available since Q1 2015). Default is false.
        /// </summary>
        [FieldProperty]
        public bool UnmaskOnPost { get; set; }

        /// <summary>
        /// Specifies the value of the MaskedTextBox widget. Default is ""
        /// </summary>
        [FieldProperty]
        public string Value { get; set; }

        /// <summary>
        /// Fires when the value is changed.
        /// </summary>
        [FieldProperty]
        public Action<MaskedTextBox> Change { get; set; }
    }

    [External]
    public class MaskedTextBox
    {
        /// <summary>
        /// An object, which holds the options of the widget.
        /// </summary>
        [FieldProperty]
        public MaskedTextBoxConfiguration Options { get; set; }

        /// <summary>
        /// Prepares the MaskedTextBox for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks.
        /// </summary>
        public void Destroy() { }

        /// <summary>
        /// Enables or disables the widget.
        /// </summary>
        /// <param name="enable">If set to true the widget will be enabled. If set to false the widget will be disabled.</param>
        public void Enable(bool enable) { }

        /// <summary>
        /// Toggles the readonly state of the widget. When the widget is readonly it doesn't allow user input.
        /// </summary>
        /// <param name="readonly">If set to true the widget will not allow user input. If set to false the widget will allow user input.</param>
        public void ReadOnly(bool @readonly) { }

        /// <summary>
        /// Gets the unmasked value of the MaskedTextBox
        /// </summary>
        public void Raw() { }

        /// <summary>
        /// Gets or sets the value of the MaskedTextBox.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The value of the widget.</returns>
        public string Value(string value) { return null; }        
    }

    [External]
    public static partial class jQueryExtensions
    {
        /// <summary>
        /// Create a kendo MaskedTextBox
        /// </summary>
        /// <param name="jQuery"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [Name("kendoMaskedTextBox")]
        public static extern Alert CreateMaskedTextBox(this jQuery jQuery, AlertConfiguration config);

        /// <summary>
        /// Get Kendo alert from jQuery element
        /// </summary>
        /// <typeparam name="Button"></typeparam>
        /// <param name="jQuery"></param>
        /// <returns></returns>
        [Template("{this}.data(\"kendoMaskedTextBox\")")]
        public static extern Alert GetMaskedTextBox(this jQuery jQuery);
    }
}
