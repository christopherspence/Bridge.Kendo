using Bridge.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Kendo
{
    /// <summary>
    /// Provides support for firing events.
    /// </summary>
    [External]
    public class Observable : Class
    {
        /// <summary>
        /// Attaches a handler to an event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="handler">A function to execute each time the event is triggered. That function should have a single parameter which will contain any event specific data.</param>
        public void Bind(string eventName, Func<HtmlEventTarget> handler) { }

        /// <summary>
        /// Attaches a handler to an event. The handler is executed only once.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="handler">A function to execute each time the event is triggered. That function should have a single parameter which will contain any event specific data.</param>
        public void One(string eventName, Func<HtmlEventTarget> handler) { }

        /// <summary>
        /// Executes all handlers attached to the given event.
        /// </summary>
        /// <param name="eventName">The name of the event to trigger.</param>
        /// <param name="handler">Optional event data which will be passed as an argument to the event handlers.</param>
        public void Trigger(string eventName, Func<HtmlEventTarget> handler) { }

        /// <summary>
        /// Remove a previously attached event handler.
        /// </summary>
        /// <param name="eventName">The name of the event. If not specified all handlers of all events will be removed.</param>
        /// <param name="handler">The handler which should no longer be executed. If not specified all handlers listening to that event will be removed.</param>
        public void Unbind(string eventName = null, Func<HtmlEventTarget> handler = null) { }
    }
}
