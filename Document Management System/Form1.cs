using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;


namespace Document_Management_System
{
    public partial class Form1 : Form
    {
        //string wordFilePath = "C:\Users\dell\Documents\Questions----.docx.";
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-U7DD4IT\SQLEXPRESS;Initial Catalog=Doc;Integrated Security=True");
        }
        // Extract questions from Word document
        // var questions = ExtractQuestionsFromWord(wordFilePath);
        // Upload questions to SQL Server database
         //UploadQuestionsToDatabase(questions, SqlConnection);
        // Retrieve questions from the database
         //var retrievedQuestions = RetrieveQuestionsFromDatabase(SqlConnection);
        // Display questions in the console
         //DisplayQuestions(retrievedQuestions);

       //  Console.ReadLine();

        private readonly object sqlDbType;

        public byte[] Value { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox1.Text = dlg.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile(textBox1.Text);
            MessageBox.Show("Saved");
        }
        private void saveFile(string FilePath)
        {
            using (Stream stream = File.OpenRead(FilePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                // string extn = new FileInfo(FilePath.Extension);
                string query = "Insert Into Documents(Question_No,Question_Statement,Option1,Option2,Option3,Option4,Correct_Answer)Values(@quesNo,@quesStat,@O1,@O2,@O3,@O4,@corA)";

                /*using (SqlConnection cn = new GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@quesNo",sqlDbType.int).Value = buffer;
                    cmd.Parameters.Add("@quesStat", sqlDbType.Varchar).Value = extn;
                }*/
            }

        }


    }
}
