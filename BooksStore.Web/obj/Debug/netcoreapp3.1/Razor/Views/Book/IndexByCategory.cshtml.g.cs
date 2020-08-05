#pragma checksum "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\Book\IndexByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06755e048790f2aa1ce6cf5bcd1cfa9a3c7c4e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_IndexByCategory), @"mvc.1.0.view", @"/Views/Book/IndexByCategory.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.Registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.CreateModels.Book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.AppUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Category;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06755e048790f2aa1ce6cf5bcd1cfa9a3c7c4e1b", @"/Views/Book/IndexByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35cac5bbf695ac1a4b1c468db7e3e5409d36b9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_IndexByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel<BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\Book\IndexByCategory.cshtml"
 if (Model.Objects != null && Model.Objects.Count() != 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\Book\IndexByCategory.cshtml"
Write(await Html.PartialAsync("IndexBooks", new IndexViewModel<BookViewModel>() { Objects = Model.Objects, PageInfo = Model.PageInfo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\Book\IndexByCategory.cshtml"
                                                                                                                                      
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"noBookByCategory-div\"><h3>Нет книг по данной категории</h3>></div>\r\n");
#nullable restore
#line 10 "C:\IT\c#\Проекты\BookStore\BooksStore.Web\Views\Book\IndexByCategory.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel<BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
