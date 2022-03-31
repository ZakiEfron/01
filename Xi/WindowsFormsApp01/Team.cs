using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Team
    {
        int teamId;
        public string name;
        string abbr;
        string logo;

        public void setTeamId(int teamId)
        {
            this.teamId = teamId; 
        }
        public void setName(string name)
        {
            this.name = name; 
        }
        public void setAbbr(string abbr)
        {
            this.abbr = abbr; 
        }
        public void setLogo(string logo)
        {
            this.logo = logo; 
        }
    }
}
