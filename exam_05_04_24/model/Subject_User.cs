using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    internal class Subject_User  //Многие ко многим, (С# могут преподавать несколько преподавателей)  
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SubjectId { get; set; }

        public Subject Subject { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
