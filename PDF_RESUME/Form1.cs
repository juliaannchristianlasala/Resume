using System.Text.Json;
namespace PDF_RESUME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctostringbtn_Click(object sender, EventArgs e)
        {
            String json_file = (@"C:\Users\JULIA-ANN\source\repos\PDF_RESUME\PDF_RESUME\inforesume.json");
            String sJson = File.ReadAllText(json_file);
            Infos resume = JsonSerializer.Deserialize<Infos>(sJson)!;
            MessageBox.Show("Information Converted");

            //Converting basic infos to String
            String FullName = resume.FullName;
            String Birthday = resume.Birthday;
            String Email = resume.Email;
            String PhoneNumber = resume.PhoneNumber;
            String HomeAddress = resume.HomeAddress;
            String City = resume.City;
            String Province = resume.Province;
            String PostalCode = resume.PostalCode;

            //Converting background education infos to String
            String HighSchool = resume.HighSchool;
            String Strand = resume.Strand;
            String HSSchoolYear = resume.HSSchoolYear;
            String College = resume.College;
            String Course = resume.Course;
            String CSchoolYear = resume.CSchoolYear;

            //Converting skills and qualification infos to String
            String Skill1 = resume.Skill1;
            String Description1 = resume.Description1;
            String Skill2 = resume.Skill2;
            String Description2 = resume.Description2;
            String Skill3 = resume.Skill3;
            String Description3 = resume.Description3;
            String Skill4 = resume.Skill4;
            String Description4 = resume.Description4;

            //Converting certificate and achievements info to String
            String Award1 = resume.Award1;
            String Award2 = resume.Award2;
            String Award3 = resume.Award3;
            String Award4 = resume.Award4;

            //Show the infos in textbox
            namelabel.Text = "Name: " + resume.FullName;
            bdaylabel.Text = "Birthday: " + resume.Birthday;
            emaillabel.Text = "Email: " + resume.Email;
            pnumlabel.Text = "Phone Number: " + resume.PhoneNumber;
            haddresslabel.Text = "Home Address: " + resume.HomeAddress + ", " + resume.City + ", " + resume.Province + " ("+ resume.PostalCode + ")";
        }
    } 
}