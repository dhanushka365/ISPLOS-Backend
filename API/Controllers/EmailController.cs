using API.Dtos;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        public readonly IEmailSenderRepository _emailSender;
        public EmailController(IEmailSenderRepository emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        [Route("send")]
        public IActionResult SendEmail([FromBody] EmailDTO emailDTO) 
        {
            try
            {
                if (string.IsNullOrWhiteSpace(emailDTO.ToEmail) || string.IsNullOrWhiteSpace(emailDTO.Subject))
                {
                    return BadRequest("ToEmail and Subject are required.");
                }
                _emailSender.SendEmail(emailDTO.ToEmail, emailDTO.Subject);

                return Ok("Email Sent Successfully");
            }
            catch (SmtpException smtpEx)
            {
                return BadRequest("Faild to send email. SMTP error: " +smtpEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild to send mail: " + ex.Message);
            }
        }


    }
}
