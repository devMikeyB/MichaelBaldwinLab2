using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichaelBaldwinLab2.Models
{
    public class TeamMember
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Role { get; set; }

        public TeamMember()
        {
            Name = String.Empty;
            Description = String.Empty;
            Role = String.Empty;
        }

        public TeamMember(String name, String description, String role)
        {
            Name = name;
            Description = description;
            Role = role;
        }
    }
}