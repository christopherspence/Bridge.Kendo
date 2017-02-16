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
    public class Alert : Dialog { }

    [External]    
    public static class jQueryExtensions 
    {
        public static Alert KendoAlert(this jQuery jQuery, AlertOptions options = null) { return null; }        
    }
}
