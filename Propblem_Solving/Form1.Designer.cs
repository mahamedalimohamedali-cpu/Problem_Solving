namespace Propblem_Solving
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Com_CoursNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Com_Problems_Level = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Com_Proplems_Number = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Token
            // 
            this.Txt_Token.Location = new System.Drawing.Point(176, 99);
            this.Txt_Token.Name = "Txt_Token";
            this.Txt_Token.Size = new System.Drawing.Size(353, 20);
            this.Txt_Token.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "AI Token :";
            // 
            // Com_CoursNumber
            // 
            this.Com_CoursNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_CoursNumber.FormattingEnabled = true;
            this.Com_CoursNumber.Items.AddRange(new object[] {
            "C3",
            "C4",
            "C5",
            "C6",
            "C7",
            "C8",
            "C10",
            "C11",
            "C12",
            "C14",
            "C15",
            "C16",
            "C17"});
            this.Com_CoursNumber.Location = new System.Drawing.Point(176, 149);
            this.Com_CoursNumber.Name = "Com_CoursNumber";
            this.Com_CoursNumber.Size = new System.Drawing.Size(353, 21);
            this.Com_CoursNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Problems Level :";
            // 
            // Com_Problems_Level
            // 
            this.Com_Problems_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_Problems_Level.FormattingEnabled = true;
            this.Com_Problems_Level.Items.AddRange(new object[] {
            "Easy",
            "Mid",
            "Hard"});
            this.Com_Problems_Level.Location = new System.Drawing.Point(176, 219);
            this.Com_Problems_Level.Name = "Com_Problems_Level";
            this.Com_Problems_Level.Size = new System.Drawing.Size(353, 21);
            this.Com_Problems_Level.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Problems Number :";
            // 
            // Com_Proplems_Number
            // 
            this.Com_Proplems_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_Proplems_Number.FormattingEnabled = true;
            this.Com_Proplems_Number.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.Com_Proplems_Number.Location = new System.Drawing.Point(176, 291);
            this.Com_Proplems_Number.Name = "Com_Proplems_Number";
            this.Com_Proplems_Number.Size = new System.Drawing.Size(353, 21);
            this.Com_Proplems_Number.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Com_Proplems_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Com_Problems_Level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Com_CoursNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Token);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Com_CoursNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Com_Problems_Level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Com_Proplems_Number;
        private System.Windows.Forms.Button button1;
    }
}

