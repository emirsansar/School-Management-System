using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem.View;

public partial class StudentGuı : Form
{
    private Student _student;
    public StudentGuı(Student student)
    {
        InitializeComponent();

        this._student = student;
    }
    
    private void StudentGUI_Load(object sender, EventArgs e)
    {
        Greeting();
    }
    
    private void Greeting()
    {   
        lbl_greeting.Text = $"Welcome, Dear {_student.FullName}";
    }
    
    private void btn_showAvailableLessons_Click(object sender, EventArgs e)
    {
        DataTable dt = _student.GetClassesWithFalseStatus();
        dataGridView_std.DataSource = null;
        dataGridView_std.DataSource = dt;
    }


    private void btn_showBookedLessons_Click(object sender, EventArgs e)
    {
        DataTable dt = _student.GetBookedLessons(_student.Id);
        dataGridView_std.DataSource = null;
        dataGridView_std.DataSource = dt;
    }

    private void btn_bookLesson_Click(object sender, EventArgs e)
    {   
        if (!string.IsNullOrEmpty(text_lessonID.Text) && int.TryParse(text_lessonID.Text, out int lessonId))
        {   
            Console.WriteLine(lessonId);
            Console.WriteLine(_student.Id);
            _student.BookLesson(lessonId, _student.Id);
        }
        else
        {
            MessageBox.Show("Please enter a valid Lesson ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void text_lessonID_Click(object sender, EventArgs e)
    {
        text_lessonID.Text = "";
        text_lessonID.ForeColor = SystemColors.WindowText;
    }
    
    private void text_lessonID_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(text_lessonID.Text))
        {
            text_lessonID.Text = "Enter a Class ID.";
            text_lessonID.ForeColor = SystemColors.InactiveCaption;
        }
    }
    
}