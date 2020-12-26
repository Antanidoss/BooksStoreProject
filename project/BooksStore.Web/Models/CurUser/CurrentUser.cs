﻿using BooksStore.Services.DTO;
using BooksStore.Services.Interfaces.Identity;
using BooksStore.Web.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BooksStore.Web.Models.CurUser
{
    public class CurrentUser : ICurrentUser
    {       
        public CurrentUser(IUserService userManagerService)
        {
            UserManagerService = userManagerService;       
        }
        IUserService UserManagerService { get; set; }
        public string AppUserId { get; set; }
        public bool IsAuthenticated { get; set; }
        public int BasketId { get; set; }

        public async Task<AppUserDTO> GetCurrentUser(HttpContext httpContext)
        {
            return (await UserManagerService.FindAppUserByIdAsync(httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier))).AppUserDTO;
        }
    }
}
