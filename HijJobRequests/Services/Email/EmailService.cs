using System;
using MimeKit;
using MailKit.Net.Smtp;

namespace HijJobRequests.Services.Email;

public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string to, string subject, string body, bool isHtml = true)
        {
            // Create the email message
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(
                _configuration["EmailSettings:SenderName"], 
                _configuration["EmailSettings:SenderEmail"]
            ));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;

            // Set email body
            email.Body = new TextPart(isHtml ? "html" : "plain")
            {
                Text = body
            };

            // Send the email
            using var smtpClient = new SmtpClient();
            try
            {
                await smtpClient.ConnectAsync(
                    _configuration["EmailSettings:SmtpServer"], 
                    int.Parse(_configuration["EmailSettings:SmtpPort"]), 
                    true // Enable SSL
                );

                await smtpClient.AuthenticateAsync(
                    _configuration["EmailSettings:SmtpUsername"], 
                    _configuration["EmailSettings:SmtpPassword"]
                );

                await smtpClient.SendAsync(email);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw new InvalidOperationException("Email sending failed.", ex);
            }
            finally
            {
                await smtpClient.DisconnectAsync(true);
            }
        }
    }
