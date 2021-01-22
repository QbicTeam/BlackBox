using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox.Model
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Nombre { get; set; }

        public string Puesto { get; set; }

        public string Status { get; set; }

        public string Password { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
