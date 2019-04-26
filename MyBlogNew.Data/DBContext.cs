using Microsoft.Extensions.Configuration;
using MyBlogNew.Models;
using MyBlogNew.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace MyBlogNew.Data
{
    public class DBContext : IDisposable
    {
        private DbConnection dbConnection;
        private DbCommand dbCommand;
        public DBContext()
        {
            dbConnection = new SQLiteConnection(Config.Configuration.GetConnectionString("default"));
            dbConnection.Open();
            dbCommand = dbConnection.CreateCommand();
        }

        public DBContext AddParam(DbType dbType, string name, object value)
        {
            var parm = dbCommand.CreateParameter();
            parm.DbType = DbType.AnsiString;
            parm.Value = value;
            parm.ParameterName = name;
            dbCommand.Parameters.Add(parm);

            return this;
        }

        public DBContext SetSql(string sql)
        {
            dbCommand.CommandText = sql;
            dbCommand.CommandType = CommandType.Text;

            return this;
        }

        public List<T> Query<T>()
        {
            var list = dbCommand.ExecuteReader().ToModel<T>();
            dbCommand.Parameters.Clear();
            return list;
        }

        public int ExecuteNoQuery()
        {
            var r = dbCommand.ExecuteNonQuery();
            dbCommand.Parameters.Clear();
            return r;
        }

        public void Dispose()
        {
            dbConnection.Close();
        }
    }
}
