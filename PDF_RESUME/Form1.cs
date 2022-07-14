using System.Text.Json;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Text;

namespace PDF_RESUME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void ctostringbtn_Click(object sender, EventArgs e)
        {
            String json_file = (@"C:\Users\JULIA-ANN\source\repos\PDF_RESUME\PDF_RESUME\inforesume.json");
            String sJson = File.ReadAllText(json_file);
            Infos resume = JsonSerializer.Deserialize<Infos>(sJson)!;

            //Converting basic infos to String
            String FirstName = resume.FirstName;
            String MiddleName = resume.MiddleName;
            String LastName = resume.LastName;
            String Birthday = resume.Birthday;
            String Email = resume.Email;
            String PhoneNumber = resume.PhoneNumber;
            String HomeAddress = resume.HomeAddress;
            String City = resume.City;
            String Province = resume.Province;
            String PostalCode = resume.PostalCode;

            //Converting background education infos to String
            String HighSchool = resume.HighSchool;
            String HSSchoolYear = resume.HSSchoolYear;
            String SeniorHighSchool = resume.SeniorHighSchool;
            String ShsStrand = resume.ShsStrand;
            String SHSSchoolYear = resume.SHSSchoolYear;
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

            //BASIC INFORMATION
            namelabel.Text = "Name: " + resume.LastName + ", " + resume.FirstName + " " + resume.MiddleName;
            bdaylabel.Text = "Birthday: " + resume.Birthday;
            emaillabel.Text = "Email: " + resume.Email;
            pnumlabel.Text = "Phone Number: " + resume.PhoneNumber;
            haddresslabel.Text = "Home Address: " + resume.HomeAddress + ", " + resume.City + ", " + resume.Province + " ("+ resume.PostalCode + ")";

            //EDUCATION
            jhschoollabel.Text = "Junior High School: " + resume.HighSchool;
            hssyearlabel.Text = "School Year: " + resume.HSSchoolYear;
            shschoollabel.Text = "Senior High School: " + resume.SeniorHighSchool + " (" + resume.ShsStrand + ")";
            shssyearlabel.Text = "School Year: " + resume.SHSSchoolYear;
            collegelabel.Text = "College: " + resume.College + " (" + resume.Course + ")";
            csyearlabel.Text = "School Year: " + resume.CSchoolYear;

            //SKILLS AND QUALIFICATIONS
            skill1label.Text = resume.Skill1 + " - " + resume.Description1;
            skill2label.Text = resume.Skill2 + " - " + resume.Description2;
            skill3label.Text = resume.Skill3 + " - " + resume.Description3;
            skill4label.Text = resume.Skill4 + " - " + resume.Description4;

            //CERTIFICATES AND ACHIEVEMENTS
            award1label.Text = resume.Award1;
            award2label.Text = resume.Award2;
            award3label.Text = resume.Award3;
            award4label.Text = resume.Award4;
        }


        private void shssyearlabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        //Convert Json file to PDF file
        private void pdfconverterbutton_Click(object sender, EventArgs e)
        {
            String json_file = (@"C:\Users\JULIA-ANN\source\repos\PDF_RESUME\PDF_RESUME\inforesume.json");
            String sJson = File.ReadAllText(json_file);
            Infos resume = JsonSerializer.Deserialize<Infos>(sJson)!;

            //Converting basic infos to String
            String FirstName = resume.FirstName;
            String MiddleName = resume.MiddleName;
            String LastName = resume.LastName;
            String Birthday = resume.Birthday;
            String Email = resume.Email;
            String PhoneNumber = resume.PhoneNumber;
            String HomeAddress = resume.HomeAddress;
            String City = resume.City;
            String Province = resume.Province;
            String PostalCode = resume.PostalCode;

            //Converting background education infos to String
            String HighSchool = resume.HighSchool;
            String HSSchoolYear = resume.HSSchoolYear;
            String SeniorHighSchool = resume.SeniorHighSchool;
            String ShsStrand = resume.ShsStrand;
            String SHSSchoolYear = resume.SHSSchoolYear;
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

            using (SaveFileDialog pdffile = new SaveFileDialog())
            {
                pdffile.InitialDirectory = (@"C:\Users\JULIA-ANN\source\repos\resume");
                pdffile.FileName = LastName + "_" + FirstName + ".pdf";
                pdffile.Filter = "PDF|*.pdf";

                if (pdffile.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf_resume = new PdfDocument();
                    PdfPage pdf_page = pdf_resume.AddPage();
                    pdf_resume.Info.Title = "MY RESUME";
                    
                    XGraphics grphcs = XGraphics.FromPdfPage(pdf_page);

                    //Background
                    grphcs.DrawRoundedRectangle(XBrushes.PeachPuff, 0, 0, pdf_page.Width.Point, pdf_page.Height.Point, 0, 0);
                    grphcs.DrawRoundedRectangle(XBrushes.PapayaWhip, 20, 20, pdf_page.Width.Point, pdf_page.Height.Point, 20, 20);

                    //Fonts
                    XFont forname = new XFont("Arial Black", 30, XFontStyle.Bold);
                    XFont forbtxt = new XFont("Georgia", 18, XFontStyle.Bold);
                    XFont forstxt = new XFont("Georgia", 16, XFontStyle.Regular);

                    //Margin
                    int left = 50;
                    int down = 200;

                    //Putting picture in pdf that is not in json file
                    String pic1x1 = (@"C:\Users\JULIA-ANN\source\repos\Julia\JULIA.jpg");
                    XImage mypic = XImage.FromFile(pic1x1);

                    //- papunta sa left, + papunta sa right
                    //mas mababa, pataas
                    grphcs.DrawImage(mypic, left + 0, 45, 150, 180);

                    //+ papunta sa right, - mas malaki minus pataas
                    //Full Name
                    grphcs.DrawString(FirstName, forname, XBrushes.Black, new XRect(left + 180, down - 140, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                    grphcs.DrawString(MiddleName + " " + LastName, forname, XBrushes.Black, new XRect(left + 180, down - 100, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);

                    pdf_resume.Save(pdffile.FileName);
                    Application.Exit();
                }
            }
        }
    } 
}