#pragma checksum "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a76d5a4ae19de1ee327222a2f2d77b6395c4d57f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_IndexBooks), @"mvc.1.0.view", @"/Views/Book/IndexBooks.cshtml")]
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
#line 1 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModel.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModel.UpdateModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModel.CreateModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModel.ReadModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76d5a4ae19de1ee327222a2f2d77b6395c4d57f", @"/Views/Book/IndexBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23a95437b57fa1f82e40a1ec6de41642d36f86d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_IndexBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasketBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
Write(await Html.PartialAsync("SearchPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
 if (Model.BookIndexModel.Objects != null && Model.BookIndexModel.Objects.Count() != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"indexBooks-main\">\n        <div class=\"indexBooks-div\">\n");
#nullable restore
#line 9 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
             foreach (var book in Model.BookIndexModel.Objects)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"indexBooks-book-div\">\n\n                    <div class=\"indexBooks-bookTitle-div\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a76d5a4ae19de1ee327222a2f2d77b6395c4d57f7688", async() => {
#nullable restore
#line 14 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                                                                                               Write(book.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                                                                              WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n\n                    <div class=\"indexBooks-bookImg-div\">\n");
#nullable restore
#line 18 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                         if (!string.IsNullOrEmpty(book.ImgPath))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a76d5a4ae19de1ee327222a2f2d77b6395c4d57f10733", async() => {
                WriteLiteral("\n                                <img");
                BeginWriteAttribute("src", " src=\"", 852, "\"", 884, 1);
#nullable restore
#line 21 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
WriteAttributeValue("", 858, Url.Content(book.ImgPath), 858, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                                                                                  WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 23 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n\n");
#nullable restore
#line 26 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                     if (book.InStock)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"indexBooks-bookStock-div\">\n                            <text>В наличии</text>                          \n                        </div>\n");
            WriteLiteral("                        <div class=\"indexBooks-book-lowPanel\">\n");
#nullable restore
#line 33 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                             if (!book.IsAddToBasket)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"indexBooks-AddBasket-div\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a76d5a4ae19de1ee327222a2f2d77b6395c4d57f14754", async() => {
                WriteLiteral("\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1595, "\"", 1611, 1);
#nullable restore
#line 37 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
WriteAttributeValue("", 1603, book.Id, 1603, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"bookId\" />\n                                        <input type=\"submit\" value=\"Добавить в корзину\" class=\"button\" />\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 41 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"bookInBasket-div\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a76d5a4ae19de1ee327222a2f2d77b6395c4d57f17617", async() => {
                WriteLiteral("\n                                        Уже в корзине<i class=\"fas fa-check\"></i>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 49 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"indexBooks-bookPrice-div\">\n                                ");
#nullable restore
#line 52 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                           Write(book.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n\n                            <div class=\"indexBooks-bookAuthName-div\">\n                                ");
#nullable restore
#line 56 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                           Write(book.AuthorFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n");
#nullable restore
#line 59 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"indexBooks-noneStock\">\n                            Нет в наличии\n                        </div>\n");
#nullable restore
#line 65 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n");
#nullable restore
#line 67 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"indexBooks-pagination-div\">\n            <div>\n");
#nullable restore
#line 71 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                 if (Model.BookIndexModel.PageInfo.PageNumber > 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a76d5a4ae19de1ee327222a2f2d77b6395c4d57f21484", async() => {
                WriteLiteral("Назад");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNum", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                                                                             WriteLiteral(Model.BookIndexModel.PageInfo.PageNumber - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNum"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNum", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNum"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 74 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <div>\n");
#nullable restore
#line 77 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                 if (Model.BookIndexModel.PageInfo.TotalPage > Model.BookIndexModel.PageInfo.PageNumber)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a76d5a4ae19de1ee327222a2f2d77b6395c4d57f24516", async() => {
                WriteLiteral("Вперед");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNum", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                                                                             WriteLiteral(Model.BookIndexModel.PageInfo.PageNumber + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNum"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNum", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNum"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 80 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 84 "C:\IT\c#\Проекты\BooksStore\project\BooksStore.Web\Views\Book\IndexBooks.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
