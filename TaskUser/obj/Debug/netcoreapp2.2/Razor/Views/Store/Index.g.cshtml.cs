#pragma checksum "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Index.cshtml", typeof(AspNetCore.Views_Store_Index))]
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
#line 1 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/_ViewImports.cshtml"
using TaskUser;

#line default
#line hidden
#line 2 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/_ViewImports.cshtml"
using TaskUser.Models;

#line default
#line hidden
#line 3 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
using TaskUser.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05140d8a3cd8ea56fbd43bb26746c82ddeeca45a", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca2d75e0b56f6cfabef55e279e994f4abb57c3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<TaskUser.ViewsModels.StoreViewsModels.StoreViewModels>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/indexcs.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/addStore.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Smiley face"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/deleteStore.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(121, 2, true);
            WriteLiteral(" \n");
            EndContext();
            BeginContext(161, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a8358", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(211, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 8 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(271, 175, true);
            WriteLiteral("\n\n  \n\n\n<div class=\"container-fuld\">\n    <div class=\"alert\" style=\"padding-right: 300px\">\n        <h1 class=\"usermanege\" style=\"padding-top: 100px\" align=\"center\">\n            ");
            EndContext();
            BeginContext(447, 50, false);
#line 20 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
       Write(Localizer.GetLocalizedString("h1_storemanagement"));

#line default
#line hidden
            EndContext();
            BeginContext(497, 24, true);
            WriteLiteral("\n        </h1>\n        \n");
            EndContext();
#line 23 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
         if (TempData["create"] != null)
        {

#line default
#line hidden
            BeginContext(572, 72, true);
            WriteLiteral("            <h4  class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\" >");
            EndContext();
            BeginContext(645, 30, false);
#line 25 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
                                                                   Write(Localizer["Add Store Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(675, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 26 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
        
        
        }

#line default
#line hidden
            BeginContext(709, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 29 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
         if (TempData["edit"] != null)
        {

#line default
#line hidden
            BeginContext(758, 72, true);
            WriteLiteral("            <h4  class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\" >");
            EndContext();
            BeginContext(831, 31, false);
#line 31 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
                                                                   Write(Localizer["Edit Store Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(862, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 32 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
        
        
        }

#line default
#line hidden
            BeginContext(896, 225, true);
            WriteLiteral("        \n    </div>\n\n    <table class=\"table table-bordered table-sm\">\n        <thead align=\"center\">\n\n        <tr class=\"table-primary\">\n            <th>\n                ID\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1122, 44, false);
#line 46 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("th_storename"));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 69, true);
            WriteLiteral("\n               \n\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1236, 40, false);
#line 51 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("th_email"));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 66, true);
            WriteLiteral("\n            \n            </th>\n\n            <th>\n                ");
            EndContext();
            BeginContext(1343, 40, false);
#line 56 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("th_phone"));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 68, true);
            WriteLiteral("\n               \n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1452, 41, false);
#line 60 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("h1_street"));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 67, true);
            WriteLiteral("\n              \n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1561, 39, false);
#line 64 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("th_city"));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 55, true);
            WriteLiteral("\n               </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1656, 40, false);
#line 67 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("th_state"));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 68, true);
            WriteLiteral("\n               \n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1765, 42, false);
#line 71 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("th_zipcode"));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 68, true);
            WriteLiteral("\n               \n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1876, 43, false);
#line 75 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
           Write(Localizer.GetLocalizedString("th_actision"));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 91, true);
            WriteLiteral("\n            \n                </th>\n        </tr>\n        </thead>\n        <tbody>\n        ");
            EndContext();
            BeginContext(2010, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a16292", async() => {
                BeginContext(2089, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(2102, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a16679", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2173, 9, true);
                WriteLiteral("\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2186, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
#line 86 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2236, 73, true);
            WriteLiteral("            <tr align=\"center\">\n                <td>\n                    ");
            EndContext();
            BeginContext(2310, 37, false);
#line 90 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2347, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2412, 44, false);
#line 93 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(2456, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2521, 40, false);
#line 96 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 23, true);
            WriteLiteral("\n                </td>\n");
            EndContext();
            BeginContext(2710, 41, true);
            WriteLiteral("                <td>\n                    ");
            EndContext();
            BeginContext(2752, 40, false);
#line 102 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2792, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2857, 41, false);
#line 105 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
            EndContext();
            BeginContext(2898, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2963, 39, false);
#line 108 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(3002, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3067, 40, false);
#line 111 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(3107, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3172, 42, false);
#line 114 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(3214, 65, true);
            WriteLiteral("\n                </td>\n                <td>\n\n                    ");
            EndContext();
            BeginContext(3279, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a23451", async() => {
                BeginContext(3380, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(3405, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a23850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3472, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3497, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(3520, 319, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a27740", async() => {
                BeginContext(3715, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(3740, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "05140d8a3cd8ea56fbd43bb26746c82ddeeca45a28139", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3814, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3565, "return", 3565, 6, true);
            AddHtmlAttributeValue(" ", 3571, "confirm(\'", 3572, 10, true);
#line 121 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
AddHtmlAttributeValue("", 3581, Localizer.GetLocalizedString("a_areyousureyouwanttodeleteit?"), 3581, 63, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3644, "\')", 3644, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 121 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
                                                                                                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3839, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 131 "/home/local/3SI/loc.tv/Downloads/TaskUser-20190424T111900Z-001/TaskUser/Views/Store/Index.cshtml"
                         
        }

#line default
#line hidden
            BeginContext(4211, 39, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SharedViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<TaskUser.ViewsModels.StoreViewsModels.StoreViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
