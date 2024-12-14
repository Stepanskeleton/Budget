using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace proga;
    public class db_control
    {
        public string dbPath;
        public db_control(string path = "test.db")
        {
            dbPath = path;
        }

        /// <summary>
        /// Получение всех записей из таблицы
        /// </summary>
        /// <param name="paramsCount">Количество полей таблицы</param>
        /// <param name="data">Список записей из таблицы</param>
        /// <param name="tableName">Название таблицы в базе</param>
        /// <returns></returns>
        public Boolean GetEntireTable(int paramsCount,
                                      out List<string[]> data,
                                      string tableName)
        {
            Boolean result = true;
            data = new List<string[]>();
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                var sqlQuery = $"SELECT * FROM {tableName}";
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string[] str = new string[paramsCount];
                                for (int i = 0; i < str.Length; i++)
                                {
                                    str[i] = reader.GetValue(i).ToString();
                                }
                                data.Add(str);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                    result = false;
                }
            }
            return result;
        }


        /// <summary>
        /// Получение всех записей из таблицы в виде объекта DataTable
        /// </summary>
        /// <param name="paramsCount">Количество полей таблицы</param>
        /// <param name="Ex">Ошибка выполнения</param>
        /// <param name="data">Список записей из таблицы </param>
        /// <param name="tableName">Название таблицы в базе</param>
        /// <returns></returns>
        public Boolean GetEntireDataTable(int paramsCount,
                                          out DataTable data,
                                          string tableName)
        {
            bool res = true;
            using (var connection = new SqliteConnection("Data Source=" + dbPath))
            {
                connection.Open();
                try
                {
                    using (SqliteCommand command = new SqliteCommand($"SELECT * FROM {tableName}", connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            data = new DataTable();
                            data.Load(reader);
                        }
                    }
                }
                catch (Exception e)
                {
                    res = false;
                    throw;
                }
            }
            return res;
        }


        /// <summary>
        /// Получение всех записей из таблицы с константным фильтром по одному параметру
        /// </summary>
        /// <param name="paramsCount">Количество полей таблицы</param>
        /// <param name="data">Список записей из таблицы</param>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="FilterFieldName">Названия поля-фильтра</param>
        /// <param name="FilterFieldValue">Значение поля-фильтра</param>
        /// <returns></returns>
        public Boolean GetEntireTable(int paramsCount,
                                      out List<string[]> data,
                                      string tableName,
                                      string filterFieldName,
                                      string filterFieldValue)
        {
            Boolean result = true;
            data = new List<string[]>();
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                var sqlQuery = $"SELECT * FROM {tableName} WHERE {filterFieldName} = {filterFieldValue}";
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string[] str = new string[paramsCount];
                                for (int i = 0; i < str.Length; i++)
                                {
                                    str[i] = reader.GetValue(i).ToString();
                                }
                                data.Add(str);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                    result = false;
                }
            }
            return result;
        }
        public Boolean Get(out Exception res,
                           out List<string[]> data,
                           string sqlQuery = "SELECT * FROM Users")
        {
            Boolean result = true;
            data = new List<string[]>();
            Exception tmp = new Exception();
            using (var connection = new SqliteConnection("Data Source=" + dbPath))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var id = reader.GetValue(0).ToString();
                                var name = reader.GetValue(1).ToString();
                                var age = reader.GetValue(2).ToString();
                                string[] str = new string[]
                                {
                                    id, name, age
                                };
                                data.Add(str);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    tmp = ex;
                    result = false;
                }
            }
            res = tmp;
            return result;
        }

        /// <summary>
        /// Простое удаление записей из таблицы с фильтром
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="deletedField">Поле, по которому фильтруются данные</param>
        /// <param name="deletedValue">Значение поля, по которому фильтруются данные</param>
        /// <returns></returns>
        public Boolean Delete(string tableName,
                              string deletedField,
                              string deletedValue)
        {
            Boolean result = true;
            Exception tmp = new Exception();
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                //формирование запроса
                var sqlQuery = $"DELETE FROM {tableName} WHERE {deletedField} = '{deletedValue}'";
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    result = false;
                    throw;
                }
                return result;
            }
        }

        /// <summary>
        /// Изменяет значение всех полей в таблице
        /// </summary>
        /// <param name="Ex">Ошибка выполнения</param>
        /// <param name="tableName">Название изменяемой таблицы</param>
        /// <param name="updatedField">Изменяемое поле</param>
        /// <param name="newValue">Новое значение изменяяемого поля</param>
        /// <returns></returns>
        public Boolean UpdateValue(string tableName,
                                   string updatedField,
                                   string newValue)
        {
            Boolean result = true;
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                //формирование запроса
                var sqlQuery = $"UPDATE {tableName} SET {updatedField} = {newValue}";
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    result = false;
                    throw;
                }
                return result;
            }
        }


        /// <summary>
        /// Изменяет значение полей в таблице
        /// </summary>
        /// <param name="Ex">Ошибка выполнения</param>
        /// <param name="tableName">Название изменяемой таблицы</param>
        /// <param name="filterFieldName">Поле, по которому отбираются изменяемые записи</param>
        /// <param name="filterFieldValue">Значение поля, по которому отбираются изменяемые записи</param>
        /// <param name="updatedField">Изменяемое поле</param>
        /// <param name="newValue">Новое значение изменяяемого поля</param>
        /// <returns></returns>
        public Boolean UpdateFilteredValue(string tableName,
                                   string filterFieldName,
                                   string filterFieldValue,
                                   string updatedField,
                                   string newValue)
        {
            Boolean result = true;
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                //формирование запроса
                var sqlQuery = $"UPDATE {tableName} SET {updatedField} = {newValue} WHERE {filterFieldName} = '{filterFieldValue}'";
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    result = false;
                    throw;
                }
                return result;
            }
        }


        /// <summary>
        /// Добавляет запись в таблицу
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="fields">Поля таблицы</param>
        /// <param name="values">Значения полей таблицы</param>
        /// <returns></returns>
        public Boolean AddValue(string tableName,
                                string[] fields,
                                string[] values)
        {
            Boolean result = true;
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                //формирование запроса
                var sqlQuery = $"INSERT INTO {tableName} (";
                for (int i = 0; i < fields.Length; i++)
                {
                    sqlQuery += (i == fields.Length - 1) ? (fields[i] + ") ") : (fields[i] + ", ");
                }
                sqlQuery += "VALUES (";
                for (int i = 0; i < values.Length - 1; i++)
                {
                    sqlQuery += (i == values.Length) ? (values[i] + ") ") : (values[i] + ", ");
                }
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    result = false;
                    throw;
                }
                return result;
            }
        }

        /// <summary>
        /// Выполнение запроса к базе 
        /// </summary>
        /// <param name="sqlQuery">SQL-запрос</param>
        /// <returns></returns>
        public Boolean Execute(string sqlQuery)
        {
            bool result = true;
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw;
                    result = false;
                }
            }
            return result;
        }
    }
