#pragma checksum "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f731bde9dc09297618d9b439e38bd6fbdea6852b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DurkayaRecipe_List), @"mvc.1.0.view", @"/Views/DurkayaRecipe/List.cshtml")]
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
#line 2 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f731bde9dc09297618d9b439e38bd6fbdea6852b", @"/Views/DurkayaRecipe/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300580db1758ae7e9f6fb51a9b13239d36e786af", @"/Views/_ViewImports.cshtml")]
    public class Views_DurkayaRecipe_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NoFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 5 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
             if (Model.Foods.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f731bde9dc09297618d9b439e38bd6fbdea6852b5316", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                 foreach (var food in Model.Foods)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f731bde9dc09297618d9b439e38bd6fbdea6852b7042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = food;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 20 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav>\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 27 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                             if (string.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 986, "\"", 1054, 2);
            WriteAttributeValue("", 994, "page-item", 994, 9, true);
#nullable restore
#line 31 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
WriteAttributeValue(" ", 1003, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 1004, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1096, "\"", 1121, 2);
            WriteAttributeValue("", 1103, "/foods?page=", 1103, 12, true);
#nullable restore
#line 32 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
WriteAttributeValue("", 1115, i+1, 1115, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 32 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                                                                               Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 34 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1323, "\"", 1391, 2);
            WriteAttributeValue("", 1331, "page-item", 1331, 9, true);
#nullable restore
#line 37 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
WriteAttributeValue(" ", 1340, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 1341, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1433, "\"", 1490, 4);
            WriteAttributeValue("", 1440, "/foods/", 1440, 7, true);
#nullable restore
#line 38 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
WriteAttributeValue("", 1447, Model.PageInfo.CurrentCategory, 1447, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1478, "?page=", 1478, 6, true);
#nullable restore
#line 38 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
WriteAttributeValue("", 1484, i+1, 1484, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 38 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                                                                                                               Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 40 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\PATRON\Desktop\DurkayaRecipe\DurkayaRecipe\DurkayaRecipe.WebUI\Views\DurkayaRecipe\List.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
