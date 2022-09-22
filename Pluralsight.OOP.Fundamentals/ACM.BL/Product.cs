using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        private string _productName;
        public Product() { }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; set; }
        public string ProductName 
        {
            get
            {
                return _productName.InsertSpaces();
            }

            set
            {
                _productName = value;
            }
        }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public string Log()
        {
            return $"{ProductId}: {ProductName} Detail: {ProductDescription}";
        }
    }
}
