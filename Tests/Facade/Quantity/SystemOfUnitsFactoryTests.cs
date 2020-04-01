﻿using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Quantity
{
    [TestClass]
    public class SystemOfUnitsFactoryTests : BaseTests
    {

        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(SystemOfUnitsView);
        }

        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<SystemOfUnitsView>();
            var data = SystemOfUnitsFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);

        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<SystemOfUnitsData>();
            var view = SystemOfUnitsFactory.Create(new SystemOfUnits(data));

            testArePropertyValuesEqual(view, data);

        }

    }

}
