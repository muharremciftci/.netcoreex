#pragma checksum "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3a619033b513c6436746781233076f78a4cc92c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\_ViewImports.cshtml"
using webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\_ViewImports.cshtml"
using webui.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a619033b513c6436746781233076f78a4cc92c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072a45f7bd2bd031bfea730cd97e7778d792ba6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
  
    var popularClass = Model.Products.Count > 2 ? "popular" : "";
    var products = Model.Products;



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("MessageBox", async() => {
                WriteLiteral("\r\n    \r\n    <div class=\"alert alert-warning text-center m-0 \">\r\n        You have a message ! \r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n\r\n        ");
#nullable restore
#line 25 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n    \r\n");
#nullable restore
#line 31 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
         if (products.Count == 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
                                                  
        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 40 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
                 foreach (var product in products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Users\muhar\Desktop\projects\.netcoreex\webui\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
