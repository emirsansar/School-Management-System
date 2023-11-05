using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SchoolManagementSystem.Model;
using System.Threading;

namespace SchoolManagementSystem.View
{
    public partial class LoginGuı : Form
    {
        private Thread _thread;
        string _constring = "Data Source=DESKTOP-C1H7OBF\\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True";
        public LoginGuı()
        {
            InitializeComponent();
        }
        
        private void btn_adminLogin(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    if (connection != null)
                    {
                        connection.Open();

                        string query =
                            "SELECT ID, Name, Surname FROM tbl_admin WHERE username = @username AND password = @password";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", text_adminUsername.Text);
                        command.Parameters.AddWithValue("@password", text_adminPass.Text);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int adminId = reader.GetInt32(0);
                            string adminName = reader.GetString(1);
                            string adminSurname = reader.GetString(2);

                            Admin admin = new Admin(adminId, adminName, adminSurname);
                            AdminGuı adminGui = new AdminGuı(admin);
                            adminGui.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or password is wrong. Try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
        
        private void btn_teacherLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    if (connection != null)
                    {
                        connection.Open();

                        string query =
                            "SELECT ID, Name, Surname FROM tbl_teacher WHERE username = @username AND password = @password";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", text_teacherUsername.Text);
                        command.Parameters.AddWithValue("@password", text_teacherPass.Text);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int teacherId = reader.GetInt32(0);
                            string teacherName = reader.GetString(1);
                            string teacherSurname = reader.GetString(2);

                            Teacher teacher = new Teacher(teacherId, teacherName, teacherSurname);
                            TeacherGUI teacherGUI = new TeacherGUI(teacher);
                            teacherGUI.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or password is wrong. Try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }


        private void button_studentLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    if (connection != null)
                    {
                        connection.Open();

                        string query =
                            "SELECT ID, Name, Surname FROM tbl_students WHERE username = @username AND password = @password";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", text_studentUsername.Text);
                        command.Parameters.AddWithValue("@password", text_studentPass.Text);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int stdId = reader.GetInt32(0);
                            string stdName = reader.GetString(1);
                            string stdSurname = reader.GetString(2);

                            Student student = new Student(stdId, stdName, stdSurname);
                            StudentGuı stdGuı = new StudentGuı(student);
                            stdGuı.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or password is wrong. Try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void LoginGUI_Load(object sender, EventArgs e)
        {
        }
        
    }
}
