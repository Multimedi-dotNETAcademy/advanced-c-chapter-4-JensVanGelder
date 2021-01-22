using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Organizer
{
    public partial class FormStudent : Form
    {
        private List<Student> students = new List<Student>();

        public FormStudent()
        {
            InitializeComponent();
            students.Add(new Student() { Naam = "Octaaf", Leeftijd = 60, Klas = Klassen.EA1 });
            students.Add(new Student() { Naam = "Gert", Leeftijd = 56, Klas = Klassen.EA2 });
            students.Add(new Student() { Naam = "Alberto", Leeftijd = 58, Klas = Klassen.EA3 });
            students.Add(new Student() { Naam = "Samson", Leeftijd = 10, Klas = Klassen.EA4 });
            students.Add(new Student() { Naam = "Frieda", Leeftijd = 50, Klas = Klassen.EA1 });
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            UpdateListBoxStudents();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblStudentInfo.Text = students[listBox1.SelectedIndex].ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStudentInfo.Text = students[listBox1.SelectedIndex].GeefOverzicht();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            students[listBox1.SelectedIndex].PuntenCommunicatie = Convert.ToInt32(numComm.Value);
            students[listBox1.SelectedIndex].PuntenProgrammingPrinciples = Convert.ToInt32(numProgram.Value);
            students[listBox1.SelectedIndex].PuntenWebTech = Convert.ToInt32(numWebtech.Value);
            lblStudentInfo.Text = students[listBox1.SelectedIndex].GeefOverzicht();
            UpdateListBoxStudents();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student() { Naam = txtNaam.Text, Leeftijd = Convert.ToInt32(numLeeftijd.Value), Klas = CheckKlassen() };
            DialogResult dialogResult = ConfirmationBox($"Zeker dat je deze student wilt toevoegen? \n {newStudent.ToString()}");
            if (dialogResult == DialogResult.Yes)
            {
                students.Add(newStudent);
                listBox1.Items.Add(newStudent.ToString());
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            DialogResult dialogResult = ConfirmationBox($"{students[index].Naam} info wijzigen?");
            if (dialogResult == DialogResult.Yes)
            {
                if (txtNaam.Text != "")
                {
                    students[index].Naam = txtNaam.Text;
                }
                if (cmbKlas.SelectedIndex.ToString() != students[index].Klas.ToString())
                {
                    students[index].Klas = CheckKlassen();
                }
                if (numLeeftijd.Value != 3)
                {
                    int newLeeftijd = Convert.ToInt32(numLeeftijd.Value);
                    students[index].Leeftijd = newLeeftijd;
                }
                UpdateListBoxStudents();
            }
        }

        public DialogResult ConfirmationBox(string output)
        {
            DialogResult dialogResult = MessageBox.Show(output, "Zeker?", MessageBoxButtons.YesNo);
            return dialogResult;
        }

        public Klassen CheckKlassen()
        {
            switch (cmbKlas.SelectedItem)
            {
                case "EA1":
                    return Klassen.EA1;

                case "EA2":
                    return Klassen.EA2;

                case "EA3":
                    return Klassen.EA3;

                case "EA4":
                    return Klassen.EA4;

                default:
                    return Klassen.EA1;
            }
        }

        private void UpdateListBoxStudents()
        {
            listBox1.Items.Clear();
            foreach (Student student in students)
            {
                listBox1.Items.Add(student.ToString());
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            DialogResult dialogResult = ConfirmationBox($"{students[index].Naam} verwijderen?");
            if (dialogResult == DialogResult.Yes)
            {
                students.RemoveAt(index);
                UpdateListBoxStudents();
            }
        }
    }
}