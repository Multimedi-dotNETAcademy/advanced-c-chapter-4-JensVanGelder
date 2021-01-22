
namespace Student_Organizer
{
    partial class FormStudent
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
            this.btnUpdatePunten = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.numLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.numComm = new System.Windows.Forms.NumericUpDown();
            this.cmbKlas = new System.Windows.Forms.ComboBox();
            this.numWebtech = new System.Windows.Forms.NumericUpDown();
            this.numProgram = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWebtech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProgram)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdatePunten
            // 
            this.btnUpdatePunten.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdatePunten.Location = new System.Drawing.Point(163, 144);
            this.btnUpdatePunten.Name = "btnUpdatePunten";
            this.btnUpdatePunten.Size = new System.Drawing.Size(120, 23);
            this.btnUpdatePunten.TabIndex = 0;
            this.btnUpdatePunten.Text = "Update";
            this.btnUpdatePunten.UseVisualStyleBackColor = false;
            this.btnUpdatePunten.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 82);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.Location = new System.Drawing.Point(12, 10);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(80, 16);
            this.lblStudentInfo.TabIndex = 4;
            this.lblStudentInfo.Text = "Student info:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblStudentInfo);
            this.panel1.Location = new System.Drawing.Point(313, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 170);
            this.panel1.TabIndex = 5;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(108, 44);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(120, 20);
            this.txtNaam.TabIndex = 6;
            // 
            // numLeeftijd
            // 
            this.numLeeftijd.Location = new System.Drawing.Point(108, 70);
            this.numLeeftijd.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numLeeftijd.Name = "numLeeftijd";
            this.numLeeftijd.Size = new System.Drawing.Size(120, 20);
            this.numLeeftijd.TabIndex = 7;
            this.numLeeftijd.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numComm
            // 
            this.numComm.Location = new System.Drawing.Point(476, 257);
            this.numComm.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numComm.Name = "numComm";
            this.numComm.Size = new System.Drawing.Size(120, 20);
            this.numComm.TabIndex = 8;
            // 
            // cmbKlas
            // 
            this.cmbKlas.FormattingEnabled = true;
            this.cmbKlas.Items.AddRange(new object[] {
            "EA1",
            "EA2",
            "EA3",
            "EA4"});
            this.cmbKlas.Location = new System.Drawing.Point(107, 96);
            this.cmbKlas.Name = "cmbKlas";
            this.cmbKlas.Size = new System.Drawing.Size(121, 21);
            this.cmbKlas.TabIndex = 9;
            // 
            // numWebtech
            // 
            this.numWebtech.Location = new System.Drawing.Point(476, 310);
            this.numWebtech.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWebtech.Name = "numWebtech";
            this.numWebtech.Size = new System.Drawing.Size(120, 20);
            this.numWebtech.TabIndex = 10;
            // 
            // numProgram
            // 
            this.numProgram.Location = new System.Drawing.Point(476, 283);
            this.numProgram.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numProgram.Name = "numProgram";
            this.numProgram.Size = new System.Drawing.Size(120, 20);
            this.numProgram.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnUpdatePunten);
            this.panel2.Location = new System.Drawing.Point(313, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 187);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "WebTech:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProgrammingPrinciples:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Communicatie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punten:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naam:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddStudent.Location = new System.Drawing.Point(123, 144);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(105, 23);
            this.btnAddStudent.TabIndex = 14;
            this.btnAddStudent.Text = "Nieuwe student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Leeftijd:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Klas:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnUpdateInfo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnAddStudent);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtNaam);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.numLeeftijd);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbKlas);
            this.panel3.Location = new System.Drawing.Point(39, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 187);
            this.panel3.TabIndex = 17;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateInfo.Location = new System.Drawing.Point(12, 144);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(83, 23);
            this.btnUpdateInfo.TabIndex = 17;
            this.btnUpdateInfo.Text = "Update";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Info:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Studenten Organizer";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(220, 172);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 19;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numProgram);
            this.Controls.Add(this.numWebtech);
            this.Controls.Add(this.numComm);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormStudent";
            this.Text = "Student Organizer";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWebtech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProgram)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdatePunten;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.NumericUpDown numLeeftijd;
        private System.Windows.Forms.NumericUpDown numComm;
        private System.Windows.Forms.ComboBox cmbKlas;
        private System.Windows.Forms.NumericUpDown numWebtech;
        private System.Windows.Forms.NumericUpDown numProgram;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerwijder;
    }
}

