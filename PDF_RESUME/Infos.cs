using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_RESUME
{
    public class Infos
    {
        //BASIC INFORMATION
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        //EDUCATION
        public string HighSchool { get; set; }
        public string HSSchoolYear { get; set; }
        public string SeniorHighSchool { get; set; }
        public string ShsStrand { get; set; }
        public string SHSSchoolYear { get; set; }
        public string College { get; set; }
        public string Course { get; set; }
        public string CSchoolYear { get; set; }

        //SKILLS AND QUALIFICATIONS
        public string Skill1 { get; set; }
        public string Description1 { get; set; }
        public string Skill2 { get; set; }
        public string Description2 { get; set; }
        public string Skill3 { get; set; }
        public string Description3 { get; set; }
        public string Skill4 { get; set; }
        public string Description4 { get; set; }

        //CERTIFICATES AND ACHIEVEMENTS
        public string Award1 { get; set; }
        public string Award2 { get; set; }
        public string Award3 { get; set; }
        public string Award4 { get; set; }
    }
}
