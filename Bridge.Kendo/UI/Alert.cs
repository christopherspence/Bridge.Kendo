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
    public static class Alert 
    {
        public static jQuery KendoAlert(this jQuery jQuery, AlertOptions options = null) { return default(jQuery); }        
    }
}
