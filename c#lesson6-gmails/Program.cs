using System;
using System.Net;
using System.Net.Mail;


string senderEmail = "mirtalibemirli498@gmail.com";
string senderPassword = "aytndmgzqcukvmds";

Console.Write("Enter mail => ");
string recipientEmail = Console.ReadLine();

string smtpServer = "smtp.gmail.com";
int smtpPort = 587;

using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
{
    smtpClient.EnableSsl = true;

    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

    using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail))
    {
        mailMessage.Subject = "Test Email";
        Console.WriteLine("enter message ");
        mailMessage.Body = Console.ReadLine();

        try
        {
            smtpClient.Send(mailMessage);
            Console.WriteLine("Email sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to send email. Error's message: {ex.Message}");
        }
    }
}





/*Console.WriteLine(double.NegativeInfinity);
Console.WriteLine(1.0 / 0.0); // Infinity
Console.WriteLine(-1.0 / 0.0); // -Infinity 
Console.WriteLine(1.0 / -0.0); // -Infinity
Console.WriteLine(-1.0 / -0.0); // Infinity*/
/*
//bool dan int e kecid yoxdu
bool a = true;
bool b = false;
char omegaSymbol = '\u03A9';
char newLine = '\u000A';
int[] arr = { 2, 3, 4, 6 }; 
Console.WriteLine(b? 1 :2 + "\a"); // NaN
Console.WriteLine(newLine); // NaN
*/