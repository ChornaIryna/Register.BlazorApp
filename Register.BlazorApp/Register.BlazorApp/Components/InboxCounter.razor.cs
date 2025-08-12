using Microsoft.AspNetCore.Components;
using Register.BlazorApp.State;

namespace Register.BlazorApp.Components;
public partial class InboxCounter
{
    [Inject]
    public ApplicationState ApplicationState { get; set; }

    private int NotificationCount;

    protected override void OnInitialized()
    {
        NotificationCount = new Random().Next(5);
        ApplicationState.NumberOfNotifications = NotificationCount;
    }
}