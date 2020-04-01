using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Infra.Quantity {

    public class MeasureRepository : UniqueEntityRepository<Measure, MeasureDataData>, IMeasuresRepository {

        public MeasureRepository(QuantityDbContext c) : base(c, c.Measures) { }

        protected internal override Measure toDomainObject(MeasureDataData d) => new Measure(d);

    }

}
