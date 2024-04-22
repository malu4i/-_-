using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_Будянська
{
    public class Data
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;";
        public static int id_num { get; set; }
        public List<int> works { get; set; }
        public static DateTime dateTime { get; set; }

        public static string con { get; set; }

        public void newData() 
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "MDF files (*.mdf)|*.mdf|All files (*.*)|*.*";
                saveFileDialog.Title = "Выберите место сохранения файла MDF";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    try
                    {
                        string mdfFilePath = saveFileDialog.FileName;

                        // Получаем имя файла без расширения
                        string databaseName = System.IO.Path.GetFileNameWithoutExtension(mdfFilePath);

                        // Создание строки подключения для мастер-базы данных
                        SqlConnectionStringBuilder masterConnBuilder = new SqlConnectionStringBuilder(ConnectionString);




                        // Рядок підключення для створення нового MDF-файлу
                        string masterConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";

                        // Запит для створення нового MDF-файлу
                        string createDatabaseQuery = $"CREATE DATABASE {databaseName} ON PRIMARY (NAME = {databaseName}, FILENAME = '{mdfFilePath}');";

                        // Виконати запит на створення бази даних
                        using (SqlConnection connection = new SqlConnection(masterConnectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }

                            connection.Close();
                        }

                        // Рядок підключення до нового MDF-файлу
                        string databaseConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={mdfFilePath};Integrated Security=True";

                        // Запити для створення таблиць
                        string createEmployeesTableQuery = @"
                        IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Employees')
                        BEGIN
                            CREATE TABLE Employees (
                                EmployeeID INT IDENTITY (1, 1) NOT NULL,
                                FirstName NVARCHAR(50) NOT NULL,
                                LastName NVARCHAR(50) NOT NULL,
                                BirthDate DATE NOT NULL,
                                Position NVARCHAR(50) NOT NULL,
                                Phone VARCHAR(16) NULL,
                                DayRate DECIMAL(10, 2) NOT NULL,
                                PRIMARY KEY CLUSTERED (EmployeeID ASC)
                            );
                        END
                    ";

                        string createSalaryInfoTableQuery = @"
                        IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SalaryInfo')
                        BEGIN
                            CREATE TABLE SalaryInfo (
                                SalaryID INT IDENTITY (1, 1) NOT NULL,
                                DaysPerMonth INT NOT NULL,
                                EmployeeID INT NOT NULL,
                                Salary DECIMAL(10, 2) NOT NULL,
                                Bonus DECIMAL(10, 2) NULL,
                                PRIMARY KEY CLUSTERED (SalaryID ASC),
                                FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID)
                            );
                        END
                    ";

                        string createScheduleTableQuery = @"
                        IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Schedule')
                        BEGIN
                            CREATE TABLE Schedule (
                                ScheduleID INT IDENTITY (1, 1) NOT NULL,
                                EmployeeID INT NOT NULL,
                                Date DATE NOT NULL,
                                PRIMARY KEY CLUSTERED (ScheduleID ASC),
                                FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID)
                            );
                        END
                    ";

                        // Виконати запити на створення таблиць в новій базі даних
                        using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(createEmployeesTableQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }


                            using (SqlCommand command = new SqlCommand(createSalaryInfoTableQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }


                            using (SqlCommand command = new SqlCommand(createScheduleTableQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }

                            connection.Close();
                        }
                        Data.con = databaseConnectionString;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}");
                    }



                }
            }
        }
        public void openData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Установка свойств OpenFileDialog
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*";

            // Отображение диалогового окна и обработка результата
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Получение пути к выбранному файлу
                string selectedFilePath = openFileDialog.FileName;
                string databaseConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={selectedFilePath};Integrated Security=True";

                Data.con = databaseConnectionString;
            }
        }
        public void logOut()
        {

        }
    }
   
}
