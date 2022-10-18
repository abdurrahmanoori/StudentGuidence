#pragma checksum "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Admin\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e5d272f7416ca590ef0474b0e9ad10c698da9d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Student_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Student/Detail.cshtml")]
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
#line 1 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Admin\Views\_ViewImports.cshtml"
using StudentGuidence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdurrahman\source\repos\StudentGuidence\StudentGuidence\Areas\Admin\Views\_ViewImports.cshtml"
using StudentGuidence.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5d272f7416ca590ef0474b0e9ad10c698da9d9", @"/Areas/Admin/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec77e8500eaf12dd0617407274c1fdc875e298d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<th>First Name</th>
<th>Last Name</th>
<th>Article</th>

<th>Province</th>
<th>District</th>
<th>Department</th>
<th>University Start</th>
<th>Image</th>


<section style=""background-color: #eee;"">
    <div class=""container py-5"">
        <div class=""row"">
            <div class=""col"">
                <nav aria-label=""breadcrumb"" class=""bg-light rounded-3 p-3 mb-4"">
                    <ol class=""breadcrumb mb-0"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">User</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">User Profile</li>
                    </ol>
                </nav>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""card mb-4"">
                    <div class=""card-body text-center"">
                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templat");
            WriteLiteral(@"es/bootstrap-chat/ava3.webp"" alt=""avatar""
                             class=""rounded-circle img-fluid"" style=""width: 150px;"">
                        <h5 class=""my-3"">John Smith</h5>
                        <p class=""text-muted mb-1"">Full Stack Developer</p>
                        <p class=""text-muted mb-4"">Bay Area, San Francisco, CA</p>
                        <div class=""d-flex justify-content-center mb-2"">
                            <button type=""button"" class=""btn btn-primary"">Follow</button>
                            <button type=""button"" class=""btn btn-outline-primary ms-1"">Message</button>
                        </div>
                    </div>
                </div>
                <div class=""card mb-4 mb-lg-0"">
                    <div class=""card-body p-0"">
                        <ul class=""list-group list-group-flush rounded-3"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i c");
            WriteLiteral(@"lass=""fas fa-globe fa-lg text-warning""></i>
                                <p class=""mb-0"">https://mdbootstrap.com</p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-github fa-lg"" style=""color: #333333;""></i>
                                <p class=""mb-0"">mdbootstrap</p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-twitter fa-lg"" style=""color: #55acee;""></i>
                                <p class=""mb-0""></p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-instagram fa-lg"" style=""color: #ac2bac;""></i>
                                <p class=""mb-0"">mdbootstrap");
            WriteLiteral(@"</p>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center p-3"">
                                <i class=""fab fa-facebook-f fa-lg"" style=""color: #3b5998;""></i>
                                <p class=""mb-0"">mdbootstrap</p>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""card mb-4"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <p class=""mb-0"">Full Name</p>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""text-muted mb-0"">Johnatan Smith</p>
                            </div>
                        </div>
                        <hr>
                        <d");
            WriteLiteral(@"iv class=""row"">
                            <div class=""col-sm-3"">
                                <p class=""mb-0"">Email</p>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""text-muted mb-0"">example@example.com</p>
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <p class=""mb-0"">Phone</p>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""text-muted mb-0"">(097) 234-5678</p>
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <p class=""mb-0"">Mobile</p>
                            </div>
                ");
            WriteLiteral(@"            <div class=""col-sm-9"">
                                <p class=""text-muted mb-0"">(098) 765-4321</p>
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <p class=""mb-0"">Address</p>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""text-muted mb-0"">Bay Area, San Francisco, CA</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""card mb-4 mb-md-0"">
                            <div class=""card-body"">
                                <p class=""mb-4"">
                                    <span class=""text-primary font-italic me-1"">assigment</span> Project Status
   ");
            WriteLiteral(@"                             </p>
                                <p class=""mb-1"" style=""font-size: .77rem;"">Web Design</p>
                                <div class=""progress rounded"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                                <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">Website Markup</p>
                                <div class=""progress rounded"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                                <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">One Page</p>
                                <div cla");
            WriteLiteral(@"ss=""progress rounded"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                                <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">Mobile Template</p>
                                <div class=""progress rounded"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                                <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">Backend API</p>
                                <div class=""progress rounded mb-2"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 66%"" aria-valueno");
            WriteLiteral(@"w=""66""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""card mb-4 mb-md-0"">
                            <div class=""card-body"">
                                <p class=""mb-4"">
                                    <span class=""text-primary font-italic me-1"">assigment</span> Project Status
                                </p>
                                <p class=""mb-1"" style=""font-size: .77rem;"">Web Design</p>
                                <div class=""progress rounded"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
               ");
            WriteLiteral(@"                 <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">Website Markup</p>
                                <div class=""progress rounded"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                                <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">One Page</p>
                                <div class=""progress rounded"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                                <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">Mobile Template</p>
                                <div class=""progress rounded"" style=""height: 5px");
            WriteLiteral(@";"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                                <p class=""mt-4 mb-1"" style=""font-size: .77rem;"">Backend API</p>
                                <div class=""progress rounded mb-2"" style=""height: 5px;"">
                                    <div class=""progress-bar"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
























");
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
