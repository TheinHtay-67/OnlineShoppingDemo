using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingDemo.Shared.Model
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NRC_No { get; set; }
        public string? Address { get; set; }
        public int Gender { get; set; }
        public string PhoneNo { get; set; }
        public string? Email { get; set; }
    }
}
