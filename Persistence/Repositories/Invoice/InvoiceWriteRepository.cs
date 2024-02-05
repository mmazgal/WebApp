using Application.Repositories.Invoice;
using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Contexts;

namespace Persistence.Repositories.Invoice
{
    public class InvoiceWriteRepository : WriteRepository<Domain.Entities.Invoice>, IInvoiceWriteRepository
    {
        public InvoiceWriteRepository(APIDBContext context) : base(context)
        {

        }
    }
}
