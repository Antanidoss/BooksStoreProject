﻿using BooksStore.Infrastructure;
using BooksStore.Services.DTO;
using BooksStore.Web.Models.ViewModel.CreateModel;
using BooksStore.Web.Models.ViewModel.ReadModel;
using BooksStore.Web.Models.ViewModel.UpdateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksStore.Web.Interfaces.Managers
{
    public interface IRoleViewModelService
    {
        Task<Result> CreateRoleAsync(RoleCreateModel model);
        Task<IEnumerable<RoleViewModel>> GetRolesAsync(int pageNum);
        Task<RoleViewModel> FindRoleByIdAsync(string roleId);
        Task<Result> DeleteAsync(string roleId);
    }
}
