#pragma checksum "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98bf933929e564eb003adb085699f93eaabc6572"
// <auto-generated/>
#pragma warning disable 1591
namespace MyFirstBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\phil.read\repos\blazor\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n");
            __builder.OpenComponent<MyFirstBlazorApp.Components.MyFirstComponent>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<MyFirstBlazorApp.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
