using Purchases.ApiDotNet6.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; } 
        public string Name { get; private set; }    
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }

        public ICollection<Purchase> Purchases { get; set; }

        // construtor adição
        public Product(string name, string codErp, decimal price)
        {
            Validation(name, codErp, price);
            Purchases = new List<Purchase>();
        }

        //construtor edição
        public Product(int id, string name, string codErp, decimal price)
        {
            DomainValidationException.When(price < 0, "Id deve ser valido");
            Id = id;
            Validation(name, codErp, price);
            Purchases = new List<Purchase>();
        }

        private void Validation(string name, string codErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(codErp), "CodErp deve ser informado");
            DomainValidationException.When(price < 0, "Price deve ser informado");

            Name = name;
            CodErp = codErp;
            Price = price;
        }
    }
}
