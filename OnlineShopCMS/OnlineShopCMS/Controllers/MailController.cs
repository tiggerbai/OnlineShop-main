using Microsoft.AspNetCore.Mvc;
using OnlineShopCMS.Models;
using System.Threading.Tasks;
using System;
using OnlineShopCMS.Services;


namespace OnlineShopCMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        // 套用Mail的Method
        private readonly OnlineShopCMS.Services.IMailService _mailService;
        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
                await _mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

}
