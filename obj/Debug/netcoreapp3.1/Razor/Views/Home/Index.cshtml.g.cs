#pragma checksum "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "170c36c3c73cdbb757951a8b54ea57cc35ea59f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\_ViewImports.cshtml"
using padlab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"
using padlab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"170c36c3c73cdbb757951a8b54ea57cc35ea59f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0bf6ea585c9926f12886a87fb3b99a072c99987", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<a href=\"/Home/CreatePost\" class=\"text-right\">\r\n\t\t<h5>Create Your Post</h5>\r\n\t</a>\r\n\r\n");
#nullable restore
#line 13 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"
     if (Model.Any())
	{
		foreach (var post in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"post-container\">\r\n\t\t\t\t<div><b>");
#nullable restore
#line 18 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"
                   Write(post.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> posted: </div>\r\n\t\t\t\t<div class=\"post-content\">");
#nullable restore
#line 19 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"
                                     Write(Html.Raw(post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t<div class=\"text-right\">");
#nullable restore
#line 20 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"
                                   Write(post.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 22 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"

		}
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<h5> No Posts last 24 hours </h5>\r\n");
#nullable restore
#line 28 "E:\UTM\UTM_AN_4\PAD\Laboratoare\lab3\padlab\padlab\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
