using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem.View;

public partial class TeacherGUI : Form
{
    private Teacher teacher;
    
    public TeacherGUI(Teacher teacher)
    {
        InitializeComponent();

        this.teacher = teacher;
    }
    
    private void TeacherGUI_Load(object sender, EventArgs e)
    {
        Greeting();
    }
    
    private void Greeting()
    {   
        lbl_greeting.Text = $"Welcome, Dear {teacher.FullName}";
    }
    
    private void btn_showTakenLessons_Click(object sender, EventArgs e)
    {
        DataTable dt = teacher.GetBookedLessons(teacher.Id);
        dataGridView_teacher.DataSource = null;
        dataGridView_teacher.DataSource = dt;
    }

    private void btn_remainingLessons_Click(object sender, EventArgs e)
    {
        DataTable dt = teacher.GetRemainingLessons(teacher.Id);
        dataGridView_teacher.DataSource = null;
        dataGridView_teacher.DataSource = dt;
    }

    private void btn_cancelLesson_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(text_lessonID.Text) && int.TryParse(text_lessonID.Text, out int lessonID))
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this lesson?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                teacher.CancelClass(teacher.Id, lessonID);
                MessageBox.Show("Lesson cancelled successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Please enter a valid Lesson ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void text_lessonID_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(text_lessonID.Text))
        {
            text_lessonID.Text = "Enter a Class ID.";
            text_lessonID.ForeColor = SystemColors.InactiveCaption;
        }
    }

    private void text_lessonID_Click(object sender, EventArgs e)
    {
        text_lessonID.Text = "";
        text_lessonID.ForeColor = SystemColors.WindowText;
    }
}