#pragma checksum "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80511d23f0c37f2ea0e4fc7fe33614f837888e01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NistTutorial_StringManipulation), @"mvc.1.0.view", @"/Views/NistTutorial/StringManipulation.cshtml")]
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
#line 1 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\_ViewImports.cshtml"
using TestingNetNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\_ViewImports.cshtml"
using TestingNetNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80511d23f0c37f2ea0e4fc7fe33614f837888e01", @"/Views/NistTutorial/StringManipulation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2bd435182ba9a1e02efbdac9b340bc0170895b", @"/Views/_ViewImports.cshtml")]
    public class Views_NistTutorial_StringManipulation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
  
    ViewData["Title"] = "StingManipulation";
    string name = "DiPendra karki";
    string requiredSurname = "karki";

    DateTime currentDate = DateTime.Now;

    List<string> NameList = new List<string>();
    NameList.Add("Dependra karki");
    NameList.Add("arati thapa");
    NameList.Add("arun dhungel");
    NameList.Add("sagar dhonju");
    NameList.Add("sameep banjara");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>StingManipulation</h1>\r\n\r\n");
            WriteLiteral("    <table border=\"1\">\r\n        <tr>\r\n            <td>\r\n                The length of String is:\r\n            </td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
           Write(name.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                the capital, lower  case is :\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
           Write(name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,  ");
#nullable restore
#line 31 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                              Write(name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Names that starts from \"A\"\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 39 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                 foreach (string nam in NameList.Where(x => x.StartsWith("a")))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 41 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                     Write(nam.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,</span>\r\n");
#nullable restore
#line 42 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td>2nd and 5th letter of Name is  </td>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
           Write(name[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 48 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                      Write(name[4]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                               Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                comparing two strings using compare to\r\n            </td>\r\n            <td> ");
#nullable restore
#line 54 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
            Write(name.CompareTo("dipendra karki"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                comparing two strings using equals to\r\n            </td>\r\n            <td> ");
#nullable restore
#line 60 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
            Write(name.ToUpper().Equals(("dipendra karki").ToUpper()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                current date\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
           Write(currentDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 67 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                                             Write(currentDate.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 67 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\NistTutorial\StringManipulation.cshtml"
                                                                     Write(currentDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
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
