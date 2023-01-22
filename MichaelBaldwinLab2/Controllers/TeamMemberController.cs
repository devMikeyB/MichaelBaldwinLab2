using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MichaelBaldwinLab2.Models;

namespace MichaelBaldwinLab2.Controllers
{
    public class TeamMemberController : Controller
    {
        // GET: TeamMember
        public ActionResult Index()
        {
            List<TeamMember> teamMembers = new List<TeamMember>();
            teamMembers.Add(new TeamMember("Michael Baldwin", "Michael organized the project and lead the team from its inception to realization", "Owner and Developer"));
            teamMembers.Add(new TeamMember("Rustam", "Rustam and his team was responsible for much of the development for the project.", "Contracted Developer"));
            teamMembers.Add(new TeamMember("Andrew Payne", "Andrew was the dreamer which asked for this project to be made.", "Customer / Dreamer"));


            return View("Index", teamMembers);
        }
    }
}