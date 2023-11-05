using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Model
{
    public class Teacher : User
    {   
        private string _constring =
            "Data Source=DESKTOP-C1H7OBF\\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True";
        public int branchİd { get; set; }
        public Teacher(int id, string name, string surname, int branchİd) : base(id, name, surname)
        {
            this.branchİd = branchİd;
        }
        
        public Teacher(int id, string name, string surname) : base(id, name, surname)
        {
        }

        public DataTable GetBookedLessons(int teacher_id)
        {
            DataTable lessonsBooked = new DataTable();
            SqlConnection connection = null;

            string query = "SELECT tbl_class.ID, tbl_branchs.Name AS Branch, CONCAT(tbl_students.Name, ' ', tbl_students.Surname) AS Student, tbl_class.date as Date, tbl_class.time as Time " +
                           "FROM tbl_class JOIN tbl_branchs ON tbl_class.branch_id = tbl_branchs.ID JOIN tbl_students ON tbl_class.student_id = tbl_students.ID WHERE tbl_class.status = 'true' AND tbl_class.teacher_id = @teacher_id;";
    
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacher_id", teacher_id);
                        if (connection != null) connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(lessonsBooked);
                    }
                }

                if (lessonsBooked.Rows.Count == 0)
                {
                    MessageBox.Show("Your lessons have not been taken yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection?.Close();
            }

            return lessonsBooked;
        }

        public DataTable GetRemainingLessons(int teacher_id)
        {
            DataTable remainingLessons = new DataTable();
            SqlConnection connection = null;

            string query = "SELECT * FROM tbl_class WHERE teacher_id = @teacher_id AND status = 'false';";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacher_id", teacher_id);
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(remainingLessons);
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection?.Close();
            }

            return remainingLessons;
        }

        public void CancelClass(int teacher_id, int class_id)
        {
            SqlConnection connection = null;
            try
            {
                string query = "DELETE FROM tbl_class WHERE teacher_id = @teacher_id AND ID = @class_id;";

                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacher_id", teacher_id);
                        command.Parameters.AddWithValue("@class_id", class_id);
                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
