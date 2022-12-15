using ArrayToPdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.interfaces;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Data;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;
using GdPicture;
using GdPicture14;

namespace karta_pracy
{
    public partial class Form1 : Form
    {
        /*
         * 1) NAPRAW ZE W 1 RUBRYCE TYLKO POLITECHNIKA POZNANSKA AKCEPTUJE
         * 2) NAPRAW ZE WIDZI SPACJE
         * 3) NAPRAW TEN ZJEBANY ZAPIS DO PDF GOWNO JEBANE
         */

        bool b1 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wprowadzono b³êdny znak. Spróbuj ponownie");
            }
            else
            {
                e.Handled= false;
                if(!(textBox1.Text == "Politechnika Poznañska"))
                {
                    MessageBox.Show("Wprowadzono Ÿle nazwê uczelni");
                    textBox1.Clear();
                    textBox1.Text = "Politechnika Poznañska";
                }
                else
                {
                    MessageBox.Show("Wpisano poprawn¹ uczelnie");
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }   
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
            else
            {
                e.Handled = false;
                if (!(textBox4.Text == "Ogólnokszta³c¹cy"))
                {
                    MessageBox.Show("Wprowadzono z³y profil studiów");
                    textBox4.Clear();
                    textBox4.Text = "Ogólnokszta³c¹cy";
                }
                else
                {
                    MessageBox.Show("Wpisano poprawnie dane");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e){}

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Przed zapisem");
            var doc = Form.ActiveForm;
            using(var bmp = new Bitmap(doc.Width, doc.Height)) 
            {
                doc.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Users\kinga\Desktop\karta.png");
                MessageBox.Show("Udalo sie!");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Przed zapisem");
            Document doc = new Document();
            using (var stream = new FileStream("karta.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();
                using (var imageStream = new FileStream("karta.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var img = Image.GetInstance(imageStream);
                    doc.Add(img);
                }
                doc.Close();
                MessageBox.Show("Udalo sie!");
            }*/


            using (GdPictureDocumentConverter oConverter = new GdPictureDocumentConverter())
            {
                // Select your source image and its image format (TIFF, JPG, PNG, SVG, and 50+ more).
                GdPictureStatus status = oConverter.LoadFromFile(@"C:\Users\kinga\Desktop\karta.png", GdPicture14.DocumentFormat.DocumentFormatJPEG);
                if (status == GdPictureStatus.OK)
                {
                    MessageBox.Show("The file has been loaded successfully.", "Conversion to PDF Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Select the conformance of the resulting PDF document.
                    status = oConverter.SaveAsPDF(@"C:\Users\kinga\Desktop\result.pdf", PdfConformance.PDF);
                    if (status == GdPictureStatus.OK)
                    {
                        MessageBox.Show("The file has been saved successfully.", "Conversion to PDF Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The file has failed to save. Status: " + status.ToString(), "Conversion to PDF Example", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The file has failed to load. Status: " + status.ToString(), "Conversion to PDF Example", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}