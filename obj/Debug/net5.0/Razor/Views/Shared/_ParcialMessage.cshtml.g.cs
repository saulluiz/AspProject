#pragma checksum "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\AspProject\Views\Shared\_ParcialMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d288e8f0a735d843bd94d804db8ee784e2bbf54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspProject.Models.Shared.Views_Shared__ParcialMessage), @"mvc.1.0.view", @"/Views/Shared/_ParcialMessage.cshtml")]
namespace AspProject.Models.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d288e8f0a735d843bd94d804db8ee784e2bbf54", @"/Views/Shared/_ParcialMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72e1399639ece610b8d4c45296ba5b2e009f227d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ParcialMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\AspProject\Views\Shared\_ParcialMessage.cshtml"
  
    string[] texto= Model.Split("//"); 
   

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 72, "\"", 165, 10);
            WriteAttributeValue("", 80, "bg-", 80, 3, true);
#nullable restore
#line 6 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\AspProject\Views\Shared\_ParcialMessage.cshtml"
WriteAttributeValue(" ", 83, texto[3], 84, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 95, "-100", 95, 4, true);
            WriteAttributeValue(" ", 99, "border", 100, 7, true);
            WriteAttributeValue(" ", 106, "border-green-400", 107, 17, true);
            WriteAttributeValue(" ", 123, "text-green-700", 124, 15, true);
            WriteAttributeValue(" ", 138, "px-4", 139, 5, true);
            WriteAttributeValue(" ", 143, "py-3", 144, 5, true);
            WriteAttributeValue(" ", 148, "rounded", 149, 8, true);
            WriteAttributeValue(" ", 156, "relative", 157, 9, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n  <strong class=\"font-bold\">");
#nullable restore
#line 7 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\AspProject\Views\Shared\_ParcialMessage.cshtml"
                       Write(texto[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n  <span class=\"block sm:inline\">");
#nullable restore
#line 8 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\AspProject\Views\Shared\_ParcialMessage.cshtml"
                           Write(texto[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
  <span class=""absolute top-0 bottom-0 right-0 px-4 py-3"">
    <svg class=""fill-current h-6 w-6 text-red-500"" role=""button"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20""><title>Close</title><path d=""M14.348 14.849a1.2 1.2 0 0 1-1.697 0L10 11.819l-2.651 3.029a1.2 1.2 0 1 1-1.697-1.697l2.758-3.15-2.759-3.152a1.2 1.2 0 1 1 1.697-1.697L10 8.183l2.651-3.031a1.2 1.2 0 1 1 1.697 1.697l-2.758 3.152 2.758 3.15a1.2 1.2 0 0 1 0 1.698z""/></svg>
  </span>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591
