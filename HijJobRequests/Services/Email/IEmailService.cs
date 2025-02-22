using System;

namespace HijJobRequests.Services.Email;

public interface IEmailService
{
        Task SendEmailAsync(string to, string subject, string body, bool isHtml = true);
}
