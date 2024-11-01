using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.IO;
using System.Threading.Tasks;
using apiCaptar._6_Repository.Interface;
using System.Net.Mail;

namespace apiCaptar._6_Repository.Implementation;

public class SedGridEmailSender : ICaptarEmailSender
{
    private readonly string _apiKey;
    private readonly string _senderEmail;

    public SedGridEmailSender(IConfiguration configuration)
    {
        _apiKey = configuration["SendGrid:ApiKey"];
        _senderEmail = configuration["SendGrid:SenderEmail"];
    }

    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        await ExecuteAsync(subject, htmlMessage, email);
    }

    public async Task SendEmailAttachmentAsync(string email, string subject, string htmlMessage, string nomePdf, MemoryStream attachmentObject)
    {
        var client = new SendGridClient(_apiKey);
        var msg = new SendGridMessage
        {
            From = new EmailAddress(_senderEmail, "CAPTAR - Não Responder"),
            Subject = subject,
            PlainTextContent = htmlMessage,
            HtmlContent = htmlMessage,
        };

        await msg.AddAttachmentAsync(nomePdf, attachmentObject);
        msg.AddTo(new EmailAddress(email));
        msg.SetClickTracking(true, false);
        await client.SendEmailAsync(msg);
    }

    public async Task SendEmailEncaminhamentoAsync(string email, string subject, string htmlMessage, string secretaria, string primeiroDocumentoNome, byte[] primeiroDocumento, string segundoDocumentoNome, byte[] segundoDocumento, byte[] logoTipoDaUnidade)
    {
        var client = new SendGridClient(_apiKey);
        var msg = new SendGridMessage
        {
            From = new EmailAddress(_senderEmail, secretaria),
            Subject = subject,
            PlainTextContent = htmlMessage,
            HtmlContent = htmlMessage,
        };

        if (logoTipoDaUnidade != null)
        {
            var file = Convert.ToBase64String(logoTipoDaUnidade);
            msg.AddAttachment("tipoUnidadeAtendimento.png", file, "image/png", "inline", "logo_tipo_unidade");
        }

        var doc1 = new MemoryStream(primeiroDocumento);
        var doc2 = new MemoryStream(segundoDocumento);

        await msg.AddAttachmentAsync(primeiroDocumentoNome, doc1);
        await msg.AddAttachmentAsync(segundoDocumentoNome, doc2);

        msg.AddTo(new EmailAddress(email));
        msg.SetClickTracking(true, false);

        await client.SendEmailAsync(msg);

        doc1.Close();
        doc2.Close();
    }

    public async Task SendEmailVisitasAsync(string email, string subject, string htmlMessage, byte[] img, string secretaria)
    {
        var client = new SendGridClient(_apiKey);
        var msg = new SendGridMessage
        {
            From = new EmailAddress(_senderEmail, secretaria),
            Subject = subject,
            PlainTextContent = htmlMessage,
            HtmlContent = htmlMessage,
        };

        if (img != null)
        {
            var file = Convert.ToBase64String(img);
            msg.AddAttachment("tipoUnidadeAtendimento.png", file, "image/png", "inline", "logo_tipo_unidade");
        }

        msg.AddTo(new EmailAddress(email));
        msg.SetClickTracking(true, false);
        await client.SendEmailAsync(msg);
    }

    public async Task SendEmailRecuperacaoSenhaAsync(string email, string subject, string htmlMessage)
    {
        var client = new SendGridClient(_apiKey);
        var msg = new SendGridMessage
        {
            From = new EmailAddress(_senderEmail, "CAPTAR - Não Responder"),
            Subject = subject,
            PlainTextContent = htmlMessage,
            HtmlContent = htmlMessage,
        };

        msg.AddTo(new EmailAddress(email));
        msg.SetClickTracking(true, false);
        await client.SendEmailAsync(msg);
    }

    public async Task SendEmailFormacaoAsync(string email, string subject, string htmlMessage, byte[] logo)
    {
        var client = new SendGridClient(_apiKey);
        var msg = new SendGridMessage
        {
            From = new EmailAddress(_senderEmail, "Não responda"),
            Subject = subject,
            PlainTextContent = htmlMessage,
            HtmlContent = htmlMessage
        };

        msg.AddTo(new EmailAddress(email));

        if (logo != null && logo.Length > 0)
        {
            var file = Convert.ToBase64String(logo);
            msg.AddAttachment("logoMunicipio.png", file, "image/png", "inline", "logoMunicipio");
        }

        msg.SetClickTracking(true, false);

        await client.SendEmailAsync(msg);
    }

    private async Task ExecuteAsync(string subject, string message, string email)
    {
        var client = new SendGridClient(_apiKey);
        var msg = new SendGridMessage
        {
            From = new EmailAddress(_senderEmail, "CAPTAR - Não Responder"),
            Subject = subject,
            PlainTextContent = message,
            HtmlContent = message
        };
        msg.AddTo(new EmailAddress(email));
        msg.SetClickTracking(true, false);
        await client.SendEmailAsync(msg);
    }
}
