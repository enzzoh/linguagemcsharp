#pragma checksum "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\Resp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38fabbbba2f203627bbad6ee84de54b5358d8705"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resp_Index), @"mvc.1.0.view", @"/Views/Resp/Index.cshtml")]
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
#line 1 "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\_ViewImports.cshtml"
using SLNListaDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\_ViewImports.cshtml"
using SLNListaDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38fabbbba2f203627bbad6ee84de54b5358d8705", @"/Views/Resp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9262f202340c7b6a62c0ff780c2d8527006b63a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Resp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div>
    <h1>Lista RESPONSAVEIS</h1>
</div>


<div id="" Divtabela"">
    <table class=""table table-striped"">
        <thead>
            <tr>

                <th scope=""col""> Codigo</th>
                <th scope=""col""> Nome </th>
                <th scope=""col""> Sobrenome </th>

            </tr>







        </thead>
        <tbody>

");
#nullable restore
#line 31 "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\Resp\Index.cshtml"
             foreach (var item in ViewBag.listaresponsaveis)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\Resp\Index.cshtml"
                   Write(item.respID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\Resp\Index.cshtml"
                   Write(item.NomeResp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\Resp\Index.cshtml"
                   Write(item.SobrenomeResp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\android.LABFIES\source\repos\SLNListaDB\SLNListaDB\Views\Resp\Index.cshtml"






            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </table>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
