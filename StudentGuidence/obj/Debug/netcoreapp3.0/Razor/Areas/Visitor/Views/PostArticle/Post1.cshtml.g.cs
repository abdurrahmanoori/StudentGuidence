#pragma checksum "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8d9f118f2b979c97c1b14ee09a8a6db1d43ea26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Visitor_Views_PostArticle_Post1), @"mvc.1.0.view", @"/Areas/Visitor/Views/PostArticle/Post1.cshtml")]
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
#line 1 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\_ViewImports.cshtml"
using StudentGuidence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\_ViewImports.cshtml"
using StudentGuidence.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8d9f118f2b979c97c1b14ee09a8a6db1d43ea26", @"/Areas/Visitor/Views/PostArticle/Post1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec77e8500eaf12dd0617407274c1fdc875e298d", @"/Areas/Visitor/Views/_ViewImports.cshtml")]
    public class Areas_Visitor_Views_PostArticle_Post1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentGuidence.Models.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
  
    ViewData["Title"] = "Post1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcom To The Post</h1>\r\n\r\n<h3>Post by ");
#nullable restore
#line 8 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<hr />\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>");
#nullable restore
#line 14 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
Write(Model.DateOfIssue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentGuidence.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591