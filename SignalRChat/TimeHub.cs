using Microsoft.AspNetCore.SignalR;

public class TimeHub : Hub
{
    public async Task GetTime()
    {
        string currentTime = DateTime.Now.ToString("HH:mm:ss");
        await Clients.All.SendAsync("ReceiveTime", currentTime);
    }

    public async Task GetIndex()
    {
        int index = (int)(DateTime.Now - DateTime.Today).TotalSeconds;
        await Clients.All.SendAsync("ReceiveIndex", index);
    }
}
