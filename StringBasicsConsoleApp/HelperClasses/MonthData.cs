using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasicsConsoleApp.HelperClasses
{
    public class MonthData : IEquatable<MonthData>
    {
        public string Month { get; set; }
        public int Index { get; set; }

        public override string ToString()
        {
            return $"{{ Month = {Month}, Index = {Index} }}";
        }

        public bool Equals(MonthData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Month == other.Month && Index == other.Index;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MonthData) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Month, Index);
        }
    }
}
