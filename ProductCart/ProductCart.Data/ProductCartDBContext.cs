using Microsoft.EntityFrameworkCore;
using System;

namespace ProductCart.Data
{
    public class ProductCartDBContext : DbContext
    {



        #region Constructor
        public ProductCartDBContext()
        {

            Database.SetCommandTimeout(60);
        }

        public ProductCartDBContext(DbContextOptions<ProductCartDBContext> options)
            : base(options)
        {
           
            Database.SetCommandTimeout(60);
        }
        #endregion


    }



}

