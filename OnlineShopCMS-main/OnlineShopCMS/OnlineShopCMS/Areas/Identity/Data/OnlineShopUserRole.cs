using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCMS.Areas.Identity.Data
{
    public class OnlineShopUserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }

    public class OnlineShopUserViewModel
    {
        public OnlineShopUser User { get; set; }

        public string RoleName { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get => User.DOB; set => User.DOB = value; }

        public GenderType Gender { get; set; }        

        public DateTime RegistrationDate { get; set; }

        

    }
}
