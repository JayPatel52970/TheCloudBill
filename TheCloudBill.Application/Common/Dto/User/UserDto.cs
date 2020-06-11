using System;
using System.Collections.Generic;
using System.Text;
using TheCloudBill.Application.Common.Dto.Base;

namespace TheCloudBill.Application.Common.Dto.User
{
    public class UserDto : EntityDto <string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }
    }
}
