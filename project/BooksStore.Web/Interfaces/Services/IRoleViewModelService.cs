﻿using BooksStore.Infrastructure;
using BooksStore.Web.Сommon.ViewModel.CreateModel;
using BooksStore.Web.Сommon.ViewModel.ReadModel;
using System.Collections.Generic;
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
