using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity
{
    public sealed class Measure: Entity<MeasureDataData>
    {
        public Measure(): this(null) { }
        public Measure(MeasureDataData data) : base(data) { }
    }
}
