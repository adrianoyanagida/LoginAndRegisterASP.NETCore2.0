#pragma checksum "C:\Users\Adriano\Área de Trabalho 2\Outros\Projetos Pessoais\C#\LoginAndRegister\LoginAndRegister\Views\AccountData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dafd4015c48205b99624cbcd406469481c3fe1e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountData_Index), @"mvc.1.0.view", @"/Views/AccountData/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountData/Index.cshtml", typeof(AspNetCore.Views_AccountData_Index))]
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
#line 1 "C:\Users\Adriano\Área de Trabalho 2\Outros\Projetos Pessoais\C#\LoginAndRegister\LoginAndRegister\Views\_ViewImports.cshtml"
using LoginAndRegister.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafd4015c48205b99624cbcd406469481c3fe1e3", @"/Views/AccountData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d53f78e6c0b023dd8cb59ae760fbc7492d8a590", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 103, true);
            WriteLiteral("<div class=\"row loginForm\">\r\n    <div class=\"col-md-8\">\r\n        <p></p>\r\n        <h3>Nome da conta é: ");
            EndContext();
            BeginContext(104, 16, false);
#line 4 "C:\Users\Adriano\Área de Trabalho 2\Outros\Projetos Pessoais\C#\LoginAndRegister\LoginAndRegister\Views\AccountData\Index.cshtml"
                        Write(ViewBag.userName);

#line default
#line hidden
            EndContext();
            BeginContext(120, 25, true);
            WriteLiteral("</h3>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
