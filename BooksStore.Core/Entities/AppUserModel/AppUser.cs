﻿using BooksStore.Core.BasketModel;
using BooksStore.Core.CommentModel;
using BooksStore.Core.OrderModel;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BooksStore.Core.AppUserModel
{
    public class AppUser : IdentityUser
    {
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual int BasketId { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public AppUser()
        {
            Basket = new Basket();
            Orders = new List<Order>();
            Comments = new List<Comment>();
        }
    }
}
