#pragma checksum "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b3f6f68842c27c96fb17fd4bf1560acc2e55920"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoWebApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using ToDoWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using ToDoWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "<a class=\"navbar-brand\" href=\"/\" style=\"margin:auto\"><img src=\"images/DailyWhite.svg\" style=\"width:100px\"></a>\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<span class=\"navbar-toggler-icon\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(8);
            __builder.AddAttribute(9, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", 
#nullable restore
#line 11 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(13, "ul");
                __builder2.AddAttribute(14, "class", "nav flex-column");
                __builder2.OpenElement(15, "li");
                __builder2.AddAttribute(16, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
                __builder2.AddAttribute(18, "class", "nav-link");
                __builder2.AddAttribute(19, "href", "");
                __builder2.AddAttribute(20, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "li");
                __builder2.AddAttribute(25, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
                __builder2.AddAttribute(27, "class", "nav-link");
                __builder2.AddAttribute(28, "href", "todo");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "<span class=\"oi oi-task\" aria-hidden=\"true\"></span> To Do\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "li");
                __builder2.AddAttribute(33, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "overall");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Overall\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenElement(40, "li");
                __builder2.AddAttribute(41, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
                __builder2.AddAttribute(43, "class", "nav-link");
                __builder2.AddAttribute(44, "href", "Identity/Account/LogOut");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(46, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\"></span> LogOut\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(47, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", 
#nullable restore
#line 41 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(51, "ul");
                __builder2.AddAttribute(52, "class", "nav flex-column");
                __builder2.OpenElement(53, "li");
                __builder2.AddAttribute(54, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
                __builder2.AddAttribute(56, "class", "nav-link");
                __builder2.AddAttribute(57, "href", "Identity/Account/Login");
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "<span class=\"oi oi-account-login\" aria-hidden=\"true\"></span> Login\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
