#pragma checksum "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123097aabe70847aa0b97dede9b556ed49be818b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoggedIn_Index), @"mvc.1.0.view", @"/Views/LoggedIn/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoggedIn/Index.cshtml", typeof(AspNetCore.Views_LoggedIn_Index))]
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
#line 2 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\_ViewImports.cshtml"
using CourseProjectApp;

#line default
#line hidden
#line 3 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\_ViewImports.cshtml"
using CourseProjectApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123097aabe70847aa0b97dede9b556ed49be818b", @"/Views/LoggedIn/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5fd2f75c8f104e79378b0bea8dd376017dcf9b1", @"/Views/_ViewImports.cshtml")]
    public class Views_LoggedIn_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseProjectApp.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
            BeginContext(116, 328, true);
            WriteLiteral(@"
<p style=""margin-top:60px;""></p>
<div class=""ui two column doubling stackable grid container"">
    <div class=""column"">
        <a class=""ui card"">
            <div class=""content"">
                <div class=""header"">Individual</div>
                <div class=""meta""></div>
                <div class=""description"">
");
            EndContext();
#line 15 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                     foreach (var item in Model.Individuals)
                    {

#line default
#line hidden
            BeginContext(529, 95, true);
            WriteLiteral("                        <div class=\"ui list\">\r\n                            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 624, "\"", 650, 1);
#line 18 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
WriteAttributeValue("", 632, item.IndividualId, 632, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(651, 51, true);
            WriteLiteral(" />\r\n                            <div class=\"item\">");
            EndContext();
            BeginContext(703, 13, false);
#line 19 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                         Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(716, 54, true);
            WriteLiteral("</div>\r\n                            <div class=\"item\">");
            EndContext();
            BeginContext(771, 39, false);
#line 20 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                         Write(item.DateOfBirth.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(810, 54, true);
            WriteLiteral("</div>\r\n                            <div class=\"item\">");
            EndContext();
            BeginContext(865, 12, false);
#line 21 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                         Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(877, 54, true);
            WriteLiteral("</div>\r\n                            <div class=\"item\">");
            EndContext();
            BeginContext(932, 9, false);
#line 22 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                         Write(item.City);

#line default
#line hidden
            EndContext();
            BeginContext(941, 40, true);
            WriteLiteral("</div>\r\n                        </div>\r\n");
            EndContext();
#line 24 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1004, 521, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""extra content"">
                <div class=""right floated author"">
                    <button class=""ui primary button"">Edit</button>
                </div>
            </div>
        </a>

        <div class=""column"">
            <a class=""ui card"">
                <div class=""content"">
                    <div class=""header"">Organization</div>
                    <div class=""meta""></div>
                    <div class=""description"">
");
            EndContext();
#line 40 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                         foreach (var item in Model.Organization)
                        {

#line default
#line hidden
            BeginContext(1619, 103, true);
            WriteLiteral("                            <div class=\"ui list\">\r\n                                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1722, "\"", 1750, 1);
#line 43 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
WriteAttributeValue("", 1730, item.OrganizationId, 1730, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1751, 55, true);
            WriteLiteral(" />\r\n                                <div class=\"item\">");
            EndContext();
            BeginContext(1807, 18, false);
#line 44 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                             Write(item.BussinessName);

#line default
#line hidden
            EndContext();
            BeginContext(1825, 58, true);
            WriteLiteral("</div>\r\n                                <div class=\"item\">");
            EndContext();
            BeginContext(1884, 36, false);
#line 45 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                             Write(item.HireDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 58, true);
            WriteLiteral("</div>\r\n                                <div class=\"item\">");
            EndContext();
            BeginContext(1979, 15, false);
#line 46 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                             Write(item.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 58, true);
            WriteLiteral("</div>\r\n                                <div class=\"item\">");
            EndContext();
            BeginContext(2053, 12, false);
#line 47 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                             Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2065, 58, true);
            WriteLiteral("</div>\r\n                                <div class=\"item\">");
            EndContext();
            BeginContext(2124, 9, false);
#line 48 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                             Write(item.City);

#line default
#line hidden
            EndContext();
            BeginContext(2133, 46, true);
            WriteLiteral("</div>\r\n\r\n                            </div>\r\n");
            EndContext();
#line 51 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2206, 544, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""extra content"">
                    <div class=""right floated author"">
                        <button class=""ui primary button"">Edit</button>
                    </div>
                </div>
            </a>
        </div>
        
            <a class=""ui card"">
                <div class=""content"">
                    <div class=""header"">Hobbies</div>
                    <div class=""meta""></div>
                    <div class=""description"">
");
            EndContext();
#line 68 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                         foreach (var item in Model.Hobby)
                        {

#line default
#line hidden
            BeginContext(2837, 95, true);
            WriteLiteral("                        <div class=\"ui list\">\r\n                            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2932, "\"", 2955, 1);
#line 71 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
WriteAttributeValue("", 2940, item.HobbiesId, 2940, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2956, 52, true);
            WriteLiteral(" />\r\n                            <span class=\"item\">");
            EndContext();
            BeginContext(3009, 9, false);
#line 72 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3018, 206, true);
            WriteLiteral("</span>\r\n                            <script type=\"text/javascript\">$(document).ready(function () { $(\".rating\").rating(); });</script>\r\n                            <div class=\"ui star rating\" data-rating=\"");
            EndContext();
            BeginContext(3225, 11, false);
#line 74 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                                                                Write(item.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(3236, 62, true);
            WriteLiteral("\" data-max-rating=\"5\"></div>\r\n                        </div>\r\n");
            EndContext();
#line 76 "C:\Users\Irhad Mrndzic\Desktop\YT_AspNetCore\CourseProjectApp\CourseProjectApp\Views\LoggedIn\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3325, 351, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""extra content"">
                    <div class=""right floated author"">
                        <button class=""ui primary button"">Edit</button>
                    </div>
                </div>
            </a>
       



    </div>










</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseProjectApp.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
