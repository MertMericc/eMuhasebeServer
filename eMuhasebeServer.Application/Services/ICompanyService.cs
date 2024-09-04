using eMuhasebeServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMuhasebeServer.Application.Services
{
    public interface ICompanyService
    {
        void MigrateAll(List<Company> companies);
    }
}
