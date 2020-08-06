﻿using BooksStore.Core.BasketModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.Infastructure.Interfaces
{
    public interface IBasketRepository
    {
        Task AddBasketAsync(Basket basket);
        Task<Basket> GetBasketById(int basketId);
        Task RemoveBasketAsync(Basket basket);
        Task<IEnumerable<Basket>> GetBaskets(int skip, int take);
        Task UpdateBasketAsync(Basket basket);
    }
}