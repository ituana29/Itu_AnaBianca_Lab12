using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Itu_AnaBianca_Lab12.Models;

namespace Itu_AnaBianca_Lab12.Data
{
    public interface IRestService
    {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
    }
}
