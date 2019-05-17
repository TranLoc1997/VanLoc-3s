#pragma checksum "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98ec3bfcda039ee167133d01b797132e4be9f49b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SelectLanguagePartial), @"mvc.1.0.view", @"/Views/User/SelectLanguagePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/SelectLanguagePartial.cshtml", typeof(AspNetCore.Views_User_SelectLanguagePartial))]
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
#line 1 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/_ViewImports.cshtml"
using TaskUser;

#line default
#line hidden
#line 2 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/_ViewImports.cshtml"
using TaskUser.Models;

#line default
#line hidden
#line 4 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/_ViewImports.cshtml"
using TaskUser.Resources;

#line default
#line hidden
#line 1 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#line 2 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98ec3bfcda039ee167133d01b797132e4be9f49b", @"/Views/User/SelectLanguagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5cba43507413bc679cf4227df7d8ac0e05118c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SelectLanguagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetLanguage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(117, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(216, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 9 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
  
    var cultures = LocalizationOptions.Value.SupportedUICultures.ToList();
    

#line default
#line hidden
            BeginContext(303, 180, true);
            WriteLiteral("\n<a class=\"nav-link\" data-toggle=\"collapse\" href=\"#language\" aria-expanded=\"false\" aria-controls=\"language\">\n    <i class=\"mdi mdi-web menu-icon\"></i>\n    <span class=\"menu-title\">");
            EndContext();
            BeginContext(484, 21, false);
#line 16 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
                        Write(Localizer["Language"]);

#line default
#line hidden
            EndContext();
            BeginContext(505, 124, true);
            WriteLiteral("</span> \n    <i class=\"menu-arrow\"></i>\n</a>\n<div class=\"collapse\" id=\"language\">\n    <ul class=\"nav flex-column sub-menu\">\n");
            EndContext();
#line 21 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
     foreach (var item in cultures)
    {
        var img = item.Name + ".png";

#line default
#line hidden
            BeginContext(709, 49, true);
            WriteLiteral("        <li class=\"btn btn-default\">\n            ");
            EndContext();
            BeginContext(758, 288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ec3bfcda039ee167133d01b797132e4be9f49b6416", async() => {
                BeginContext(956, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(973, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "98ec3bfcda039ee167133d01b797132e4be9f49b6804", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 983, "~/img/", 983, 6, true);
#line 30 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
AddHtmlAttributeValue("", 989, img, 989, 4, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(996, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(1014, 15, false);
#line 31 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
           Write(item.NativeName);

#line default
#line hidden
                EndContext();
                BeginContext(1029, 13, true);
                WriteLiteral("\n            ");
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-culture", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
                      WriteLiteral(item.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["culture"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-culture", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["culture"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 29 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
                        WriteLiteral(Context.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1046, 15, true);
            WriteLiteral("\n        </li>\n");
            EndContext();
#line 34 "/home/local/3SI/loc.tv/RiderProjects/VanLoc-3s/TaskUser/Views/User/SelectLanguagePartial.cshtml"
    }

#line default
#line hidden
            BeginContext(1067, 16, true);
            WriteLiteral("    </ul>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> LocalizationOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<PasswordResource> PasswordLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<LoginResource> LoginLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<StoreResource> StoreLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<StockResource> StockLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<ProductResource> ProductLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<UserResource> UserLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<CategoryResource> CategoryLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer<BrandResource> BrandLocalizer { get; private set; }
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
