#pragma checksum "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Areas\ProniaAdmin\Views\Size\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86956648ac8606393e2642059ef991c18f1a35ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProniaAdmin_Views_Size_Detail), @"mvc.1.0.view", @"/Areas/ProniaAdmin/Views/Size/Detail.cshtml")]
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
#line 1 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using Pronia_start.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using Pronia_start.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86956648ac8606393e2642059ef991c18f1a35ce", @"/Areas/ProniaAdmin/Views/Size/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51f96dcc3d5ae4bf23cafccc6abe7772328473e3", @"/Areas/ProniaAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_ProniaAdmin_Views_Size_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Size>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Areas\ProniaAdmin\Views\Size\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <h4>\r\n            Id\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 12 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Areas\ProniaAdmin\Views\Size\Detail.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div>\r\n        <h4>\r\n            Name\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 20 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Areas\ProniaAdmin\Views\Size\Detail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Size> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
