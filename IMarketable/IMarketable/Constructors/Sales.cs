using IMarketable.CategoryOfProductEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMarketable.Data;

namespace IMarketable.Constructors
{
    public class Sales : Products

    {
        public Sales(string productName, decimal productPrice, CategoryOfProduct productCategory, int number, int id) : base(productName, productPrice, productCategory, number, id)
        {
        }
    }
}
