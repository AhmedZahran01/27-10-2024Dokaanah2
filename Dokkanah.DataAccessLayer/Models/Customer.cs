using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dokaanah.Models
{
    public class Customer:IdentityUser
    {
        
        public string?                             Name                  { get; set; }
		public string                             Password               { get; set; }
		public string?                        confirmPassword            { get; set; }
		public int?                              PhoneNumber             { get; set; }
        public string?                           Address                 { get; set; }
		public bool?                             isAgree                 { get; set; }

		public virtual ICollection<Order>          Orders                { get; set; } = new List<Order>();
       


    }
}
