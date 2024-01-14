using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using VStay_Backend.Config;

namespace VStay_Backend.Dao
{
    public class DbClient : IDbClient
    {
        /// <summary>
        /// The connection string to database.
        /// </summary>
        public readonly string ConnectionString = DatabaseConfig.GetConnectionString();

        public const string ExecStoredProcedureError = "Call stored procedure was an error.";

        public const string TotalRowsOuput = "TotalRows";

        /// <summary>
        /// Calls a query stored procedure that returns a table.
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure, which returns a table.</param>
        /// <param name="parameters">The parameters to pass to the stored procedure.</param>
        public DataTable CallQueryStoredProcedure(
            string storedProcedureName
        )
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                var dataTable = new DataTable();

                try
                {
                    using (var sqlCommand = new SqlCommand(storedProcedureName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlConnection.Open();

                        // Execute the stored procedure and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }

                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    sqlConnection.Close();
                }

                throw new Exception(ExecStoredProcedureError);
            }
        }

        /// <summary>
        /// Calls a query stored procedure that returns a table.
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure, which returns a table.</param>
        /// <param name="parameters">The parameters to pass to the stored procedure.</param>
        public DataTable CallQueryStoredProcedure(
            string storedProcedureName,
            IDictionary<string, object> parameters 
        )
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                var dataTable = new DataTable();

                try
                {
                    using (var sqlCommand = new SqlCommand(storedProcedureName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add the parameters to the command
                        foreach (var parameter in parameters)
                        {
                            sqlCommand.Parameters.AddWithValue(
                               // "@" + 
                                parameter.Key,
                                parameter.Value
                            );
                        }

                        sqlConnection.Open();

                        // Execute the stored procedure and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(dataTable);
                        }

                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    sqlConnection.Close();
                }

                throw new Exception(ExecStoredProcedureError);
            }
        }

        /// <summary>
        /// Calls a query stored procedure that returns a table.
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure, which returns a table.</param>
        /// <param name="parameters">The parameters to pass to the stored procedure.</param>
        public DataTable CallQueryStoredProcedure(
            string storedProcedureName,
            out long totalItems,
            IDictionary<string, object> parameters
        )
        {
            totalItems = 0;

            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                var dataTable = new DataTable();

                try
                {
                    using (var sqlCommand = new SqlCommand(storedProcedureName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add the parameters to the command
                        foreach (var parameter in parameters)
                        {
                            sqlCommand.Parameters.AddWithValue(
                                parameter.Key,
                                parameter.Value
                            );
                        }

                        sqlConnection.Open();

                        // Add output parameter
                        SqlParameter outputParam = new SqlParameter("@" + TotalRowsOuput, SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;
                        sqlCommand.Parameters.Add(outputParam);


                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            dataTable.Load(sqlDataReader);
                        }

                        totalItems = Convert.ToInt64(outputParam.Value);

                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    sqlConnection.Close();
                }

                throw new Exception(ExecStoredProcedureError);
            }
        }
    }
}
