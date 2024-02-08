using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    internal class Schedule //Рассписание занятий
    {
        public int Id { get; set; }
        public int Group_Id { get; set; }  //У какой группы
        public int Subject_Id { get; set; } //Какой предмет
        public int User_Id { get; set; } //Кто будет вести занятие
        public DateTime Start_Date { get; set; } //Дата начала занятия
        public DateTime End_Date { get; set; } //Дата окончания занятия

        public string LinkToThePresentation { get; set; } //Ссылка на презинтацию
    } 
}
