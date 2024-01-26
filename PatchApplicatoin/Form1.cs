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

        List<string> fileNames = new List<string>();
        private void openfile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                fileNames.AddRange(Directory.GetFiles(FBD.SelectedPath).Select(Path.GetFileName));
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);
                foreach (string file in fileNames)
                {
                    listBox1.Items.Add(file);
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(dir);
                }
            }
        }
        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            // Create a new XML document
            XmlDocument doc = new XmlDocument();
            XmlElement animationList = doc.CreateElement("animationList");

            // Loop through the file names and add them to the XML
            for (int i = 0; i < fileNames.Count; i++)
            {
                XmlElement animation = doc.CreateElement("animation");

                XmlElement animationno = doc.CreateElement("animationno");
                animationno.InnerText = (i + 1).ToString(); // Set the animation number based on the index

                XmlElement animationname = doc.CreateElement("animationname");
                animationname.InnerText = fileNames[i]; // Set the animation name as the file name

                // Assuming there is no surname for the file names, you can leave this out

                animation.AppendChild(animationno);
                animation.AppendChild(animationname);

                animationList.AppendChild(animation);
            }

            doc.AppendChild(animationList);

            // Save the file
            using (XmlTextWriter writer = new XmlTextWriter(@"../../patched.xml", null))
            {
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
                MessageBox.Show("XML File is saved successfully!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
