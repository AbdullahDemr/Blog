using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.JsonTable;
using TigrisTech.Entities.Dtos.Editor.Emails;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Results.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;
using TigrisTech.Shared.Utilities.Results.Concrete;

namespace TigrisTech.Services.Concrete
{
    public class MailManager : IMailService
    {
        private readonly SmtpSetting _smtpSetting;

        public MailManager(IOptions<SmtpSetting> smtpSetting)
        {
            _smtpSetting = smtpSetting.Value;
        }
        public IResult SendLink(PasswordResetDto passwordResetDto, string link)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSetting.SenderEmail),
                To = { new MailAddress(passwordResetDto.Email) },
                Subject = $"www.tigristech.net  ::   Şifre sıfırlama",
                IsBodyHtml = true,
                Body = $"<h2>Şifrenizi yenilemek için lütfen aşağıdaki linke tıklayınız.</h2><hr/> <br> <a href='{link}'>şifre yenileme linki</a>" 
            
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSetting.Server,
                Port = _smtpSetting.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSetting.UserName, _smtpSetting.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);
            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }
        public IResult Send(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSetting.SenderEmail),
                To = { new MailAddress(emailSendDto.Email) },
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                Body = emailSendDto.Message
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSetting.Server,
                Port = _smtpSetting.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSetting.UserName, _smtpSetting.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);
            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }

        public IResult SendContactEmail(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(emailSendDto.Email),
                To = { new MailAddress(_smtpSetting.SenderEmail) },
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                Body = $"Gönderen Kişi : {emailSendDto.Name}, Gönderen E-Posta Adresi : {emailSendDto.Email}<br/>{emailSendDto.Message}"
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSetting.Server,
                Port = _smtpSetting.Port,
                EnableSsl =true,
                UseDefaultCredentials=false,
                Credentials = new NetworkCredential(_smtpSetting.UserName,_smtpSetting.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);
            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }
    }
}
