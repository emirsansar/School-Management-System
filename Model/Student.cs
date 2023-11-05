using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Model
{   
    public class Student : User
    {
        private string _constring =
            "Data Source=DESKTOP-C1H7OBF\\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True";
        public Student(int id, string name, string surname) : base(id, name, surname)
        {
        }

        public DataTable GetClassesWithFalseStatus()
        {
            DataTable classesWithFalseStatus = new DataTable();
            SqlConnection connection = null;

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand("LessonsFalse", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (connection != null) connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(classesWithFalseStatus);
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

            return classesWithFalseStatus;
        }
        
        public DataTable GetBookedLessons(int studentİd)
        {
            DataTable classesWithTrueStatus = new DataTable();
            SqlConnection connection = null;

            string query = "SELECT tbl_class.ID, tbl_branchs.Name AS Branch, CONCAT(tbl_teacher.Name, ' ', tbl_teacher.Surname) AS Teacher, tbl_class.date as Date, tbl_class.time as Time " +
                           "FROM tbl_class JOIN tbl_branchs ON tbl_class.branch_id = tbl_branchs.ID JOIN tbl_teacher ON tbl_class.teacher_id = tbl_teacher.ID WHERE tbl_class.status = 'true' AND tbl_class.student_id = @student_id;";
    
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", studentİd);
                        if (connection != null) connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(classesWithTrueStatus);
                    }
                }

                if (classesWithTrueStatus.Rows.Count == 0)
                {
                    MessageBox.Show("You have not booked any lesson.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            return classesWithTrueStatus;
        }

        public void BookLesson(int classİd, int studentİd)
        {
            SqlConnection connection = null;
            string selectQuery = "SELECT status FROM tbl_class WHERE ID = @class_id";
            string updateQuery = "UPDATE tbl_class SET student_id = @student_id, status = 'true' WHERE ID = @class_id";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@class_id", classİd);
                        if (connection != null) connection.Open();
                
                        var status = selectCommand.ExecuteScalar();
                        Console.WriteLine("Status Value: " + status);
                        if (status != null)
                        {   
                            string statusValue = status.ToString();
                            Console.WriteLine("Status Value2: " + statusValue);
                            if (statusValue == "False")
                            {   
                                Console.WriteLine("ok");
                                Console.Write(studentİd);
                                Console.WriteLine(classİd);
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@student_id", studentİd);
                                    updateCommand.Parameters.AddWithValue("@class_id", classİd);
                                    updateCommand.ExecuteNonQuery();
                                    MessageBox.Show("You booked the lesson successfully.", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Console.WriteLine("ok2");
                                    Console.Write(studentİd);
                                    Console.WriteLine(classİd);
                                }
                            }
                            else
                            {
                                MessageBox.Show("This lesson is already booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given Class ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        }
        
    }
}
