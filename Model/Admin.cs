
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem.Model
{
    public class Admin : User
    {
        private string _constring =
            "Data Source=DESKTOP-C1H7OBF\\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True";

        public Admin(int id, string name, string surname) : base(id, name, surname)
        {
        }
        
        public List<Branch> GetBranches()
        {
            List<Branch> branches = new List<Branch>();
            SqlConnection connection = null;
            string query = "SELECT ID, Name FROM tbl_branchs";

            branches.Add(new Branch(0, "--Select a Branch--"));
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (connection != null) connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int branchId = Convert.ToInt32(reader["ID"]);
                            string branchName = reader["Name"].ToString();
                            Branch branch = new Branch(branchId, branchName);
                            branches.Add(branch);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection?.Close();
            }

            return branches;
        }

        public List<Teacher> GetTeachersByBranchId(int branchId)
        {
            List<Teacher> teachers = new List<Teacher>();
            SqlConnection connection = null;
            string query = "SELECT ID, Name, Surname, branch_id FROM tbl_teacher WHERE branch_id = @BranchId";

            teachers.Add(new Teacher(0, "--Select a Teacher--", "", 0));
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BranchId", branchId);

                        if (connection != null) connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int teacherId = Convert.ToInt32(reader["ID"]);
                            string teacherName = reader["Name"].ToString();
                            string teacherSurname = reader["Surname"].ToString();
                            Teacher teacher = new Teacher(teacherId, teacherName, teacherSurname, branchId);
                            teachers.Add(teacher);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection?.Close();
            }

            return teachers;
        }

        public void CreateLesson(int branchİd, int teacherİd, string date, string time)
        {
            SqlConnection connection = null;
            string query = "SELECT COUNT(*) FROM tbl_class WHERE teacher_id = @teacher_id AND date = @date AND time = @time";
            try
            {   
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {   
                        command.Parameters.AddWithValue("@teacher_id", teacherİd);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@time", time);

                        connection.Open();
                        int existingCount = (int)command.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            MessageBox.Show("This teacher already has a class at the specified date and time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        query = "INSERT INTO tbl_class (branch_id, teacher_id, date, time) VALUES (@p1, @p2, @p3, @p4)";
                        command.CommandText = query;
                        command.Parameters.Clear(); 
                        command.Parameters.AddWithValue("@p1", branchİd);
                        command.Parameters.AddWithValue("@p2", teacherİd);
                        command.Parameters.AddWithValue("@p3", date);
                        command.Parameters.AddWithValue("@p4", time);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Class is created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            SqlConnection connection = null;
            string query = "SELECT ID, Name, Surname FROM tbl_students";

            students.Add(new Student(0, "--Select a Student--"," "));
            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (connection != null) connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int stdId = Convert.ToInt32(reader["ID"]);
                            string stdName = reader["Name"].ToString();
                            string stdSurname = reader["Surname"].ToString();
                            Student std = new Student(stdId, stdName,stdSurname);
                            students.Add(std);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection?.Close();
            }

            return students;
        }

        public void AddStdToLesson(int ıd, int studentİd)
        {
            SqlConnection connection = null;
            string getStatusQuery = "SELECT status FROM tbl_class WHERE ID = @ID";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand statusCommand = new SqlCommand(getStatusQuery, connection))
                    {
                        statusCommand.Parameters.AddWithValue("@ID", ıd);

                        if (connection != null) connection.Open();
                        object result = statusCommand.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            bool status = (bool)result;

                            if (status)
                            {
                                MessageBox.Show("This class is already full.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; 
                            }
                        }
                    }
                    
                    string query = "UPDATE tbl_class SET student_id = @student_id, status = 'true' WHERE ID = @ID AND status = 'false'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", studentİd);
                        command.Parameters.AddWithValue("@ID", ıd);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student added to the class.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string updateStatusQuery = "UPDATE tbl_class SET status = 'true' WHERE ID = @ID";
                            using (SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection))
                            {
                                updateStatusCommand.Parameters.AddWithValue("@ID", ıd);
                                updateStatusCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This class is already full.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public void RegisterStudent(string name, string surname, string classroom, string phone, string mail)
        {
            SqlConnection connection = null;
            
            string query = "INSERT INTO tbl_students (Name, Surname, Classroom, Phone, Mail) VALUES (@Name, @Surname, @Classroom, @Phone, @Mail)";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);
                        command.Parameters.AddWithValue("@Classroom", classroom);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Mail", mail);

                        if (connection != null) connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Student registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        
        public void AddBranch(string name)
        {
            SqlConnection connection = null;
            string query = "INSERT INTO tbl_branchs (Name) VALUES (@Name)";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        if (connection != null) connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Branch added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add branch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public void RegisterTeacher(string name, string surname, int branchİd)
        {
            SqlConnection connection = null;
            
            string query = "INSERT INTO tbl_teacher (Name, Surname, branch_id) VALUES (@Name, @Surname, @branch_id)";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);
                        command.Parameters.AddWithValue("@branch_id", branchİd);

                        if (connection != null) connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Teacher registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        
        public DataTable GetLessonsWithFalseStatus()
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
        
        public DataTable GetLessonsWithTrueStatus()
        {
            DataTable classesWithTrueStatus = new DataTable();
            SqlConnection connection = null;

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand("LessonsTrue", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (connection != null) connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(classesWithTrueStatus);
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

            return classesWithTrueStatus;
        }

        public void UnbookLesson(int classId)
        {
            SqlConnection connection = null;
            string updateQuery = "UPDATE tbl_class SET student_id = NULL, status = 'false' WHERE ID = @ClassId";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ClassId", classId);

                        if (connection != null) connection.Open();
                        command.ExecuteNonQuery();
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
        
        public void RemoveClass(int classId)
        {
            SqlConnection connection = null;
            string query = "DELETE FROM tbl_class WHERE ID = @ID";

            try
            {
                using (connection = new SqlConnection(_constring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", classId);

                        if (connection != null) connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Class deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Class could not be deleted.");
                        }
                    }
                }
            }
            catch (Exception e)
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