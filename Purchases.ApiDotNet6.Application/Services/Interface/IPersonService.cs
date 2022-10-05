using Purchases.ApiDotNet6.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Application.Services.Interface
{
    public interface IPersonService
    {
        Task<ResultServices<PersonDTO>> CreateAsync(PersonDTO personDTO);
        Task<ResultServices<ICollection<PersonDTO>>> GetAsync();
        Task<ResultServices<PersonDTO>> GetByIdAsync(int id);
    }
}
