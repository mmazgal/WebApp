using Application.Repositories;
using Application.Repositories.ProductImage;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ProductImage
{
    public class ProductImageReadRepository : ReadRepository<Domain.Entities.ProductImage>, IProductImageReadRepository
    {
        public ProductImageReadRepository(APIDBContext context) : base(context)
        {

        }
    }
}
