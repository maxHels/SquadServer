using System;
using System.Collections;
using System.Collections.Generic;

namespace SquadServer.Models
{
    public class Event
    {
        string Title { get; set; }
        string Address { get; set; }
        ICollection<int> UsersId { get; set; }
        ICollection<ApplicationUser> Participants { get; set; }
        ICollection<string> Categorys { get; set; }   
        DateTime DateAndTime { get; set; }

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