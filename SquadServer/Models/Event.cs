using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SquadServer.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public ICollection<int> UsersId { get; set; }
        public ICollection<ApplicationUser> Participants { get; set; }
        public ICollection<string> Categorys { get; set; }   
        public DateTime DateAndTime { get; set; }

        public Event(string Title, string Address, DateTime DateAndTime)
        {
            this.Title = Title;
            this.Address = Address;
            this.DateAndTime = DateAndTime;
        }

        public Event(string Title, string Address, DateTime DateAndTime, ICollection<string>Categorys)
        {
            this.Title = Title;
            this.Address = Address;
            this.DateAndTime = DateAndTime;
            this.Categorys = Categorys;
        }
    }
}