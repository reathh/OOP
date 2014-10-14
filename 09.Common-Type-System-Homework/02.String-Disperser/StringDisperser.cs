using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Disperser
{
    class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        public string Strings { get; set; }

        public StringDisperser(string[] strings)
        {
            this.Strings = String.Join("", strings);
        }

        public override bool Equals(object obj)
        {
            StringDisperser other = obj as StringDisperser;
            return this.Strings == other.Strings;
        }
        public override int GetHashCode()
        {
            return this.Strings.GetHashCode();
        }
        public override string ToString()
        {
            return this.Strings;
        }

        public static bool operator ==(StringDisperser s1, StringDisperser s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(StringDisperser s1, StringDisperser s2)
        {
            return !(s1.Equals(s2));
        }

        public object Clone()
        {
            return new StringDisperser(new string[] { this.Strings });
        }

        public int CompareTo(StringDisperser other)
        {
            return this.Strings.CompareTo(other.Strings);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var ch in this.Strings)
            {
                yield return ch;
            }
        }
    }
}
