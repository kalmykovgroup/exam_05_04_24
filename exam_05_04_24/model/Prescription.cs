using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    internal class Prescription 
    {
        public int Id { get; set; }
        public int User_Id { get; set; } //Какому студенту
        public int Schedule_Id { get; set; } //За какую пару задали
        public int Home_Work_Id { get; set; } //Какое домашнее задание
        public DateTime Created_At {  get; set; } //Когда выдано
        public DateTime Dedline {  get; set; } //Когда нужно сдать


    }
}
