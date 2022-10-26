namespace sayitahmin
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int sayi;
        public Form1()
        {
            InitializeComponent();
            sayi = rnd.Next(10);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (sayi > int.Parse(textBox1.Text))
            {
                label2.Text = "Arttýrýnýz";
            }
            else if (sayi < int.Parse(textBox1.Text))
            {
                label2.Text = "Azaltýnýz";
               
            }
            else 
            {
                label2.Text = "Doðru Cevap";
            }

        }
    }
}