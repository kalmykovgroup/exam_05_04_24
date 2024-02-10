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

        public int GroupId { get; set; }  //У какой группы
        public Group Group { get; set; } = null!;


        public int SubjectId { get; set; } //Какой предмет
        public Subject Subject { get; set; } = null!;

        public int UserId { get; set; } //Кто будет вести занятие
        public User User { get; set; } = null!;


        public HomeWork HomeWork { get; set; } = null!;

        public DateTime Start_Date { get; set; } //Дата начала занятия
        public DateTime End_Date { get; set; } //Дата окончания занятия

        public string LinkToThePresentation { get; set; } = null!; //Ссылка на презинтацию
    } 
}
