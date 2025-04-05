using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        [DataType(DataType.Date,ErrorMessage ="Une date valide")]
        [Display(Name ="Date Of Birth")]
        public DateTime BirthDate { get; set; }
        [Key]
        [MaxLength(7,ErrorMessage ="Taille Max 7")]
        [MinLength(7, ErrorMessage = "Taille Min 7")]
        public string PassportNumber { get; set; }
        //[MinLength(3,ErrorMessage ="Longueur Minimale 3")]
        //[MaxLength(25,ErrorMessage ="Longueur Maximale 25")]
        //[StringLength(25,MinimumLength =3,ErrorMessage ="Taille entre 3 et 25")]
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public FullName MyFullName { get; set; }
        [Phone(ErrorMessage ="Numero de telephone invalide")]
        public string TelNumber { get; set; }
        [EmailAddress(ErrorMessage ="Email invalide")]
        public string EmailAddress { get; set; }
        //public int Id { get; set; }
        public virtual IList<Flight> Flights { get; set; }
        public int Age { get
            { int age = DateTime.Now.Year - BirthDate.Year;
            if (BirthDate.Month > DateTime.Now.Month) age--;
            if (BirthDate.Month == DateTime.Now.Month 
                    && BirthDate.Day > DateTime.Now.Day) age--;
                return age;
            }  }
        public override string ToString()
        {
            return "BirthDate:"+ BirthDate
                + "PassportNumber:" + PassportNumber
                + "FirstName:" + MyFullName.FirstName
                + "LastName:" + MyFullName.LastName
                + "TelNumber:" + TelNumber
                + "EmailAddress:" + EmailAddress
                + "age:" +Age;

        }
        public bool CheckProfile(string firstName, string lastName)
        {
            return MyFullName.FirstName == firstName && MyFullName.LastName == lastName;
        }

        public bool CheckProfile(string firstName, string lastName, string emailAddress)
        {
            return CheckProfile(firstName, lastName) && EmailAddress == emailAddress;
        }

        public void GetAge(DateTime birthDate,ref int calculatedAge)
        {
            //calculatedAge = DateTime.Now.Year - birthDate.Year;
            //if (birthDate.Month > DateTime.Now.Month) calculatedAge--;
            //if (birthDate.Month == DateTime.Now.Month && birthDate.Day> DateTime.Now.Day) calculatedAge--;
        }
        public void GetAge(Passenger aPassenger)
        {
            //aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year;
            //if (aPassenger.BirthDate.Month > DateTime.Now.Month) aPassenger.Age--;
            //if (aPassenger.BirthDate.Month == DateTime.Now.Month && aPassenger.BirthDate.Day > DateTime.Now.Day) aPassenger.Age--;
        }
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
    }
}
