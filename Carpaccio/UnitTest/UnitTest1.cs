
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest1
    {


        //        POST /order HTTP/1.1
        //{
        //    "prices": [65.6,27.26,32.68],
        //    "quantities": [6,8,10],
        //    "country": "IE",
        //    "reduction":"STANDARD"
        //}

        [Test]
        public void ShouldReturnTotalPriceOnWithPriceAndQuantity()
        {
            var order = new Order();
            var listOfProducts = new List<ProductOrder>()
            {
                new ProductOrder() {};
        };

        order.ProductOrders = listOfProducts;

            order.ComputeTotalAmount();

            Assert.AreEqual(30,order.Total);
        }


}

}
