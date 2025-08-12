using Microsoft.AspNetCore.Components;

namespace Register.BlazorApp.Components;
public partial class MainPicture
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}