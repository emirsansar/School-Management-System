using SchoolManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem.View
{
    public partial class AdminGuı : Form
    {
        private Admin _admin;
        public AdminGuı(Admin admin)
        {
            InitializeComponent();
            
            this._admin = admin;
        }
        
        private void AdminGUI_Load(object sender, EventArgs e)
        {
            Greeting();
            GetBranchList();
            
        }

        private void Greeting()
        {
            lbl_greeting.Text = $"Welcome, Dear {_admin.Name} {_admin.Surname} " ;
        }

        private void GetBranchList()
        {
            List<Branch> branches = _admin.GetBranches();
            
            cmb_branch.Items.Clear(); 
            cmb_branch.DisplayMember = "Name"; 
            cmb_branch.ValueMember = "ID"; 
            cmb_branch.DataSource = branches;
        }

        private void cmb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Teacher> teachers = null;
            int selectedBranchId = (int)cmb_branch.SelectedValue;

            if (selectedBranchId != 0) 
            {
                teachers = _admin.GetTeachersByBranchId(selectedBranchId);
            }
            
            cmb_teacher.Items.Clear();
            cmb_teacher.DisplayMember = "FullName";
            cmb_teacher.ValueMember = "ID";
            if (teachers != null)
            {
                foreach(var teacher in teachers)
                {
                    cmb_teacher.Items.Add(teacher);
                }
            }

            if (cmb_teacher.Items.Count > 1) cmb_teacher.SelectedIndex = 0;
        }
        
        private void btn_createLesson_Click(object sender, EventArgs e)
        {
            if (cmb_branch.SelectedItem != null && cmb_teacher.SelectedItem != null)
            {
                Branch selectedBranch = (Branch)cmb_branch.SelectedItem;
                Teacher selectedTeacher = (Teacher)cmb_teacher.SelectedItem;

                _admin.CreateLesson(selectedBranch.Id, selectedTeacher.Id, mskd_date.Text, mskd_time.Text);
            }
        }
        
        private void cmb_student_DropDown(object sender, EventArgs e)
        {   
            cmb_student.DisplayMember = "FullName";
            cmb_student.ValueMember = "ID";
            
            List<Student> students = _admin.GetStudents();
            foreach (var student in students)
            {   
                Console.WriteLine(student.Id);
                cmb_student.Items.Add(student);
            }
        }
        
        private void btn_addStdToLesson_Click(object sender, EventArgs e)
        {   
            bool isClassIdEmpty = string.IsNullOrWhiteSpace(text_classID.Text);
            Student student = (Student)cmb_student.SelectedItem;
            var selectedStudent = student.Id;
            if (!isClassIdEmpty)
            {
                if (int.TryParse(text_classID.Text, out int id))
                {   
                    Console.WriteLine(text_classID.Text);
                    if (selectedStudent > 0)
                    {   
                        Console.WriteLine(text_classID.Text);
                        _admin.AddStdToLesson(id, selectedStudent);
                        text_classID.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please select a student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Class ID must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Class ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btn_registerStd_Click(object sender, EventArgs e)
        {
            var name = txt_stdName.Text;
            var surname = txt_stdSurname.Text;
            var classroom = txt_classroom.Text;
            var phone = txt_phone.Text;
            var mail = txt_mail.Text;

            _admin.RegisterStudent(name,surname,classroom,phone,mail);
        }
        
        private void btn_addBranch_Click(object sender, EventArgs e)
        {
            if (text_branchName.Text != null)
            {
                _admin.AddBranch(text_branchName.Text);
            }
        }

        private void cmb_teacherBranch_dropdown(object sender, EventArgs e)
        {   
            List<Branch> branches = _admin.GetBranches();
            
            cmb_teacherBranch.DisplayMember = "Name"; 
            cmb_teacherBranch.ValueMember = "ID"; 
            
            foreach (var branch in branches)
            {   
                Console.WriteLine(branch.Name);
                cmb_teacherBranch.Items.Add(branch);
            }
        }

        private void btn_registerTeacher_Click(object sender, EventArgs e)
        {   
            Branch branch = (Branch)cmb_teacherBranch.SelectedItem;
            var selectedBranch = branch.Id;
            if (text_teacherName!=null && text_teacherSurname!=null)
            {
                if (selectedBranch > 0)
                {   
                    Console.WriteLine(text_classID.Text);
                    _admin.RegisterTeacher(text_teacherName.Text, text_teacherSurname.Text, selectedBranch);
                }
                else
                {
                    MessageBox.Show("Please select a branch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter an name/surname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_availableLessons_Click(object sender, EventArgs e)
        {
            DataTable dt = _admin.GetLessonsWithFalseStatus();
            dataGridView.DataSource = null;
            dataGridView.DataSource = dt;
        }

        private void btn_bookedLessons_Click(object sender, EventArgs e)
        {
            DataTable dt = _admin.GetLessonsWithTrueStatus();
            dataGridView.DataSource = null;
            dataGridView.DataSource = dt;
        }

        private void btn_unbookLessons_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_unbookID.Text) && int.TryParse(text_unbookID.Text, out int classId))
            {
                _admin.UnbookLesson(classId);
                MessageBox.Show("Class unbooked successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid Class ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_removeLessons_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_removeID.Text) && int.TryParse(text_removeID.Text, out int classId))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _admin.RemoveClass(classId);
                    MessageBox.Show("Class removed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Class ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_unbookID_Click(object sender, EventArgs e)
        {
            text_unbookID.Text = "";
            text_unbookID.ForeColor = SystemColors.WindowText;
        }

        private void text_removeID_Click(object sender, EventArgs e)
        {
            text_removeID.Text = "";
            text_removeID.ForeColor = SystemColors.WindowText;
        }

        private void text_unbookID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_unbookID.Text))
            {
                text_unbookID.Text = "Enter a Class ID.";
                text_unbookID.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void text_removeID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_removeID.Text))
            {
                text_removeID.Text = "Enter a Class ID.";
                text_removeID.ForeColor = SystemColors.InactiveCaption;
            }
        }
    }
}
