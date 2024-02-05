using Application.Repositories.Invoice;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Invoice
{
    public class InvoiceReadRepository : ReadRepository<Domain.Entities.Invoice>, IInvoiceReadRepository
    {
        public InvoiceReadRepository(APIDBContext context) : base(context)
        {

        }
    }
}
