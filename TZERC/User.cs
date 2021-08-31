using System;
using System.Collections.Generic;

#nullable disable

namespace TZERC
{
    public partial class User
    {
        public User()
        {
            DataUsers = new HashSet<DataUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surnsme { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int PersonThisLive { get; set; }
        public bool PriborXvs { get; set; }
        public bool PriborGvs { get; set; }
        public bool PriborElect { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<DataUser> DataUsers { get; set; }
    }
}
