using Purchases.ApiDotNet6.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Domain.Entities
{
    public sealed class Person
    {
        //sealed evita a classe ser herdada
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        // construtor adição
        public Person(string name, string document, string phone)
        {
            Validation(name, document, phone);  
            Purchases = new List<Purchase>();
        }

        //construtor edição
        public Person(int id, string name, string document, string phone)
        {
            DomainValidationException.When(id < 0, "Id inválido");
            Id = id;
            Validation(name, document, phone);
            Purchases = new List<Purchase>();

        }

        private void Validation(string name, string document, string phone)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(document), "Documento deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "Fone deve ser informado");

            Name = name;
            Document = document;    
            Phone = phone;  
        }
    }
}
