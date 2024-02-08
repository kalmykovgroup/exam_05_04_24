using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    internal class User_Subject  //Многие ко многим, (С# могут преподавать несколько преподавателей)  
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Subject_Id { get; set; }
    }
}
