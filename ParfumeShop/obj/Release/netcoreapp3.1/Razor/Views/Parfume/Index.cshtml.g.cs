#pragma checksum "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72f19138e631f34188a56b245fb00afd939a1fa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parfume_Index), @"mvc.1.0.view", @"/Views/Parfume/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\_ViewImports.cshtml"
using ParfumeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\_ViewImports.cshtml"
using ParfumeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72f19138e631f34188a56b245fb00afd939a1fa5", @"/Views/Parfume/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9784792bcb8635f9ba89e8652d821eecb41b19b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Parfume_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ParfumeShop.Models.Parfume>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Parfume", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h2 class=\"text-center\">Parfume List</h2>\r\n\r\n    <div class=\"mb-2 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72f19138e631f34188a56b245fb00afd939a1fa55189", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> Create New Parfume");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex flex-wrap bg-light p-2 justify-content-between\">\r\n");
#nullable restore
#line 12 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
             foreach (Parfume parfume in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex flex-column p-3 align-items-center gap-3 parfume-item\">\r\n                    <h2>");
#nullable restore
#line 15 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume?.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h2>");
#nullable restore
#line 16 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h4>");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 18 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                  Write(parfume?.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h3>");
#nullable restore
#line 19 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> UAH</span></h3>\r\n");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                     if (parfume.Image == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/2048px-No_image_available.svg.png\"/>\r\n");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\'", 1131, "\'", 1195, 1);
#nullable restore
#line 26 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
WriteAttributeValue("", 1137, Url.Action("ShowImage", "Parfume", new {id = parfume.Id}), 1137, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"btn-group\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72f19138e631f34188a56b245fb00afd939a1fa510112", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i> Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                                                                          WriteLiteral(parfume.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72f19138e631f34188a56b245fb00afd939a1fa512644", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i> Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                                                                          WriteLiteral(parfume.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>List is empty!</p>\r\n");
#nullable restore
#line 40 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead class=""thead-light"">
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Company</th>
                <th scope=""col"">Category</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Image</th>
                <th></th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 56 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
             foreach (Parfume parfume in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume?.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume?.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                   Write(parfume.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 65 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                         if (parfume.Image == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img width=\"100\" height=\"100\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/2048px-No_image_available.svg.png\"/>\r\n");
#nullable restore
#line 68 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img width=\"100\" height=\"100\"");
            BeginWriteAttribute("src", " src=\'", 2985, "\'", 3049, 1);
#nullable restore
#line 71 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
WriteAttributeValue("", 2991, Url.Action("ShowImage", "Parfume", new {id = parfume.Id}), 2991, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 72 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        <div class=\"btn-group\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72f19138e631f34188a56b245fb00afd939a1fa519760", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i> Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                                                                              WriteLiteral(parfume.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72f19138e631f34188a56b245fb00afd939a1fa522300", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i> Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
                                                                              WriteLiteral(parfume.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 85 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>List is empty!</p>\r\n");
#nullable restore
#line 89 "C:\Users\Admin\source\repos\ParfumeShop\ParfumeShop\Views\Parfume\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ParfumeShop.Models.Parfume>> Html { get; private set; }
    }
}
#pragma warning restore 1591