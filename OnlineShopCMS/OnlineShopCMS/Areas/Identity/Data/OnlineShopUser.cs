using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineShopCMS.Areas.Identity.Data
{
<<<<<<< HEAD
    public class OnlineShopUser : IdentityUser
    {
        public string Name { get; set; }                //名稱
        public DateTime DOB { get; set; }               //生日
        public GenderType Gender { get; set; }          //性別
        public DateTime RegistrationDate { get; set; }  //註冊日期
=======
    // Add profile data for application users by adding properties to the OnlineShopUser class
    public class OnlineShopUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
        public GenderType Gender { get; set; }
        public DateTime RegistrationDate { get; set; }
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
    }

    public enum GenderType
    {
        Male, Female, Unknown
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
