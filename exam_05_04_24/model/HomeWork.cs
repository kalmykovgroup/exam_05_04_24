using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    internal class HomeWork
    {
        public int Id { get; set; }

        public int UserId { get; set; } //Кто будет вести занятие
        public User User { get; set; } = null!;
         

        public int ScheduleId { get; set; } //Пара за каторую задали 
        public Schedule Schedule { get; set; } = null!; 

        public DateTime Created_At { get; set; } //Когда выдано
        public DateTime Dedline { get; set; } //Когда нужно сдать

        public string Topic { get; set; } = null!; //Тема урока 

        public string? Description { get; set; } //Описание ДЗ
        public string? LinkToTheMaterial { get; set; } //Ссылка на скачивание
    }
}
