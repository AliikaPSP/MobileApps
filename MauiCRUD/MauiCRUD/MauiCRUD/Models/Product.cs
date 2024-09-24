using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCRUD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product Clone() => MemberwiseClone() as Product;
        public (bool IsValid, string? ErrorMessage) Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return (false, $"{nameof(Name)} is reguired.");
            }
            else if(Price <= 0)
            {
                return (false, $"{nameof(Price)} should be greater than 0.");

            }
            return (true, null);
        }
    }
}
