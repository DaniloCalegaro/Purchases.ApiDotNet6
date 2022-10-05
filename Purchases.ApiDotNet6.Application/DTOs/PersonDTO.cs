using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Application.DTOs
{
    public class PersonDTO
    { 
        // DTO fará a ponte entre o mundo exterior e a aplicação
        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get;  set; }
        public string Phone { get; set; }
    }
}
