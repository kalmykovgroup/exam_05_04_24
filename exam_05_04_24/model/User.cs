using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    public enum Role{ Student, Teacher, Admin }

    class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
         


        /*      public string Name { get; set; }
              public string LastName { get; set; }
              public string Patronymic { get; set; }
              public string HomeAddress { get; set; } 
              public string Email { get; set; }
              public int Phone { get; set; }
              public DateTime DateTimeDateOfBirth { get; set; }

              public Role Role { get; set; }*/
    }
}
