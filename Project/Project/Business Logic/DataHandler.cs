using System;
using System.Data;
using System.Data.SqlClient;

namespace Project.Business_Logic
{
    class DataHandler
    {
        private string connectionString = @"Data Source=DESKTOP-28E4QD1\SQLEXPRESS;Initial Catalog=BelgiumCampus_Students;Integrated Security=True";

        public DataHandler() { }

        private SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                connection.Close();

                return dataTable;
            }
        }

        public void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable GetData(string table)
        {
            string query = "SELECT * FROM " + table;
            return ExecuteQuery(query, null);
        }

        public string GetValue(string id, string category, string table)
        {
            string query = "SELECT " + category + " FROM " + table + " WHERE ID = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", id) };
            DataTable result = ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }

        public void InsertStudent(int id, string name, string surname, string dob, string gender, string phone, string address, string modulecode, string modulename, string moduleDesc, string link, byte[] imagedata)
        {
            string query = "INSERT INTO BC_Students (StudentID, Name, Surname, DOB, Gender, Phone, Address, ModuleCode, Modulename,  ModuleDesc, Link, imagedata) " +
                           "VALUES (@StudentID, @Name, @Surname, @DOB, @Gender, @Phone, @Address, @ModuleCode, @Modulename, @ModuleDesc, @Link, @imagedata)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@StudentID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Surname", surname),
                new SqlParameter("@DOB", dob),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address),
                new SqlParameter("@ModuleCode", modulecode),
                new SqlParameter("@Modulename", modulename),
                new SqlParameter("@ModuleDesc", moduleDesc),
                new SqlParameter("@Link", link),
                new SqlParameter("@imagedata", imagedata)
            };

            ExecuteNonQuery(query, parameters);
        }

        public void UpdateStudent(int id, string name, string surname, string dob, string gender, string phone, string address, string modulecode, string modulename, string moduleDesc, string link, byte[] imagedata)
        {
            string query = "UPDATE BC_Students " +
                           "SET Name = @Name, Surname = @Surname, DOB = @DOB, Gender = @Gender, Phone = @Phone, Address = @Address, ModuleCode = @ModuleCode, modulename = @Modulename, moduleDesc = @ModuleDesc, link = @Link, imagedata= @imagedata " +
                           "WHERE StudentID = @StudentID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@StudentID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Surname", surname),
                new SqlParameter("@DOB", dob),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address),
                new SqlParameter("@ModuleCode", modulecode),
                new SqlParameter("@Modulename", modulename),
                new SqlParameter("@ModuleDesc", moduleDesc),
                new SqlParameter("@Link", link),
                new SqlParameter("@imagedata", imagedata)
            };

            ExecuteNonQuery(query, parameters);
        }

        public void DeleteData(string id)
        {
            string query = "DELETE FROM BC_Students WHERE StudentID = @StudentID";
            SqlParameter[] parameters = { new SqlParameter("@StudentID", id) };
            ExecuteNonQuery(query, parameters);
        }

        public DataTable SearchStudent(int id)
        {
            string query = "SELECT * FROM BC_Students WHERE StudentID = @StudentID";
            SqlParameter[] parameters = { new SqlParameter("@StudentID", id) };
            return ExecuteQuery(query, parameters);
        }
        public DataTable SearchStudentByName(string name)
        {
            string query = "SELECT * FROM BC_Students WHERE Name LIKE @Name";
            SqlParameter[] parameters = { new SqlParameter("@Name", "%" + name + "%") };
            return ExecuteQuery(query, parameters);
        }
    }
}
