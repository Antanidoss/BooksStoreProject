﻿using AutoMapper;
using BooksStore.Core.Entities;
using BooksStore.Services.DTO;
using System.Linq;

namespace BooksStore.Services.Profiles
{
    public class BasketDTOProfile : Profile
    {
        public BasketDTOProfile()
        {
            CreateMap<BookDTO, BookBasketJunction>()
                .ForMember(p => p.BookId, conf => conf.MapFrom(o => o.Id))
                .ForMember(p => p.Id, conf => conf.Ignore());

            CreateMap<Basket, BasketDTO>()
                .ForMember(p => p.BasketBooks, conf => conf.MapFrom(o => o.BasketBooks.Select(f => f.Book)));

            CreateMap<BasketDTO, Basket>()
                .ForMember(p => p.BasketBooks, conf => conf.MapFrom(o => o.BasketBooks));
        }
    }
}
