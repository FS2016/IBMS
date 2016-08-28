using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FireAlarm
{
    class SDataHepler
    {
        private static string FLastError;
        /// <summary>
        /// 最近一次异常信息
        /// </summary>
        public static string LastError
        {
            get { return FLastError; }
        }
        /// 获取数据库连接字符串、子类覆盖后自行修改
        /// </summary>
        /// <returns>连接字符串</returns>
        private static string GetConnectionString()
        {
            string MyConn = "server=192.168.1.101,1433;uid=sa;pwd=123456;database=TEST;Trusted_Connection=no";//定义数据库连接参数
            //string MyConn = "Data Source=172.30.23.200,1433;Initial Catalog=data;User ID=sa;password=123456;Integrated Security=False"; 
            return MyConn;
        }

        
        /**
         * 如果存在该条记录就更新，如果不存在就插入
         * 
         * */
        public  static String  getGuid(String area,String point)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            Console.WriteLine("SELECT * FROM TEST.dbo.CCTV WHERE  Point=  '" + point + "'");
            SqlCommand comd = new SqlCommand("SELECT * FROM TEST.dbo.CCTV WHERE  Point=  '" + point + "'", conn); 
            SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
            conn.Open();
            DataSet MyDataSet = new DataSet();//定义一个数据集
            SqlDataReader reader = comd.ExecuteReader();
           VideoInfo v= new VideoInfo();
           String result = "";
            while (reader.Read())
            {
               // v.Area = reader.GetString(reader.GetOrdinal("area"));
               // v.Point = reader.GetString(reader.GetOrdinal("point"));
               // v.Guid = reader.GetString(reader.GetOrdinal("GUID"));
                result = reader.GetString(reader.GetOrdinal("DeviceID"));
                Console.Write("GUID =======" + reader.GetString(reader.GetOrdinal("DeviceID")));
                return result;
            }
            conn.Close();//关闭数据库
            return null;
        
        }


        public static void saveFirePointInfo(String pointId,String hostId,String time) {
            SqlConnection conn  = new SqlConnection(GetConnectionString()); ;
            try
            {
                SqlCommand comd = new SqlCommand("insert into TEST.dbo.FireAlarm(PointID,Type,Time,HostID) values('" + pointId + "','火警','" + time + "','" + hostId + "') ", conn);
                conn.Open();
                comd.ExecuteReader();
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally {
                conn.Close();//关闭数据库
            } 
            
        }


  
        /// <summary>
        /// 通用异常处理函数
        /// </summary>
        /// <param name="e">需要处理的异常</param>
        private static void HandleException(Exception e)
        {
            if (e is SqlException)
            {
                FLastError = string.Format("在打开连接时出现连接级别的错误:{0}", e.Message);
            }
            else if (e is InvalidOperationException)
            {
                FLastError = e.Message;
            }
            else if (e is DBConcurrencyException)
            {
                FLastError = string.Format("尝试执行 INSERT、UPDATE 或 DELETE 语句，但没有记录受到影响:{0}", e.Message);
            }
            else
            {
                FLastError = string.Format("未预料的异常:", e.Message);
            }
        }
        /// <summary>
    
        private static SqlConnection OpenConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
        /// <summary>
        /// 无返回值的SQL语句执行
        /// </summary>
        /// <param name="ASql">欲执行的SQL语句</param>
        /// <param name="AParams">参数集合</param>
        /// <returns>影响记录的行数</returns>
        public static int ExecNonSQL(string ASql, params SqlParameter[] AParams)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    //Open异常捕获
                    Conn.Open();
                    using (SqlCommand Cmd = Conn.CreateCommand())
                    {
                        Cmd.CommandText = ASql;
                        foreach (SqlParameter param in AParams)
                        {
                            Cmd.Parameters.Add(param);
                        }
                        return Cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }

            return -1;
        }

        /// <summary>
        /// 获得离线数据集合
        /// </summary>
        /// <param name="ASql">欲执行的SQL语句</param>
        /// <param name="AParams">与SQL相关的参数</param>
        /// <returns>返回查询结果集合</returns>
        public static DataSet ExecSQLByDataSet(string ASql, params SqlParameter[] AParams)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    Conn.Open();
                    using (SqlCommand Cmd = Conn.CreateCommand())
                    {
                        Cmd.CommandText = ASql;
                        foreach (SqlParameter param in AParams)
                        {
                            Cmd.Parameters.Add(param);
                        }
                        SqlDataAdapter Adapter = new SqlDataAdapter(Cmd);
                        DataSet Result = new DataSet();
                        Adapter.Fill(Result);
                        return Result;
                    }
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
            return null;
        }

        /// <summary>
        /// 将本地修改的结果集提交至服务器
        /// </summary>
        /// <param name="ADataSet">已修改的结果集合</param>
        public static void UpdateByDataSet(DataSet ADataSet)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnectionString()))
            {
                Conn.Open();
                using (SqlCommand Cmd = Conn.CreateCommand())
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter(Cmd);
                    new SqlCommandBuilder(Adapter);
                    Adapter.ContinueUpdateOnError = true;
                    try
                    {
                        Adapter.Update(ADataSet);
                    }
                    catch (Exception ex)
                    {
                        HandleException(ex);
                    }
                }
            }
        }

     
    }
}
