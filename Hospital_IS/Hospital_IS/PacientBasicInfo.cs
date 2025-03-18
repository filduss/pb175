using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PacientBasicInfo
    {
        private int id;
        private string name;
        private string email;

        public PacientBasicInfo(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Email { get { return email; } }
    }
}
