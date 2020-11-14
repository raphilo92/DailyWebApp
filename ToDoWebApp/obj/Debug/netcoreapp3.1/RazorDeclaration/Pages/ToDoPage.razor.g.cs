// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using ToDoWebApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using ToDoWebApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
       
    public IList<ToDoItem> _toDoList = new List<ToDoItem>();
    private string _newItemTitle { get; set; }


    // Page Model Methods
    protected async override Task OnInitializedAsync()
    {
        _toDoList = await ToDoItemData.GetTodayToDoItem();
    }

    private async Task AddToDo()
    {
        if(!String.IsNullOrEmpty(_newItemTitle))
        {
            var newToDoItem = new ToDoItem(_newItemTitle, DateTime.Now);

            await ToDoItemData.InsertItem(newToDoItem);

            _newItemTitle = string.Empty;
        }
        _toDoList = await ToDoItemData.GetTodayToDoItem();
    }

    private async Task DeleteToDo(ToDoItem item)
    {
        await ToDoItemData.DeleteItem(item);

        _toDoList = await ToDoItemData.GetTodayToDoItem();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToDoData ToDoItemData { get; set; }
    }
}
#pragma warning restore 1591
