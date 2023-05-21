using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public AppUser()
        {
            this.UserName = string.Empty; 
        }

        public int Id { get; set; }
        public string UserName { get; set; }
    }
}