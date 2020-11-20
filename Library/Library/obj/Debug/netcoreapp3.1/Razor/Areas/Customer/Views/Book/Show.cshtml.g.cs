#pragma checksum "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2c8c63d35f48e4ebc21f7100e2ff83e4ba65000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Book_Show), @"mvc.1.0.view", @"/Areas/Customer/Views/Book/Show.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\asp.net core\Library\Library\Areas\Customer\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp.net core\Library\Library\Areas\Customer\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c8c63d35f48e4ebc21f7100e2ff83e4ba65000", @"/Areas/Customer/Views/Book/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Book_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Models.Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Booking a book with the number id ");
#nullable restore
#line 9 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr class=\"border-light\" />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
           Write(Html.DisplayNameFor(model => model.ResId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
           Write(Html.DisplayNameFor(model => model.BookDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
               Write(Html.DisplayFor(modelItem => item.ResId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
               Write(Html.DisplayFor(modelItem => item.BookDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "D:\asp.net core\Library\Library\Areas\Customer\Views\Book\Show.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Models.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591