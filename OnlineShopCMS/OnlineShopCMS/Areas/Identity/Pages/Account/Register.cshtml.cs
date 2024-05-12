using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using OnlineShopCMS.Areas.Identity.Data;

namespace OnlineShopCMS.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<OnlineShopUser> _signInManager;
        private readonly UserManager<OnlineShopUser> _userManager;
<<<<<<< HEAD
        private readonly RoleManager<IdentityRole> _roleManager;
=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<OnlineShopUser> userManager,
            SignInManager<OnlineShopUser> signInManager,
<<<<<<< HEAD
            RoleManager<IdentityRole> roleManager,
=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
<<<<<<< HEAD
            _roleManager = roleManager;
=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
<<<<<<< HEAD

=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Full name")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Birth Date")]
            [DataType(DataType.Date)]
            public DateTime DOB { get; set; }

            [Required]
            [Display(Name = "Gender")]
            public GenderType Gender { get; set; }

            public DateTime RegistrationDate { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
                var user = new OnlineShopUser
                {
                    UserName = Input.Email,
=======
                var user = new OnlineShopUser { 
                    UserName = Input.Email, 
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
                    Email = Input.Email,
                    Name = Input.Name,
                    DOB = Input.DOB,
                    Gender = Input.Gender,
                    RegistrationDate = DateTime.Today
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
<<<<<<< HEAD
                    _userManager.AddToRoleAsync(user, "User").Wait(); // 將 "Administrator" 改為 "User"
=======
                    _userManager.AddToRoleAsync(user, "User").Wait(); //加入角色
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
