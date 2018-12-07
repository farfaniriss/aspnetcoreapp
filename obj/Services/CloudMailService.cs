using System.Diagnostics;
using aspnetapp;

public class CloudMailService : IMailService
{
    public string _mailTo = Startup.Configuration["mailSettings:mailToAddress"];
    public string _mailFrom = Startup.Configuration["mailSettings:mailFromAddress"];
    public void Send(string subject, string message)
    {
        Debug.WriteLine($"Mail from { _mailFrom } to { _mailTo }, with CloudMailService.");
        Debug.WriteLine($"Subject: { subject }");
        Debug.WriteLine($"Message: { message }");
    }
}