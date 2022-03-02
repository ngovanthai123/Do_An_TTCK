using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LapTop.Models;

namespace LapTop.Services
{
    public interface IProduct
    {
        IEnumerable<Sanpham> getProductAll();
        int totalProduct();
        int numberPage(int totalProduct, int limit);
        IEnumerable<Sanpham> paginationProduct(int start, int limit);

    }
}