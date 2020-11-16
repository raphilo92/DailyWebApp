#pragma checksum "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f59faa04ecd3bc0a6eeec41326b789e02bcc4ff"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoWebApp.Pages
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
#line 12 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
using ToDoWebApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
using ToDoWebApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/overall")]
    public partial class OverallPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "id", "form-content");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
                              _toDoDict

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(7, "table");
                    __builder3.AddAttribute(8, "class", "table table-hover");
                    __builder3.AddMarkupContent(9, @"<thead><tr><th><i id=""blue-icon"" class=""oi oi-calendar""></i></th>
                            <th><i id=""blue-icon"" class=""oi oi-check""></i></th>
                            <th><i id=""blue-icon"" class=""oi oi-x""></i></th>
                            <th><i id=""blue-icon"" class=""oi oi-magnifying-glass""></i></th></tr></thead>
                    ");
                    __builder3.OpenElement(10, "tbody");
#nullable restore
#line 28 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
                         foreach (var dateAndItems in _toDoDict)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(11, "tr");
                    __builder3.OpenElement(12, "td");
                    __builder3.AddContent(13, 
#nullable restore
#line 33 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
                                     dateAndItems.Key

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(14, "\r\n                                ");
                    __builder3.OpenElement(15, "td");
                    __builder3.AddContent(16, 
#nullable restore
#line 36 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
                                     dateAndItems.Value.DoneList.Count

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\r\n                                ");
                    __builder3.OpenElement(18, "td");
                    __builder3.AddContent(19, 
#nullable restore
#line 39 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
                                     dateAndItems.Value.NotDoneList.Count

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n                                ");
                    __builder3.OpenElement(21, "td");
                    __builder3.OpenElement(22, "button");
                    __builder3.AddAttribute(23, "class", "btn btn-outline-primary");
                    __builder3.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
                                                                                      (()=>DetailClick(dateAndItems.Value))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(25, "Detail");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 46 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(26, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\OverallPage.razor"
       
    //Modal
    [CascadingParameter] public IModalService Modal { get; set; }

    //DataContainer
    public IDictionary<string, Date> _toDoDict = new Dictionary<string, Date>();
    

    // load data upon initialization
    protected override async Task OnInitializedAsync()
    {
        _toDoDict = await ToDoData.GetItemsByDate();
    }

    private async Task DetailClick(Date date)
    {
        date.DetailClicked = date.DetailClicked == true ? false : true;

        var modalParam = new ModalParameters();

        modalParam.Add(nameof(OverallModalPage.ToDoDate), date);


        var modal = Modal.Show<OverallModalPage>($"{date.DateCreated}", modalParam);
        var result = await modal.Result;
        var dataResult = result.Data;

        if(!result.Cancelled)
        {
            await ToDoData.UpdateAll((Date)dataResult);

            _toDoDict = await ToDoData.GetItemsByDate();
        }

    }


    private async Task DoneCheck(ToDoItem item)
    {
        item.Done = item.Done == Done.NotDone ? Done.Done : Done.NotDone;

        if (item.Done == Done.Done)
        {
            await ToDoData.UpdateToDoneStatus(item);
        }
        else
        {
            await ToDoData.UpdateToUnDoneStatus(item);
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToDoData ToDoData { get; set; }
    }
}
#pragma warning restore 1591
