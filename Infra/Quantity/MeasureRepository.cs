﻿using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Infra.Quantity {

    public class MeasureRepository : UniqueEntityRepository<Measures, MeasureDataData>, IMeasuresRepository {

        public MeasureRepository(QuantityDbContext c) : base(c, c.Measures) { }

        protected internal override Measures toDomainObject(MeasureDataData d) => new Measures(d);

    }

}
