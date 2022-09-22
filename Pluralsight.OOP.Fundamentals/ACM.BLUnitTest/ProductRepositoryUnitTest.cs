using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLUnitTest
{
    public class ProductRepositoryUnitTest
    {
        [Fact]
        public void RetrieveTest()
        {
            // Arrange
            var producRepository = new ProductRepository();

            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Flowers",
                ProductName = "Sunflowers"
            };

            // Act
            var actual = producRepository.Retrieve(2);

            // Assert
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.ProductName, actual.ProductName);
        }

        [Fact]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
                var updatedProduct = new Product(2)
                {
                    CurrentPrice = 18M,
                    ProductDescription = "Assorted Size Set of 4 bright yellow mini sunflowrs",
                    ProductName = "Sunflowers",
                    HasChanges = true

                };
            
            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 bright yellow mini sunflowrs",
                ProductName = "Sunflowers",
                HasChanges = true

            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.False(actual);
        }
    }
}
