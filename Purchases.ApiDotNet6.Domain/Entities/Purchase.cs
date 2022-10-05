using Purchases.ApiDotNet6.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Purchases.ApiDotNet6.Domain.Entities
{
    public sealed class Purchase
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }

        public Person Person { get; set; }
        public Product Product { get; set; }

        // construtor adição
        public Purchase(int productId, int personId)
        {
            Validation(productId, personId);
        }

        //construtor edição
        public Purchase(int id, int productId, int personId)
        {
            DomainValidationException.When(id < 0, "Produto deve ser informado");
            Id = id;
            Validation(productId, personId);
        }

        private void Validation(int productId, int personId)
        {
            DomainValidationException.When(productId < 0, "Produto deve ser informado");
            DomainValidationException.When(personId < 0, "Pessoas  deve ser informada");

            ProductId = productId;
            PersonId = personId;
            Date = DateTime.Now;
        }
    }
}
