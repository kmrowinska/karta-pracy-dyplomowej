using ArrayToPdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Data;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;

namespace karta_pracy
{
    public partial class Form1 : Form
    {
        public List<Form1> dane = new List<Form1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void textBox2_TextChanged(object sender, EventArgs e){}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e){}

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wpisano b³êdne dane. Spróbuj ponownie");
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
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
            MessageBox.Show("Przed zapisem");
            /*Document doc = new Document();
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

            PrintDialog dialog1 = new PrintDialog();
            dialog1.Document = printDocument1;
            DialogResult r = dialog1.ShowDialog();

            if(r == DialogResult.OK) 
            {
                printDocument1.Print();
            }
        }
    }
}