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
    public class AlertOptions
    {
        public string OkText { get; set; }
    }

    [External]
    public class Alert : Dialog
    {
        public virtual void Open() { }
    }

    [External]    
    public static partial class jQueryExtensions 
    {
        /// <summary>
        /// Create a kendo alert
        /// </summary>
        /// <param name="jQuery"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [Name("kendoAlert")]
        public static extern Alert CreateAlert(this jQuery jQuery, AlertOptions options = null);

        /// <summary>
        /// Get Kendo alert from jQuery element
        /// </summary>
        /// <typeparam name="Button"></typeparam>
        /// <param name="jQuery"></param>
        /// <returns></returns>
        [Template("{this}.data(\"kendoAlert\")")]
        public static extern Alert GetAlert(this jQuery jQuery);
    }
}
