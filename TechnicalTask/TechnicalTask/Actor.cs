using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalTask
{
    public class Actor
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        private string _dateOfBirth { get; set; }

        public string dateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                string date = value;
                var birthday = DateTime.Parse(date);

                var age = DateTime.Today.Year - birthday.Year;

                if (birthday.Date > DateTime.Today.AddYears(-age)) age--;

                _dateOfBirth = age.ToString();
            }
        }

    }
}
