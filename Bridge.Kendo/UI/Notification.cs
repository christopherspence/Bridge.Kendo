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
    public class Template
    {
        [FieldProperty]
        public virtual string Type { get; set; }

        [FieldProperty]
        [Name("Template")]
        public virtual string Content { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class NotificationPosition
    {
        /// <summary>
        /// Determines the pixel position of the first popup notification with regard to the viewport's bottom edge. Default is 20.
        /// </summary>
        [FieldProperty]       
        public virtual int? Bottom { get; set; }

        /// <summary>
        /// Determines the pixel position of the first popup notification with regard to the viewport's left edge. Default is null.
        /// </summary>
        [FieldProperty]
        public virtual int? Left { get; set; }

        /// <summary>
        /// Determines whether the popup notifications will move together with the other page content during scrolling. Default is true.
        /// </summary>
        [FieldProperty]
        public virtual bool Pinned { get; set; }

        /// <summary>
        /// Determines the pixel position of the first popup notification with regard to the viewport's right edge. Default is 20.
        /// </summary>
        [FieldProperty]
        public virtual int? Right { get; set; }

        /// <summary>
        /// Determines the position of the first popup notification with regard to the viewport's top edge. Numeric values are treated as pixels. Default is null
        /// </summary>
        [FieldProperty]
        public virtual int? Top { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class NotificationConfiguration
    {
        /// <summary>
        /// Indicates the period in milliseconds after which a notification can be dismissed (hidden) by the user. Default is 0.
        /// </summary>
        [FieldProperty]
        public virtual int AllowHideAfter { get; set; }

        /// <summary>
        /// Defines custom show and hide animations via an Kendo UI Animation object. Setting the value to false disables animations.
        /// animation:true is not a valid configuration.
        /// </summary>
        [FieldProperty]
        public virtual bool Animation { get; set; }
        
        /// <summary>
        /// Defines custom show and hide animations via an Kendo UI Animation object. Setting the value to false disables animations.
        /// </summary>
        [FieldProperty]
        [Name("animation")]
        public virtual object AnimationObj { get; set; }

        /// <summary>
        /// Defines the element to which the notifications will be appended or prepended (depending on the stacking direction).
        /// </summary>
        [FieldProperty]
        [Name("appendTo")]
        public virtual string AppendToStr { get; set; }

        /// <summary>
        /// Defines the element to which the notifications will be appended or prepended (depending on the stacking direction).
        /// </summary>
        [FieldProperty]
        [Name("appendTo")]
        public virtual HTMLElement AppendToEl { get; set; }

        /// <summary>
        /// Defines the element to which the notifications will be appended or prepended (depending on the stacking direction).
        /// </summary>
        [FieldProperty]
        [Name("appendTo")]
        public virtual jQuery AppendToJQ { get; set; }

        /// <summary>
        /// Indicates the period in milliseconds after which a notification disappears automatically. Setting a zero value disables this behavior. Default is 5000.
        /// </summary>
        [FieldProperty]
        public virtual int AutoHideAfter { get; set; }

        /// <summary>
        /// Determines whether the notifications will include a hide button. This setting works with the built-in templates only.
        /// </summary>
        [FieldProperty]
        public virtual bool Button { get; set; }

        /// <summary>
        /// Defines the notifications' height. Numbers are treated as pixels.
        /// </summary>
        [FieldProperty]
        public virtual int Height { get; set; }

        /// <summary>
        /// Defines the notifications' height. Default is null.
        /// </summary>
        [FieldProperty]
        [Name("height")]
        public virtual string HeightStr { get; set; }

        /// <summary>
        /// Determines whether notifications can be hidden by clicking anywhere on their content.
        /// </summary>
        [FieldProperty]
        public virtual bool HideOnClick { get; set; }

        /// <summary>
        /// This setting applies to popup notifications only, i.e. in cases when appendTo is not set. It determines the position of the first notification on the screen, as well as whether the notifications will move together with the page content during scrolling. top takes precedence over bottom and left takes precedence over right.
        /// </summary>
        [FieldProperty]
        public virtual NotificationPosition Position { get; set; }

        /// <summary>
        /// Determines the direction in which multiple notification will stack (arrange) with regard to the first one. Possible values are "up", "right", "down", "left" and "default". The "default" setting takes into consideration the applied position settings and is evaluated to "up" or "down". Default is "default".
        /// </summary>
        [FieldProperty]
        public virtual string Stacking { get; set; }

        /// <summary>
        /// Describes the HTML markup of the different notification types as Kendo UI template strings. The built-in types are "info", "success", "warning" and "error".
        /// </summary>
        [FieldProperty]
        public virtual List<Template> Templates { get; set; }

        /// <summary>
        /// Defines the notifications' width. Numbers are treated as pixels.
        /// </summary>
        [FieldProperty]
        public virtual int? Width { get; set; }

        /// <summary>
        /// Defines the notifications' width. Numbers are treated as pixels.
        /// </summary>
        [FieldProperty]
        [Name("width")]
        public virtual string WidthStr { get; set; }

        [FieldProperty]
        public virtual Action Hide { get; set; }

        [FieldProperty]
        public virtual Action Show { get; set; }
    }

    /// <summary>
    /// Represents a Kendo UI Notification Widget.
    /// </summary>
    [External]
    public class Notification : Widget
    {
        /// <summary>
        /// This is a shorthand method for show(data, "error")
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public virtual void Error(object data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "error")
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public virtual void Error(string data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "error")
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public virtual void Error(Action data) { }
        
        /// <summary>
        /// Returns a jQuery collection of all visible notifications, displayed by the given widget instance. Each item in the collection is a div.k-notification element.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery[] GetNotifications() { return null; }

        /// <summary>
        /// Hides all notifications from the given widget instance.
        /// </summary>
        public virtual void Hide() { }

        /// <summary>
        /// This is a shorthand method for show(data, "info")
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public virtual void Info(object data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "info")
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public virtual void Info(string data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "info")
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public virtual void Info(Action data) { }

        /// <summary>
        /// Displays a notification.
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        /// <param name="type">The notification type. Built-in types include "info", "success", "warning" and "error". Custom types should match the types from the template configuration. If this argument is not supplied, then "info" is assumed.</param>
        public void Show(object data, string type) { }

        /// <summary>
        /// Displays a notification.
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        /// <param name="type">The notification type. Built-in types include "info", "success", "warning" and "error". Custom types should match the types from the template configuration. If this argument is not supplied, then "info" is assumed.</param>
        public void Show(string data, string type) { }

        /// <summary>
        /// Displays a notification.
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        /// <param name="type">The notification type. Built-in types include "info", "success", "warning" and "error". Custom types should match the types from the template configuration. If this argument is not supplied, then "info" is assumed.</param>
        public void Show(Action data, string type) { }

        /// <summary>
        /// Displays a plain-text notification.
        /// This is a safer version of the show method that assumes that you want to encode any markup passed in as a message.        
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        /// <param name="type">The notification type. Built-in types include "info", "success", "warning" and "error". Custom types should match the types from the template configuration. If this argument is not supplied, then "info" is assumed.</param>
        public void ShowText(object data, string type) { }

        /// <summary>
        /// Displays a plain-text notification.
        /// This is a safer version of the show method that assumes that you want to encode any markup passed in as a message.        
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        /// <param name="type">The notification type. Built-in types include "info", "success", "warning" and "error". Custom types should match the types from the template configuration. If this argument is not supplied, then "info" is assumed.</param>
        public void ShowText(string data, string type) { }

        /// <summary>
        /// Displays a plain-text notification.
        /// This is a safer version of the show method that assumes that you want to encode any markup passed in as a message.        
        /// </summary>
        /// <param name="data">Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        /// <param name="type">The notification type. Built-in types include "info", "success", "warning" and "error". Custom types should match the types from the template configuration. If this argument is not supplied, then "info" is assumed.</param>
        public void ShowText(Action data, string type) { }

        /// <summary>
        /// This is a shorthand method for show(data, "success")
        /// </summary>
        /// <param name="data">The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public void Success(object data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "success")
        /// </summary>
        /// <param name="data">The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public void Success(string data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "success")
        /// </summary>
        /// <param name="data">The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public void Success(Action data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "warning")
        /// </summary>
        /// <param name="data">The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public void Warning(object data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "warning")
        /// </summary>
        /// <param name="data">The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public void Warning(string data) { }

        /// <summary>
        /// This is a shorthand method for show(data, "warning")
        /// </summary>
        /// <param name="data">The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.</param>
        public void Warning(Action data) { }
    }

    [External]
    public static partial class jQueryExtensions
    {
        /// <summary>
        /// Create an instance of a Kendo Confirm dialog
        /// </summary>        
        /// <param name="options">The options for the dialog</param>
        /// <returns></returns>
        [Name("kendoNotification")]
        public extern static jQuery CreateNotification(this jQuery jQuery, NotificationConfiguration config);

        /// <summary>
        /// Get Kendo Notification from jQuery element
        /// </summary>        
        /// <param name="jQuery"></param>
        /// <returns></returns>
        [Template("{this}.data(\"kendoNotification\")")]
        public extern static Confirm GetNotification(this jQuery jQuery);

    }
}
