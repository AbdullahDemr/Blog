using TigrisTech.Entities.Dtos.Editor.Emails;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto);
        IResult SendLink(PasswordResetDto passwordResetDto, string link);
        IResult SendContactEmail(EmailSendDto emailSendDto);

    }
}
