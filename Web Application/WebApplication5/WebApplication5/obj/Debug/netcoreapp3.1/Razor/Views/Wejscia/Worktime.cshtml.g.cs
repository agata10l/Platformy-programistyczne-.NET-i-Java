#pragma checksum "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f98fa527daf49b1c2603394b339628f56a8372f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wejscia_Worktime), @"mvc.1.0.view", @"/Views/Wejscia/Worktime.cshtml")]
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
#line 1 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f98fa527daf49b1c2603394b339628f56a8372f0", @"/Views/Wejscia/Worktime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Wejscia_Worktime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication5.Models.Podsumowanie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
  
    ViewData["Title"] = "Worktime";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Worktime</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <input name=\"data\" type=\"month\" />\r\n        <input type=\"submit\" value=\"submit\" />\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPracownik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
           Write(Html.DisplayNameFor(model => model.Imie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
           Write(Html.DisplayNameFor(model => model.Nazwisko));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
           Write(Html.DisplayNameFor(model => model.CzasPracy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
           Write(Html.DisplayNameFor(model => model.Nadgodziny));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
           Write(Html.DisplayNameFor(model => model.Wynagrodzenie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
           Write(Html.DisplayNameFor(model => model.WynagrodzenieEuro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 48 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdPracownik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
               Write(Html.DisplayFor(modelItem => item.Imie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nazwisko));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
               Write(item.CzasPracy.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
               Write(item.Nadgodziny.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
               Write(item.Wynagrodzenie.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
               Write(item.WynagrodzenieEuro.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "C:\Users\kinga\OneDrive\Pulpit\WebApplication5\WebApplication5\Views\Wejscia\Worktime.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication5.Models.Podsumowanie>> Html { get; private set; }
    }
}
#pragma warning restore 1591