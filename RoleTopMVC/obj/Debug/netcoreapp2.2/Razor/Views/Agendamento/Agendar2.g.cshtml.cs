#pragma checksum "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f1809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agendamento_Agendar2), @"mvc.1.0.view", @"/Views/Agendamento/Agendar2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agendamento/Agendar2.cshtml", typeof(AspNetCore.Views_Agendamento_Agendar2))]
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
#line 1 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba6da8ae34a60df89c43d8e7cbc84ec0ce5f1809", @"/Views/Agendamento/Agendar2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Agendamento_Agendar2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.AgendamentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Finfo-you"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agendamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agendar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("information"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cancel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 174, true);
            WriteLiteral("\r\n<main>\r\n\r\n    <section id=\"titles\">\r\n\r\n            <h1><em><strong> Insira As Informações Do Evento </strong></em></h1>\r\n\r\n            <div class=\"h2s\">\r\n\r\n                ");
            EndContext();
            BeginContext(225, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f18096295", async() => {
                BeginContext(309, 127, true);
                WriteLiteral("\r\n\r\n                <button type=\"submit\" id=\"Binfo-you\"><h2>Suas Informações</h2></button>\r\n                \r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(443, 1978, true);
            WriteLiteral(@"

                <button><h2>Informações Do Evento</h2></button>
                <button><h2>Pagamento</h2></button>

            </div>

    </section>

    <section id=""important"">
            <h1>Informações Importantes!</h1>
    
            <p>Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Enim lobortis scelerisque fermentum dui faucibus.
            Faucibus purus in massa tempor nec feugiat. Sed viverra tellus in hac habitasse platea dictumst vestibulum.
            Risus pretium quam vulputate dignissim suspendisse in est ante in. Pretium aenean pharetra magna ac placerat vestibulum lectus mauris.
            Varius morbi enim nunc faucibus a. Nisl nisi scelerisque eu ultrices.
            Non curabitur gravida arcu ac tortor. Id ornare arcu odio ut sem nulla.
            Nec ultrices dui sapien eget mi proin sed libero enim. Tempor orci eu lobortis elementum nibh tellus
            molestie nunc non. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tinci");
            WriteLiteral(@"dunt ornare.
            In hendrerit gravida rutrum quisque non tellus orci ac. Aliquam faucibus purus in massa tempor.
            Morbi non arcu risus quis varius quam. Vel fringilla est ullamcorper eget nulla facilisi etiam.
            Suspendisse interdum consectetur libero id faucibus. Eu augue ut lectus arcu bibendum at varius vel pharetra.
            Diam vel quam elementum pulvinar etiam non. Faucibus in ornare quam viverra orci sagittis eu volutpat.
            Eu sem integer vitae justo eget magna. Eu feugiat pretium nibh ipsum consequat nisl vel pretium.
            Urna molestie at elementum eu facilisis sed odio morbi. Sed risus ultricies tristique nulla.
            Ornare lectus sit amet est. Dolor sit amet consectetur adipiscing elit duis tristique sollicitudin.
            Porttitor leo a diam sollicitudin. Pulvinar mattis nunc sed blandit libero.</p>

    </section>

    <section id=""abraco"">

            ");
            EndContext();
            BeginContext(2421, 4436, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180910581", async() => {
                BeginContext(2521, 622, true);
                WriteLiteral(@" <!-- Mudar o Action para o que faz o registro do agendamento em si -->

                <fieldset id=""name-section"">

                    <label for=""name-text"">Nome Do Evento:</label>
                    <input type=""text"" name=""nName"" id=""name-text"" maxlength=""100"" required>
                
                </fieldset>

                <div id=""alinha-select"">

                    <fieldset id=""type-section"">
    
                            <label for=""type-select"">Tipo De Evento:</label>
                            <select name=""nType"" id=""type-select"" required> 
                                ");
                EndContext();
                BeginContext(3143, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180911608", async() => {
                    BeginContext(3151, 6, true);
                    WriteLiteral("Balada");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3166, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3200, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180912897", async() => {
                    BeginContext(3208, 9, true);
                    WriteLiteral("Casamento");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3226, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3260, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180914189", async() => {
                    BeginContext(3268, 5, true);
                    WriteLiteral("Festa");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3282, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3316, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180915477", async() => {
                    BeginContext(3324, 4, true);
                    WriteLiteral("Show");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3337, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3371, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180916764", async() => {
                    BeginContext(3379, 9, true);
                    WriteLiteral("Convenção");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3397, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3431, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180918056", async() => {
                    BeginContext(3439, 8, true);
                    WriteLiteral("Palestra");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3456, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3490, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180919347", async() => {
                    BeginContext(3498, 20, true);
                    WriteLiteral("Outros (Especificar)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3527, 328, true);
                WriteLiteral(@"
                            </select>

                    </fieldset>
        
                    <fieldset id=""status-section"">
    
                        <label for=""status-select"">Status Do Evento:</label>
                        <select name=""nStatus"" id=""status-select"" required> 
                            ");
                EndContext();
                BeginContext(3855, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180920953", async() => {
                    BeginContext(3863, 14, true);
                    WriteLiteral("Evento Privado");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3886, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3916, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180922247", async() => {
                    BeginContext(3924, 14, true);
                    WriteLiteral("Evento Público");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3947, 308, true);
                WriteLiteral(@"
                        </select>

                    </fieldset>  

                    <fieldset id=""plan-section"">

                            <label for=""plan-select"">Planos:</label>
                            <select name=""nPlan"" id=""plan-select"" required> 
                                ");
                EndContext();
                BeginContext(4255, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180923827", async() => {
                    BeginContext(4290, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4308, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 88 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
                                 foreach (var plano in Model.Planos)
                                {

#line default
#line hidden
                BeginContext(4415, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(4451, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180926331", async() => {
                    BeginContext(4480, 10, false);
#line 90 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
                                                           Write(plano.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(4490, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(4496, 11, false);
#line 90 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
                                                                           Write(plano.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(4507, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 90 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
                                       WriteLiteral(plano.Nome);

#line default
#line hidden
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
                EndContext();
                BeginContext(4517, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 91 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
                                }

#line default
#line hidden
                BeginContext(4554, 2296, true);
                WriteLiteral(@"                                <!-- <option>Plano De Iluminação</option>
                                <option>Plano De Som</option>
                                <option>Plano De Iluminação E De Som</option> -->
                            </select>

                    </fieldset>

                </div>

                </fieldset>
    
                <fieldset id=""number-section"">

                        <label for=""number"">Número De Pessoas No Evento (Aproximadamente):</label>
                        <input type=""number"" name=""nNumber"" id=""number"" min=""5"" max=""250"" step=""5"" placeholder=""Mín. 5, Máx. 250"" required>
                    
                </fieldset>

                <fieldset id=""date-section"">

                        <label for=""date"">Data Do Evento:</label>
                        <input type=""date"" name=""nDate"" id=""date"" min=""2019-12-01"" max=""2022-12-31"" required>
                    
                </fieldset>

                <fieldset id=""timeS-section");
                WriteLiteral(@""">

                        <label for=""time-start"">Horário De Inicialização:</label>
                        <input type=""time"" name=""nTimeS"" id=""time-start"" required>
                
                </fieldset>

                <fieldset id=""timeE-section"">

                        <label for=""time-end"">Horário De Termino:</label>
                        <input type=""time"" name=""nTimeE"" id=""time-end"" required>
                
                </fieldset>

                <fieldset id=""mesage"">

                        <label for=""mesage-camp"">Descreva o Evento:</label>
                        <textarea name=""nMesage"" id=""mesage-camp"" cols=""35"" rows=""10"" required></textarea>
                    
                </fieldset>

                <fieldset id=""check-section"">

                        <Label for=""check"">Li E Concordo Com Os <a href=""termos.html"">Termos De Contrato</a></Label>
                        <input type=""checkbox"" name=""nCheck"" id=""check"" required>
                ");
                WriteLiteral("\n                </fieldset>\r\n\r\n\r\n<div id=\"alinha\">\r\n\r\n                <div id=\"button\">\r\n\r\n                    <button type=\"submit\">Confirmar</button>\r\n                    \r\n                </div>\r\n                \r\n                \r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 47 "C:\Users\50090694821\Documents\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
AddHtmlAttributeValue("", 2455, Url.Action("AgendamentoProcesso2", "Agendamento"), 2455, 50, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6857, 28, true);
            WriteLiteral("\r\n            \r\n            ");
            EndContext();
            BeginContext(6885, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6da8ae34a60df89c43d8e7cbc84ec0ce5f180933606", async() => {
                BeginContext(6916, 93, true);
                WriteLiteral("\r\n\r\n                    <button type=\"submit\">Voltar</button>\r\n                \r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7016, 39, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n    </section>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.AgendamentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
