#pragma checksum "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c66c32427d3b6521138959d952930746b658724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_Index), @"mvc.1.0.view", @"/Views/Upload/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c66c32427d3b6521138959d952930746b658724", @"/Views/Upload/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Images>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
  
    ViewData["Title"] = "Upload";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a asp-action=\"AddProfile\" class=\"btn btn-info\">Add Profiles</a>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <th>Profile Picture</th>\r\n            <th>User Name</th>\r\n        </tr>\r\n");
#nullable restore
#line 15 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n");
#nullable restore
#line 18 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
                 if (item.Picture != null)
                {
                    var base64 = Convert.ToBase64String(item.Picture);
                    var img = string.Format("data:image/jpg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 589, "\"", 599, 1);
#nullable restore
#line 22 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
WriteAttributeValue("", 595, img, 595, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" height=\"100px\" />\r\n");
#nullable restore
#line 23 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
                }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 730, "\"", 736, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" height=\"100px\" />\r\n");
#nullable restore
#line 27 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
           Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 32 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 34 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>No Images</h4>\r\n");
#nullable restore
#line 38 "C:\Users\cavad\OneDrive\Desktop\New folder (3)\Enftoomark\EnftomarkBack\Views\Upload\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Images>> Html { get; private set; }
    }
}
#pragma warning restore 1591