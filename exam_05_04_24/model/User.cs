using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    public enum Role{ Student, Teacher, Admin }

    class User
    {
        public int Id { get; set; }

        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;

        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public int Phone { get; set; }

        public string? HomeAddress { get; set; } 
        public string? Email { get; set; }
     
        public DateTime? DateTimeDateOfBirth { get; set; }
         
         
        List<Group> Groups { get; } = [];

        List<Subject> Subjects { get; } = []; 

        Schedule? Schedule { get; set; }
        HomeWork? HomeWork { get; set; }

        [NotMapped]
        public Role Role { get; set; } //Роль в которой авторизовался пользователь (как студент или админ...)

      
    }
}
