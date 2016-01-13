using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using MySql.Data.MySqlClient;
using System.Xml;
using MySql.Data;

namespace zhwlWinFormToolBox
{
    class Connection
    {
                //连接用的字符串  
        private string connStr;
        public string ConnStr
        {
            get { return this.connStr; }
            set { this.connStr = value; }
        }

        private Connection()
        {
            connStr = @"server=121.42.154.95; user id=zhhwl; password=zhhwl; database=zhhwl.com;Charset=utf8;";
        }

        //DbManager单实例  
        private static Connection _instance = null;
        public static Connection Ins
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Connection();
                }
                return _instance;
            }
        }


        /// <summary>     
        /// 执行一条计算查询结果语句，返回查询结果（object）。     
        /// </summary>     
        /// <param name="SQLString">计算查询结果语句</param>     
        /// <returns>查询结果（object）</returns>     
        public object ExecuteScalar(string SQLString, params MySqlParameter[] paras)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        if (paras != null)
                        {
                            cmd.Parameters.AddRange(paras);
                        }
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (MySql.Data.MySqlClient.MySqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>  
        /// 执行Update,Delete,Insert操作  
        /// </summary>  
        /// <param name="sql"></param>  
        /// <returns></returns>  
        public int ExecuteNonquery(string sql, params MySqlParameter[] paras)
        {
            using (MySqlConnection con = new MySqlConnection(ConnStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>  
        /// 获得单个结果集时使用该方法，返回DataTable对象。  
        /// </summary>  
        /// <param name="sql"></param>  
        /// <returns></returns>  

        public DataTable ExcuteDataTable(string sql, params MySqlParameter[] paras)
        {
            using (MySqlConnection con = new MySqlConnection(ConnStr))
            {
                MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, con);
                if (paras != null)
                {
                    sqlda.SelectCommand.Parameters.AddRange(paras);
                }
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }
        }
    }
}
