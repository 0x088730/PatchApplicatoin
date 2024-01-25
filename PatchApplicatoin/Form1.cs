using System.Xml;
using System.IO;

namespace PatchApplicatoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<studentList>" +

                "<student>" +
                "<studentno>1</studentno>" +
                "<studentname>cain</studentname>" +
                "<studentsurname>kazimoglu</studentsurname>" +
                "</student>" +

                "<student>" +
                "<studentno>2</studentno>" +
                "<studentname>mark</studentname>" +
                "<studentsurname>Oliver</studentsurname>" +
                "</student>" +

                "</studentList>"
                );

            //save the file
            

            using (XmlTextWriter writer = new XmlTextWriter(@"../../students.xml", null))
            {
                writer.Formatting = Formatting.Indented;

                doc.Save(writer);

                MessageBox.Show("XML File is saved successfully!");

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void openfile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if(FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);
                foreach ( string file in files ) { 
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach ( string dir in dirs ) {
                    listBox1.Items.Add(dir);
                }
            }
        }
    }
}
