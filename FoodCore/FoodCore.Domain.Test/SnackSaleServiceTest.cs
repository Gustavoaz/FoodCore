using FoodCore.Domain.Contract.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodCore.Domain.Test
{
    [TestClass]
    public class SnackSaleServiceTest
    {
        protected ISnackSaleService service;
        //protected List<Promocao> promocoes;
        //protected Cardapio mockContext;

        [TestInitialize]
        public void Initialize()
        {
        }

        public SnackSaleServiceTest()
        {
            service = new SnackSaleService();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void teste()
        {
            service.teste(1);
        }
    }
}
