#pragma checksum "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4bbcbe018de265adb0556f3eae5c76666cd5882"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGoogleAuth.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\_Imports.razor"
using BlazorGoogleAuth;

#line default
#line hidden
#line 7 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\_Imports.razor"
using BlazorGoogleAuth.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BlazorGoogleAuth</a>\r\n    ");
            builder.OpenElement(4, "button");
            builder.AddAttribute(5, "class", "navbar-toggler");
            builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 3 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\Shared\NavMenu.razor"
                                              ToggleNavMenu

#line default
#line hidden
            ));
            builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(9, "\r\n\r\n");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", 
#line 8 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
            );
            builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 8 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\Shared\NavMenu.razor"
                                         ToggleNavMenu

#line default
#line hidden
            ));
            builder.AddMarkupContent(13, "\r\n    ");
            builder.OpenElement(14, "ul");
            builder.AddAttribute(15, "class", "nav flex-column");
            builder.AddMarkupContent(16, "\r\n        ");
            builder.OpenElement(17, "li");
            builder.AddAttribute(18, "class", "nav-item px-3");
            builder.AddMarkupContent(19, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            builder.AddAttribute(21, "class", "nav-link");
            builder.AddAttribute(22, "href", "");
            builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 11 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
            ));
            builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(26, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(27, "\r\n        ");
            builder.OpenElement(28, "li");
            builder.AddAttribute(29, "class", "nav-item px-3");
            builder.AddMarkupContent(30, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            builder.AddAttribute(32, "class", "nav-link");
            builder.AddAttribute(33, "href", "counter");
            builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(35, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(36, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(37, "\r\n        ");
            builder.OpenElement(38, "li");
            builder.AddAttribute(39, "class", "nav-item px-3");
            builder.AddMarkupContent(40, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            builder.AddAttribute(42, "class", "nav-link");
            builder.AddAttribute(43, "href", "fetchdata");
            builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(45, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(46, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(47, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(48, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 28 "C:\Users\asharma2\source\repos\BlazorGoogleAuth\BlazorGoogleAuth\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
