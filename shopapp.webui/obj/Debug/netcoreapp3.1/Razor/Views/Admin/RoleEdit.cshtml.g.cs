#pragma checksum "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96d07533a14ddd4c8836a3fc253891f2a440dd47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
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
#line 1 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d07533a14ddd4c8836a3fc253891f2a440dd47", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb114ed89227543e85f361077d62aad35c126f92", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1 class=\"h3\">Edit Role</h1>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96d07533a14ddd4c8836a3fc253891f2a440dd474809", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 208, "\"", 230, 1);
#nullable restore
#line 7 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 216, Model.Role.Id, 216, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 278, "\"", 302, 1);
#nullable restore
#line 8 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 286, Model.Role.Name, 286, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <h6 class=\"bg-info text-white p-1\">Add to ");
#nullable restore
#line 9 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                                             Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n        <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 11 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
             if(Model.NonMembers.Count() ==0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td colspan=\"2\">Bütün kullanıcılar role ait</td>\r\n                </tr>\r\n");
#nullable restore
#line 16 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
            }
            else {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 foreach(var user in Model.NonMembers){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                       Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td style=\"width:150px\">\r\n                            <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 894, "\"", 910, 1);
#nullable restore
#line 22 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 902, user.Id, 902, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 25 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n        <hr>\r\n\r\n        <h6 class=\"bg-info text-white p-1\">Remove from ");
#nullable restore
#line 31 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                                                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n        <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 33 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
             if(@Model.Members.Count() ==0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td colspan=\"2\">Role ait kullanıcı yok</td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
            }
            else {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 foreach(var user in @Model.Members){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                       Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td style=\"width:150px\">\r\n                            <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 1629, "\"", 1645, 1);
#nullable restore
#line 44 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1637, user.Id, 1637, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\musta\Documents\UdemyWebProgramlama\shopapp\shopapp.webui\Views\Admin\RoleEdit.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n         <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
