#pragma checksum "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b4071fce1dcee1bcbc3eec48d2bdb1b4ef240ba"
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
#nullable restore
#line 2 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
using StudentGuidence.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4071fce1dcee1bcbc3eec48d2bdb1b4ef240ba", @"/Areas/Visitor/Views/PostArticle/Post1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec77e8500eaf12dd0617407274c1fdc875e298d", @"/Areas/Visitor/Views/_ViewImports.cshtml")]
    public class Areas_Visitor_Views_PostArticle_Post1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentGuidence.Models.ViewModels.PostCreateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
  
    ViewData["Title"] = "Teacher Details";
    //  int count = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
 if (SD.Teacher == Model.AuthorType)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section>\r\n        <div class=\"container\">\r\n            <div class=\"row bg-light\">\r\n");
            WriteLiteral("                <div class=\"col-8\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-3 text-start\">\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"col-9\">\r\n                            <div class=\"row\">\r\n                                <div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 1326, "\"", 1355, 1);
#nullable restore
#line 29 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
WriteAttributeValue("", 1332, Model.Article.ImageUrl, 1332, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-center rounded"" style=""width:500px;height:400px;background-position-x:200px;"" />
                                </div>
                                <div class=""text-end "" lang=""ar"" dir=""rtl"" id=""floatingTextarea2"" style=""width:500px;height:500px"">
                                    <p>
                                        ");
#nullable restore
#line 33 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                   Write(Model.Article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"col-4\">\r\n\r\n                    <div class=\"row\">\r\n                        <div>\r\n                            // User Umage\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2166, "\"", 2195, 1);
#nullable restore
#line 46 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
WriteAttributeValue("", 2172, Model.Teacher.ImageUrl, 2172, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded-circle"" style=""width:200px;height:200px; margin-left:100px;"" />
                        </div>
                        <div class=""mt-3"">
                            <div class=""row"">
                                <div class=""col-8 text-end"">
                                    <h5><label><u>");
#nullable restore
#line 51 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 52 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 53 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 54 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 55 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 56 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 57 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 58 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Teacher.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</u></label></h5>
                                </div>
                                <div class=""col-4 text-end"">
                                    <h5><label>:  ??????</label></h5>
                                    <h5><label>:  ????????</label></h5>
                                    <h5><label>:  ??????????</label></h5>
                                    <h5><label>:  ??????????????</label></h5>
                                    <h5><label>:???  ??????????????</label></h5>
                                    <h5><label>:???  ????????</label></h5>
                                    <h5><label>:???  ????????????</label></h5>
                                    <h5><label>:???  ????????</label></h5>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
");
#nullable restore
#line 78 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
}

else if (SD.Student == Model.AuthorType)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <section>\r\n        <div class=\"container\">\r\n            <div class=\"row bg-light\">\r\n");
            WriteLiteral("                <div class=\"col-8\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-3 text-start\">\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"col-9\">\r\n                            <div class=\"row\">\r\n                                <div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 5235, "\"", 5264, 1);
#nullable restore
#line 102 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
WriteAttributeValue("", 5241, Model.Article.ImageUrl, 5241, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-center rounded"" style=""width:500px;height:400px;background-position-x:200px;"" />
                                </div>
                                <div class=""text-end "" lang=""ar"" dir=""rtl"" id=""floatingTextarea2"" style=""width:500px;height:500px"">
                                    <p>
                                        ");
#nullable restore
#line 106 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                   Write(Model.Article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"col-4\">\r\n\r\n                    <div class=\"row\">\r\n                        <div>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 6032, "\"", 6061, 1);
#nullable restore
#line 118 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
WriteAttributeValue("", 6038, Model.Student.ImageUrl, 6038, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded-circle"" style=""width:200px;height:200px; margin-left:100px;"" />
                        </div>
                        <div class=""mt-3"">
                            <div class=""row"">
                                <div class=""col-8 text-end"">
                                    <h5><label><u>");
#nullable restore
#line 123 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.FristName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 124 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 125 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 126 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 127 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 128 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.Faculty.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 129 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.University.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 130 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.UniversityStartDate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                    <h5><label><u>");
#nullable restore
#line 131 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
                                             Write(Model.Student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</u></label></h5>

                                </div>
                                <div class=""col-4 text-end"">
                                    <h5><label>:  ??????</label></h5>
                                    <h5><label>:  ????????</label></h5>
                                    <h5><label>:  ??????????</label></h5>
                                    <h5><label>:  ??????????????</label></h5>
                                    <h5><label>:  ??????????????</label></h5>
                                    <h5><label>:  ????????????</label></h5>
                                    <h5><label>:???  ??????????????????</label></h5>
                                    <h5><label>:???  ?? ?????????????? ?? ?????? ????????</label></h5>
                                    <h5><label>:???  ????????</label></h5>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
");
#nullable restore
#line 153 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"

}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"m-5\">\r\n            <h5 class=\"text-success\">Successfully Posted aritcle Mr.Admin.</h5>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
#nullable restore
#line 165 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\Post1.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentGuidence.Models.ViewModels.PostCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
