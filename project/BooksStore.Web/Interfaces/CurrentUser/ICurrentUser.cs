﻿using BooksStore.Core.AppUserModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.Web.Interfaces
{
    public interface ICurrentUser
    {        
        Task<AppUser> GetCurrentAppUser(HttpContext httpContext);
    }
}