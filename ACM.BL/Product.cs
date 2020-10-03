using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int id)
        {
            ProductID = id;           
        }
        public int ProductID { get; private set; }
        private string _productName;
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
        public string Log() =>
            $"{ProductID}: {ProductName} Description: {Description} Price: {CurrentPrice} Status: {EntityState}";
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override string ToString() => ProductName;
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
