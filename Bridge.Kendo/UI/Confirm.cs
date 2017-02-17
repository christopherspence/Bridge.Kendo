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
    public class MessageObject
    {
        /// <summary>
        /// The title of the OK button.
        /// </summary>
        [FieldProperty]
        public virtual string OkText { get; set; }

        /// <summary>
        /// The title of the Cancel button. Default is "Cancel"
        /// </summary>
        [FieldProperty]
        public virtual string Cancel { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class ConfirmConfiguration
    {
        [FieldProperty]
        public string Content { get; set; }

        /// <summary>
        /// Defines the text of the labels that are shown within the confirm dialog. Used primarily for localization.
        /// </summary>
        [FieldProperty]
        public MessageObject Messages { get; set; }
    }

    /// <summary>
    /// Represents the Kendo UI Confirm.
    /// </summary>
    [External]
    public class Confirm : Widget
    {       
        /// <summary>
        /// Promise a jQuery promise instance, which can be used for callbacks, or passed to jQuery.when. The jQuery Deferred object resolves to:
        /// done() - when user has pressed the "OK" button;
        /// fail() - when user has pressed the "Cancel" button.
        /// </summary>
        [FieldProperty]
        public virtual Promise Result { get; set; }
    }

    [External]
    public static partial class jQueryExtensions
    {
        /// <summary>
        /// Create an instance of a Kendo Confirm dialog
        /// </summary>        
        /// <param name="options">The options for the dialog</param>
        /// <returns></returns>
        [Name("kendoConfirm")]
        public extern static jQuery CreateConfirm(this jQuery jQuery, ConfirmConfiguration config);

        /// <summary>
        /// Get Kendo Confirm from jQuery element
        /// </summary>        
        /// <param name="jQuery"></param>
        /// <returns></returns>
        [Template("{this}.data(\"kendoConfirm\")")]
        public extern static Confirm GetConfirm(this jQuery jQuery);
    }
}
