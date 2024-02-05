using Application.Repositories.ProductImage;
using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Contexts;

namespace Persistence.Repositories.ProductImage
{
    public class ProductImageWriteRepository : WriteRepository<Domain.Entities.ProductImage>, IProductImageWriteRepository
    {
        public ProductImageWriteRepository(APIDBContext context) : base(context)
        {

        }
    }
}
