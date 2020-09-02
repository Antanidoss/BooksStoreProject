﻿using AutoMapper;
using BooksStore.Service.DTO;
using BooksStore.Web.Models.ViewModel.ReadModel;

namespace BooksStore.Web.Profiles
{
    public class OrderVMProfile : Profile
    {
        public OrderVMProfile()
        {
            CreateMap<OrderDTO, OrderViewModel>()
                    .ForMember(p => p.BooksViewModel, conf => conf.MapFrom(o => o.BooksOrder));
        }
    }
}
