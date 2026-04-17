using System;
using System.Collections.Generic;
using OpenClosed;
using OpenClosedPrinciple;

namespace OpenClosedUnitTests
{
    public class OpenCloseTests
    {
        [Fact]
        public void GoldBadCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 900.00m;

            //Act
            A_BadCustomer badCustomer = new A_BadCustomer();
            badCustomer.CustomerType = CustomerType.Gold;
            decimal discountedPrice = badCustomer.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void SilverBadCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 950.00m;

            //Act
            A_BadCustomer badCustomer = new A_BadCustomer();
            badCustomer.CustomerType = CustomerType.Silver;
            decimal discountedPrice = badCustomer.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void GoldGoodCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 900.00m;

            //Act
            B_GoodCustomer goodCustomer = new GoldCustomer();
            decimal discountedPrice = goodCustomer.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void SilverGoodCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 950.00m;

            //Act
            B_GoodCustomer goodCustomer = new SilverCustomer();
            decimal discountedPrice = goodCustomer.GetDiscountedPrice(originalPrice);

            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void MixedGoodCustomersTest()
        {
            //Arrange
            SilverCustomer customer1 = new SilverCustomer();
            GoldCustomer customer2 = new GoldCustomer();
            PlatinumCustomer customer3 = new PlatinumCustomer();

            List<B_GoodCustomer> customers = new List<B_GoodCustomer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            decimal totalDiscountedPrices = 0m;
            decimal originalPrice = 1000.00m;
            decimal expectedDiscountedTotal = 2700.00m;

            //Act
            foreach (B_GoodCustomer customer in customers)
            {
                totalDiscountedPrices += customer.GetDiscountedPrice(originalPrice);
            }

            //Assert
            Assert.Equal(customers[0].GetDiscountedPrice(originalPrice), 950.00m);
            Assert.Equal(customers[1].GetDiscountedPrice(originalPrice), 900.00m);
            Assert.Equal(customers[2].GetDiscountedPrice(originalPrice), 850.00m);
            Assert.Equal(expectedDiscountedTotal, totalDiscountedPrices);
        }

        [Theory]
        [InlineData(950.0, typeof (SilverCustomer))]
        [InlineData(900.0, typeof(GoldCustomer))]
        [InlineData(850.0, typeof(PlatinumCustomer))]
        public void MixedGoodCustomersTestMultiWithTypes(decimal expectedDiscount, Type customerType)
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            B_GoodCustomer c = (B_GoodCustomer)Activator.CreateInstance(customerType);

            //Act
            decimal discountedPrice = c.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedDiscount, discountedPrice);
        }

        // Use MemberData to pass real instances into the theory
        [Theory]
        [MemberData(nameof(CustomerTestCases))]
        public void MixedGoodCustomersTestMultiWithInstances(B_GoodCustomer c, decimal expectedDiscount)
        {
            //Arrange
            decimal originalPrice = 1000.00m;

            //Act
            decimal discountedPrice = c.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedDiscount, discountedPrice);
        }

        // Provide instances and expected values
        public static IEnumerable<object[]> CustomerTestCases()
        {
            yield return new object[] { new SilverCustomer(), 950.00m };
            yield return new object[] { new GoldCustomer(), 900.00m };
            yield return new object[] { new PlatinumCustomer(), 850.00m };
        }
    }
}
