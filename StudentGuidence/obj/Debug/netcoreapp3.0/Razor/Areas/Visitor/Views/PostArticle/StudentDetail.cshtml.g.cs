#pragma checksum "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fee22be71689492491f18b6d2a225e7465fd69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Visitor_Views_PostArticle_StudentDetail), @"mvc.1.0.view", @"/Areas/Visitor/Views/PostArticle/StudentDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fee22be71689492491f18b6d2a225e7465fd69", @"/Areas/Visitor/Views/PostArticle/StudentDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec77e8500eaf12dd0617407274c1fdc875e298d", @"/Areas/Visitor/Views/_ViewImports.cshtml")]
    public class Areas_Visitor_Views_PostArticle_StudentDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentGuidence.Models.ViewModels.StudentDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Visitor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PostArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary m-2 rounded-circle text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
  
    ViewData["Title"] = "Student Details";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\r\n    <div class=\"container\">\r\n        <div class=\"row bg-light\">\r\n");
            WriteLiteral("            <div class=\"col-8\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-3 text-start\">\r\n");
#nullable restore
#line 13 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                         foreach (Article article in Model.ArticlesList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fee22be71689492491f18b6d2a225e7465fd695520", async() => {
#nullable restore
#line 16 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                                                                                                    Write(article.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                        WriteLiteral(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                            count++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-9\">\r\n                        <div class=\"row\">\r\n                            <div>\r\n");
            WriteLiteral("                                <p class=\"text-center\"><b>");
#nullable restore
#line 24 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                                     Write(Model.DisplayArticle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; &nbsp;  ");
#nullable restore
#line 24 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                                                                                Write(Model.DisplayArticle.DateOfIssue.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1250, "\"", 1286, 1);
#nullable restore
#line 25 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
WriteAttributeValue("", 1256, Model.DisplayArticle.ImageUrl, 1256, 30, false);

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
#line 29 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                               Write(Model.DisplayArticle.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("\r\n            <div class=\"col-4\">\r\n\r\n                <div class=\"row\">\r\n                    <div>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2006, "\"", 2035, 1);
#nullable restore
#line 43 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
WriteAttributeValue("", 2012, Model.Student.ImageUrl, 2012, 23, false);

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
#line 48 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.FristName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                <h5><label><u>");
#nullable restore
#line 49 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                <h5><label><u>");
#nullable restore
#line 50 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                <h5><label><u>");
#nullable restore
#line 51 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n\r\n                                <h5><label><u>");
#nullable restore
#line 53 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.University.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                <h5><label><u>");
#nullable restore
#line 54 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.Faculty.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                <h5><label><u>");
#nullable restore
#line 55 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></label></h5>\r\n                                <h5><label><u>");
#nullable restore
#line 56 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Visitor\Views\PostArticle\StudentDetail.cshtml"
                                         Write(Model.Student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</u></label></h5>
                            </div>
                            <div class=""col-4 text-end"">
                                <h5><label>:  نوم</label></h5>
                                <h5><label>:  تخلص</label></h5>
                                <h5><label>:  ولایت</label></h5>
                                <h5><label>:  ولسوالی</label></h5>

                                <h5><label>:‌  پوهنتون</label></h5>
                                <h5><label>:‌  فاکولته</label></h5>
                                <h5><label>:‌  دیپارتمنت</label></h5>
                                <h5><label>:‌  ایمل</label></h5>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>






















");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentGuidence.Models.ViewModels.StudentDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
