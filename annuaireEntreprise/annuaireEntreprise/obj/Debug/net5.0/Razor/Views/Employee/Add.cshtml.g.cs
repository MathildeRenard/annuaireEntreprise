#pragma checksum "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56575be4c3a3860ffad214937b0478e5e20e56bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Add), @"mvc.1.0.view", @"/Views/Employee/Add.cshtml")]
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
#line 1 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\_ViewImports.cshtml"
using annuaireEntreprise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\_ViewImports.cshtml"
using annuaireEntreprise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56575be4c3a3860ffad214937b0478e5e20e56bc", @"/Views/Employee/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19bd23141648a25998607059ad1739d078af8aad", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<annuaireEntreprise.ViewModels.ViewModelEmployee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "sendnew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <h1 class=\"text-center\">Modifier employé</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56575be4c3a3860ffad214937b0478e5e20e56bc5222", async() => {
                WriteLiteral(@"
        <fieldset>
            <div id=""formulaire"" class=""text-center d-flex flex-column m-auto"">

                <div class=""form-group d-inline-flex"">
                    <label class=""mr-4 w-25"">Prénom</label>
                    <input type=""text"" class=""form-control w-25"" name=""firstname"">
                </div>
                <div class=""form-group d-inline-flex"">
                    <label class=""mr-4 w-25"">Nom</label>
                    <input type=""text"" class=""form-control w-25"" name=""lastname"">
                </div>
                <div class=""form-group d-inline-flex"">
                    <label class=""mr-4 w-25"">Adresse e-mail</label>
                    <input type=""text"" class=""form-control w-25"" name=""mail"">
                </div>
                <div class=""form-group d-inline-flex"">
                    <label class=""mr-4 w-25"">Numéro de télephone fixe</label>
                    <input type=""text"" class=""form-control w-25"" name=""phone"">
                </div>
      ");
                WriteLiteral(@"          <div class=""form-group d-inline-flex"">
                    <label class=""mr-4 w-25"">Numéro de télephone portable</label>
                    <input type=""text"" class=""form-control w-25"" name=""mobilePhone"">
                </div>

                <div class=""form-group d-inline-flex"">
                    <label class=""mr-4 w-25"">Service</label>
                    <select class=""form-control"" onchange=""ChangeValue('service',this.value);"">

");
#nullable restore
#line 33 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
                         foreach (Service s in Model.listeServices)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56575be4c3a3860ffad214937b0478e5e20e56bc7428", async() => {
#nullable restore
#line 36 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
                                                    Write(s.NameService);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
                               WriteLiteral(s.IdService);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group d-inline-flex"">
                    <label class=""mr-4 w-25"">Site</label>
                    <select class=""form-control"" onchange=""ChangeValue('site',this.value);"">


");
#nullable restore
#line 46 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
                         foreach (Site s in Model.listeSites)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56575be4c3a3860ffad214937b0478e5e20e56bc10309", async() => {
#nullable restore
#line 49 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
                                                 Write(s.NameSite);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
                               WriteLiteral(s.IdSite);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        }\r\n\r\n                    </select>\r\n                </div>\r\n                <input type=\"hidden\" class=\"form-control w-25\" name=\"idEmployee\"");
                BeginWriteAttribute("value", " value=\"", 2553, "\"", 2584, 1);
#nullable restore
#line 55 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
WriteAttributeValue("", 2561, ViewData["idEmployee"], 2561, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\" class=\"form-control w-25\" name=\"idservice\" id=\"idservice\"");
                BeginWriteAttribute("value", " value=\"", 2682, "\"", 2723, 1);
#nullable restore
#line 56 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
WriteAttributeValue("", 2690, Model.listeServices[0].IdService, 2690, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\" class=\"form-control w-25\" name=\"idsite\" id=\"idsite\"");
                BeginWriteAttribute("value", " value=\"", 2815, "\"", 2850, 1);
#nullable restore
#line 57 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
WriteAttributeValue("", 2823, Model.listeSites[0].IdSite, 2823, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n");
#nullable restore
#line 59 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
             if (@ViewData["message"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"alert alert-danger\" role=\"alert\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
               Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 64 "C:\Users\renar\Documents\ProjetIndividuel\annuaireEntreprise\annuaireEntreprise\annuaireEntreprise\Views\Employee\Add.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div id=\"Button\" class=\"text-center\"><button type=\"submit\" class=\"btn btn-outline-secondary ml-4 mr-4\">Ajouter</button></div>\r\n\r\n        </fieldset>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<annuaireEntreprise.ViewModels.ViewModelEmployee> Html { get; private set; }
    }
}
#pragma warning restore 1591
