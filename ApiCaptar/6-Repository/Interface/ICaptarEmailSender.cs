namespace apiCaptar._6_Repository.Interface
{
    public interface ICaptarEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
        Task SendEmailAttachmentAsync(string email, string subject, string htmlMessage, string nomePdf, MemoryStream attachmentObject);
        Task SendEmailEncaminhamentoAsync(string email, string subject, string htmlMessage, string secretaria, string primeiroDocumentoNome, byte[] primeiroDocumento, string segundoDocumentoNome, byte[] segundoDocumento, byte[] logoTipoDaUnidade);
        Task SendEmailVisitasAsync(string email, string subject, string htmlMessage, byte[] img, string secretaria);
        Task SendEmailRecuperacaoSenhaAsync(string email, string subject, string htmlMessage);
        Task SendEmailFormacaoAsync(string email, string subject, string htmlMessage, byte[] logo);
    }
}
