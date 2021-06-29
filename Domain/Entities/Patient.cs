 
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Patient
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now.Date;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HealthCardNo { get; set; }
        public string PassportSer { get; set; }
        public string PassportNo { get; set; }
        public string PolisType { get; set; }
        public string PolisNo { get; set; }
        public double Age { get;  set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string[] BadHabits { get; set; }
        public Woman WomenStats { get; set; }
        public Man MenStats { get; set; }
        public Patient()
        {
            Age = DateTime.Now.Year - this.BirthDate.Year;
            FullName = LastName + " " + FirstName + " " + SurName;
            MenStats = new Man();
            WomenStats = new Woman(); 
        }
        
    }
}
