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

            String FirstName = resume.FirstName;
            String MiddleName = resume.MiddleName;
            String LastName = resume.LastName;

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
                    XFont forname = new XFont("Arial Black", 35, XFontStyle.Bold);
                    XFont forbtxt = new XFont("Georgia", 18, XFontStyle.Bold);
                    XFont forstxt = new XFont("Georgia", 16, XFontStyle.Regular);
                    XFont forxstxt = new XFont("Georgia", 12, XFontStyle.Regular);

                    //Margin
                    int left = 50;
                    int down = 200;

                    {   // PICTURE
                        String pic1x1 = (@"C:\Users\JULIA-ANN\source\repos\Julia\JULIA.jpg");
                        XImage mypic = XImage.FromFile(pic1x1);

                        // - papunta sa left, + papunta sa right
                        // mas mababa, pataas
                        grphcs.DrawImage(mypic, left + 0, 45, 110, 130);
                    }

                    {  
                        // FULL NAME
                        // + papunta sa right, - mas malaki minus pataas
                        grphcs.DrawString(FirstName, forname, XBrushes.Black, new XRect(left + 130, down - 140, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString(MiddleName + " " + LastName, forname, XBrushes.Black, new XRect(left + 160, down - 100, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                    }

                    {   
                        // BASIC INFOS
                        String Birthday = resume.Birthday;
                        String Email = resume.Email;
                        String PhoneNumber = resume.PhoneNumber;
                        String HomeAddress = resume.HomeAddress;
                        String City = resume.City;
                        String Province = resume.Province;
                        String PostalCode = resume.PostalCode;

                        grphcs.DrawString("BASIC INFORMATION", forbtxt, XBrushes.Black, new XRect(left + 0, down - 15, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Birthday: " + Birthday, forstxt, XBrushes.Black, new XRect(left + 5, down + 10, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Email: " + Email, forstxt, XBrushes.Black, new XRect(left + 5, down + 30, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Phone Number: " + PhoneNumber, forstxt, XBrushes.Black, new XRect(left + 5, down + 50, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Home Address: " + HomeAddress + ",", forstxt, XBrushes.Black, new XRect(left + 5, down + 70, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( City + ", " + PostalCode, forstxt, XBrushes.Black, new XRect(left + 120, down + 85, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                    }

                    {   
                        // BACKGROUND EDUCATION
                        String HighSchool = resume.HighSchool;
                        String HSSchoolYear = resume.HSSchoolYear;
                        String SeniorHighSchool = resume.SeniorHighSchool;
                        String ShsStrand = resume.ShsStrand;
                        String SHSSchoolYear = resume.SHSSchoolYear;
                        String College = resume.College;
                        String Course = resume.Course;
                        String CSchoolYear = resume.CSchoolYear;

                        grphcs.DrawString("BACKGROUND EDUCATION", forbtxt, XBrushes.Black, new XRect(left + 0, down +120, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Junior High School: " + HighSchool, forstxt, XBrushes.Black, new XRect(left + 5, down + 145, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("School Year: " + HSSchoolYear, forstxt, XBrushes.Black, new XRect(left + 5, down + 165, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Senior High School: " + SeniorHighSchool, forstxt, XBrushes.Black, new XRect(left + 5, down + 185, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Strand: " + ShsStrand + ",", forstxt, XBrushes.Black, new XRect(left + 5, down + 205, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("School Year: " + SHSSchoolYear, forstxt, XBrushes.Black, new XRect(left + 5, down + 225, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("College: " + College, forstxt, XBrushes.Black, new XRect(left + 5, down + 245, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("Course: " + Course + ",", forstxt, XBrushes.Black, new XRect(left + 5, down + 265, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString("School Year: " + CSchoolYear, forstxt, XBrushes.Black, new XRect(left + 5, down + 285, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                    }

                    {   
                        //SKILLS AND QUALIFICATIONS
                        String Skill1 = resume.Skill1;
                        String Description1 = resume.Description1;
                        String Skill2 = resume.Skill2;
                        String Description2 = resume.Description2;
                        String Skill3 = resume.Skill3;
                        String Description3 = resume.Description3;
                        String Skill4 = resume.Skill4;
                        String Description4 = resume.Description4;

                        grphcs.DrawString("SKILLS AND QUALIFICATIONS", forbtxt, XBrushes.Black, new XRect(left + 0, down + 320, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Skill1 + ":", forstxt, XBrushes.Black, new XRect(left + 5, down + 345, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Description1, forxstxt, XBrushes.Black, new XRect(left + 5, down + 365, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Skill2 + ":", forstxt, XBrushes.Black, new XRect(left + 5, down + 385, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Description2, forxstxt, XBrushes.Black, new XRect(left + 5, down + 405, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Skill3 + ":", forstxt, XBrushes.Black, new XRect(left + 5, down + 425, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Description3, forxstxt, XBrushes.Black, new XRect(left + 5, down + 445, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Skill4 + ":", forstxt, XBrushes.Black, new XRect(left + 5, down + 465, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString( Description4, forxstxt, XBrushes.Black, new XRect(left + 5, down + 485, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                    }

                    {   
                        //CERTIFICATES AND ACHIEVEMENTS
                        String Award1 = resume.Award1;
                        String Award2 = resume.Award2;
                        String Award3 = resume.Award3;
                        String Award4 = resume.Award4;

                        grphcs.DrawString("CERTIFICATES AND ACHIEVEMENTS", forbtxt, XBrushes.Black, new XRect(left + 0, down + 515, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString(Award1, forstxt, XBrushes.Black, new XRect(left + 5, down + 540, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString(Award2, forstxt, XBrushes.Black, new XRect(left + 5, down + 560, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString(Award3, forstxt, XBrushes.Black, new XRect(left + 5, down + 580, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                        grphcs.DrawString(Award4, forstxt, XBrushes.Black, new XRect(left + 5, down + 600, pdf_page.Width.Point, pdf_page.Height.Point), XStringFormats.TopLeft);
                    }

                    pdf_resume.Save(pdffile.FileName);
                    Application.Exit();
                }
            }
        }
    } 
}