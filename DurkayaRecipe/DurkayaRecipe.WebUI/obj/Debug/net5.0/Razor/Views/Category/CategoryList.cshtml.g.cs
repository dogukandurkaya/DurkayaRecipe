#pragma checksum "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d543aff1f0a8b20147054bbc3f5ffe5ea289de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryList), @"mvc.1.0.view", @"/Views/Category/CategoryList.cshtml")]
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
#line 1 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d543aff1f0a8b20147054bbc3f5ffe5ea289de", @"/Views/Category/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13187107c5e847ee11a72442c794dd3553fa9ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/CategoryDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h6 class=""display-4 text-light"">Admin Category Managament</h6>
        <hr />
        <a href=""/category/create"" class=""btn btn-sm btn-light mb-1"">Create Category</a>

        <table class=""table table-bordered bg-light"">
            <thead>
                <tr>
                    <th witdh=""30"">ID</th>
                    <th>Name</th>
                    <th witdh=""30"">Actions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
                 if (Model.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
                     foreach (var category in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
                           Write(category.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
                           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 899, "\"", 936, 2);
            WriteAttributeValue("", 906, "/category/", 906, 10, true);
#nullable restore
#line 26 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 916, category.CategoryId, 916, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary mr-1\">Edit</a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d543aff1f0a8b20147054bbc3f5ffe5ea289de7358", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 1154, "\"", 1182, 1);
#nullable restore
#line 28 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 1162, category.CategoryId, 1162, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Category\CategoryList.cshtml"
                     
                }
                else
                {
                    //ürün yoksa
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
