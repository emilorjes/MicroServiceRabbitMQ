using ACM.BL;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steal Head",
                CurrentPrice = 6M
            };

            changedItems.Add(product);
            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
        }
    }
}
