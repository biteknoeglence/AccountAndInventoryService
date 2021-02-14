﻿using ShopInGame.Abstract;
using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Concreate
{
    public class ShopManager : IShopManagerService
    {
        public void Buy(Account account, Product product)
        {
            account.InventoryItems.Add(product);
            Console.WriteLine("{0} kullanıcısı {1} TL değerindeki {2} adlı itemini satın aldı.",account.AccountName,product.productDiscountPrice,product.ItemName);
        }

    }
}
