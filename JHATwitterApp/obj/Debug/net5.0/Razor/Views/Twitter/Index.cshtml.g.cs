#pragma checksum "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\Twitter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "605b08c9dd1ef28724968ffd3ba14f5efaa24001"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Twitter_Index), @"mvc.1.0.view", @"/Views/Twitter/Index.cshtml")]
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
#line 1 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\_ViewImports.cshtml"
using JHATwitterApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\_ViewImports.cshtml"
using JHATwitterApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605b08c9dd1ef28724968ffd3ba14f5efaa24001", @"/Views/Twitter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4a025273a9befb900f7006120aa56a678e77e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Twitter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\Twitter\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Twitter API</h1>\r\n\r\n<p>Tweet Count : ");
#nullable restore
#line 9 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\Twitter\Index.cshtml"
            Write(ViewData["TweetCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Percentage of Tweets that contain a URL  : ");
#nullable restore
#line 10 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\Twitter\Index.cshtml"
                                         Write(ViewData["UrlPercent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n<p>Percentage of Tweets that contain a Photo URL  : ");
#nullable restore
#line 11 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\Twitter\Index.cshtml"
                                               Write(ViewData["PicUrlPercent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n<p>Emoji Count  : ");
#nullable restore
#line 12 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\Twitter\Index.cshtml"
             Write(ViewData["EmojiCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<p>Hashtag Count : ");
#nullable restore
#line 13 "C:\Users\sajid\OneDrive\Documents\Saji\Projects\.NetCore\JHATwitterApp\JHATwitterApp\Views\Twitter\Index.cshtml"
              Write(ViewData["HashCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
