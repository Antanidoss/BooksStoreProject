#pragma checksum "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_IndexBasket), @"mvc.1.0.view", @"/Views/Basket/IndexBasket.cshtml")]
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
#line 1 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.Registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.CreateModels.Book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.AppUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\IT\c#\Test\BooksStore.Web\Views\_ViewImports.cshtml"
using BooksStore.Web.Models.ViewModels.Category;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c", @"/Views/Basket/IndexBasket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35cac5bbf695ac1a4b1c468db7e3e5409d36b9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_IndexBasket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveBasketBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveAllBasketBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"indexBasket-main\">\r\n");
#nullable restore
#line 5 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
     if (Model.BookIndexModel.Objects != null && Model.BookIndexModel.Objects.Count() != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"indexBooks-div\">\r\n\r\n");
#nullable restore
#line 9 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
             foreach (var book in Model.BookIndexModel.Objects)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"indexBooks-book-div\">\r\n\r\n                    <div class=\"indexBooks-bookTitle-div\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c8813", async() => {
#nullable restore
#line 14 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
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
#line 14 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
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
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"indexBooks-bookImg-div\">\r\n");
#nullable restore
#line 18 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
                         if (!string.IsNullOrEmpty(book.ImgPath))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c11811", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 834, "\"", 866, 1);
#nullable restore
#line 21 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
WriteAttributeValue("", 840, Url.Content(book.ImgPath), 840, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            ");
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
#line 20 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                    <div class=""indexBooks-bookStock-div"">
                        <text>В наличии</text>
                    </div>

                    <div class=""indexBasket-lowPanel"">
                        <div class=""basketIndex-buy"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c15154", async() => {
                WriteLiteral("\r\n                                <input name=\"createModel.BookOrderIds\"");
                BeginWriteAttribute("value", " value=\"", 1377, "\"", 1393, 1);
#nullable restore
#line 33 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
WriteAttributeValue("", 1385, book.Id, 1385, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n                                <div>\r\n                                    <input type=\"submit\" value=\"Купить\" class=\"basketIndex-buy-dutton button\" />\r\n                                </div>\r\n                            ");
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
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"indexBooks-BasketbookPrice-div\">\r\n                            ");
#nullable restore
#line 41 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
                       Write(book.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"basketIndex-remove\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c18173", async() => {
                WriteLiteral("\r\n                                <input");
                BeginWriteAttribute("value", " value=\"", 2035, "\"", 2051, 1);
#nullable restore
#line 46 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
WriteAttributeValue("", 2043, book.Id, 2043, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" name=\"bookId\" />\r\n                                <input type=\"submit\" value=\"Убрать с корзины\" class=\"basketIndex-removeBook-dutton button\" />\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
            WriteLiteral("        <div class=\"buyRemoveAll-baasket-div\">\r\n            <div class=\"basketIndex-buyAll-div\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c21051", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
                     for (int i = 0; i < Model.BookIndexModel.Objects.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input");
                BeginWriteAttribute("name", " name=\"", 2685, "\"", 2720, 3);
                WriteAttributeValue("", 2692, "createModel.BookOrderIds[", 2692, 25, true);
#nullable restore
#line 60 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
WriteAttributeValue("", 2717, i, 2717, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2719, "]", 2719, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2721, "\"", 2764, 1);
#nullable restore
#line 60 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
WriteAttributeValue("", 2729, Model.BookIndexModel.Objects[i].Id, 2729, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n");
#nullable restore
#line 61 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div>\r\n                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2878, "\"", 2928, 3);
                WriteAttributeValue("", 2886, "Купить", 2886, 6, true);
                WriteAttributeValue(" ", 2892, "все", 2893, 4, true);
#nullable restore
#line 63 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
WriteAttributeValue(" ", 2896, Model.TotalPrice.ToString("c"), 2897, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"basketIndex-buyAll-dutton button\" />\r\n                    </div>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"basketIndex-removeAll-div\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ce5bbbdb3f0ed98c8283a3026d4c588c838c17c25069", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Очистить корзину\" class=\"button\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div>\r\n\r\n");
#nullable restore
#line 77 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
             if (Model.BookIndexModel.PageInfo.TotalPage != Model.BookIndexModel.PageInfo.PageNumber)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
           Write(Html.ActionLink("Вперед", "IndexBasket", "Basket", new { pageNum = (Model.BookIndexModel.PageInfo.PageNumber + 1) }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
                                                                                                                                     
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
             if (Model.BookIndexModel.PageInfo.PageNumber > 1)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
           Write(Html.ActionLink("Назад", "IndexBasket", "Basket", new { pageNum = (Model.BookIndexModel.PageInfo.PageNumber - 1) }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
                                                                                                                                    
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 88 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"basketEmpty-text-div\">\r\n            <h3>У вас нет товаров в корзине</h3>\r\n        </div>\r\n");
#nullable restore
#line 94 "C:\IT\c#\Test\BooksStore.Web\Views\Basket\IndexBasket.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591