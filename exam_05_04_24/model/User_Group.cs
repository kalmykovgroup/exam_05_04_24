using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    internal class User_Group //Один студент может учиться в двух группах или не состоять вовсе
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Group_Id { get; set; }

    }
}
