namespace CSC240_08_01_EnterInvoices_DG
{
    using System.IO;
    public partial class Form1 : Form
    {
        const string DELIM = ",";
        const string FILENAME =
            @"C:\CSharp\Chapter14\Invoices.txt";
        int num;
        string name;
        double amount;
        static FileStream outFile = new
            FileStream(FILENAME, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
