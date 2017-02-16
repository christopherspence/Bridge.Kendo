using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Kendo
{
    /// <summary>
    /// The base class of most Kendo objects. Provides simple inheritance support.
    /// </summary>
    [External]
    public class Class
    {
        /// <summary>
        /// An alias to the prototype of the class. Often used to call methods of the base class.
        /// </summary>
        public object fn { get; set; }

        /// <summary>
        /// Extends an existing class with new methods.
        /// </summary>
        /// <param name="prototype">A key/value pair of all methods that the new class will have.</param>
        /// <returns>a new class which inherits the base methods.</returns>
        public object Extend(object prototype) { return null; }
    }
}
