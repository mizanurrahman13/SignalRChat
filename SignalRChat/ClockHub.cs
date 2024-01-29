using Microsoft.AspNetCore.SignalR;

public class ClockHub : Hub
{
    public async Task PrintTime()
    {
        await Clients.All.SendAsync("DisplayTime", DateTime.Now.ToString());
    }
}
