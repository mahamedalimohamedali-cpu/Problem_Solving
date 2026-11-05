using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GenerativeAI;
using System.Linq.Expressions;
using GenerativeAI.Types;

namespace Propblem_Solving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool FileIsExsits(string Path) 
        {
            if (!File.Exists(Path)) return false;
            return true;
        }
        string GetPathOfCours() 
        {
            string Path = string.Empty;

            for (int i = 3; i <= 17; i++) 
            {
                Path = $@"C_{i}.txt";

                if ((i == 9) || (i == 13)) continue;

                if (Com_CoursNumber.Text == $"C{i}")
                {
                    if (FileIsExsits(Path)) return Path;
                }
            }
            return Path;
        }
        string GetTextFromFile(string Path) 
        {
            string TextinFile = File.ReadAllText(Path);

            return TextinFile;
        }
        async Task <string> SendFileToGemeni() 
         {
            string Path = GetPathOfCours();
            string Api  = Txt_Token.Text.Trim();
            string TextInFile = GetTextFromFile(Path);
            string Prompt = $"Here is the reference content from my file containing my programming problems and style:\n{TextInFile}\n\n" +
                $"You are an expert programming competitive coach. " +
                $"\r\nI have attached a file containing programming problems and code examples that represent" +
                $" my current style and skill level.\r\n\r\nPlease analyze the attached content to understand" +
                $" my current level, then generate exactly ({Com_Proplems_Number.SelectedItem.ToString()}) new programming problems based" +
                $"on that level.\r\n\r\nRequirements for the generated problems:\r\n1. **Count**: Exactly " +
                $"{Com_Proplems_Number.SelectedItem.ToString()} problems.\r\n2. **Difficulty Level**: Match the level shown in " +
                $"the file (around {Com_Problems_Level.SelectedItem.ToString()}).\r\n3. **Originality**: Do NOT copy the " +
                $"exact problems from the file. Create new, original problems with different " +
                $"scenarios and logic, but of a similar complexity and style.\r\n4. " +
                $"**Language**: The entire output (problem descriptions, examples," +
                $" and constraints) must be strictly in **English**.\r\n5. **Format**: " +
                $"For each problem, include:\r\n   - Problem Title\r\n   - " +
                $"Description / Problem Statement\r\n   - Input/Output Examples\r\n   - Constraints";
            try
            {
                var Model = new GenerativeModel(Api, "gemini-3-flash-preview");

                var Response = await Model.GenerateContentAsync(Prompt);

                return Response.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("The Token Is Not Valied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Token.Text = string.Empty;
                Txt_Token.Focus();
                return " ";
            }

        }
        async void InsertInNewFile() 
        {
            string Problems = await SendFileToGemeni();

            if (Problems != " ")
            {
                string FolderName = "AI_Results";


                if (!Directory.Exists(FolderName))
                {
                    Directory.CreateDirectory(FolderName);
                }


                string FileName = $"Problems_Of_Cours{Com_CoursNumber.Text}.text";
                string FullFilePath = Path.Combine(FolderName, FileName);

                File.WriteAllText(FullFilePath, Problems);

                MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pleas Wait Few Minutes Is Send Now To Gemini Wait until the confirmation message arrives", "Info"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            InsertInNewFile();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Com_CoursNumber.Text = "C3";
            Com_Problems_Level.Text = "Easy";
            Com_Proplems_Number.Text = "5";

        }
    }
}
