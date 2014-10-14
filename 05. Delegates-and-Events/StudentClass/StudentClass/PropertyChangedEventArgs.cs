using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    // define a class to store the changed properties name, old and new value
    public class PropertyChangedEventArgs : EventArgs
    {
        // defin fields
        private string property;
        private string oldValue;
        private string newValue;

        // define properties
        public string Property
        {
            get { return this.property; }
        }

        public string OldValue
        {
            get { return this.oldValue; }
        }

        public string NewValue
        {
            get { return this.newValue; }
        }

        // define a constructor
        public PropertyChangedEventArgs(string property, string oldValue, string newValue)
        {
            this.property = property;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }
    }
}
