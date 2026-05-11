using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Am.ApplicationCore.Domaine
{
    public class Passenger
    {
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)] 
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        [MinLength(3, ErrorMessage = "Le prénom doit avoir au moins 3 caractères")]
        [MaxLength(25, ErrorMessage = "Le prénom ne peut pas dépasser 25 caractères")]
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        [RegularExpression(@"^[0-9]{8}$")]
        public int TelNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "LastName : " + LastName + " FirstName : " + FirstName + " Email : "+EmailAddress;
        }

        public bool CheckProfile(string firstName, string lastName)
        {
            return (FirstName == firstName) && LastName.Equals(lastName);
        }
        public bool CheckProfile(string firstName, string lastName,string emailAddress)
        {
            return (FirstName == firstName) && LastName.Equals(lastName) && EmailAddress.Equals(emailAddress);
        }
        public bool CheckProfile3(string firstName, string lastName,string emailAddress=null)
        {
            if (emailAddress != null)
                return (FirstName == firstName) && LastName.Equals(lastName) && EmailAddress.Equals(emailAddress);
            return (FirstName == firstName) && (LastName.Equals(lastName));
        }
        public virtual void passengerType() {
        Console.WriteLine("I am a passenger");
        }
    }
}
