using System;
using System.Data;
using System.Data.SqlClient;

namespace NCP.DataAccessLayer.SqlProvider
{
    public class DbHelper
    {
        //private static string ConnectionString
        //{
        //    get
        //    { return "server=127.0.0.1; database=FCPDB; uid=sa; pwd=123"; }
        //}
        private SqlConnection Conn { get; set; }
        private SqlCommand Cmd { get; set; }
        private SqlTransaction Tran { get; set; }

        private static DbHelper _DBHelper;
        private DbHelper(string ConnStr)
        {
            this.Conn = new SqlConnection(ConnStr);
            this.Cmd = new SqlCommand();
            this.Cmd.Connection = this.Conn;
        }
        public static DbHelper CreateDBHelper(string ConnStr)
        {
            _DBHelper = _DBHelper ?? new DbHelper(ConnStr);

            if (_DBHelper.Conn.ConnectionString != ConnStr)
                _DBHelper = new DbHelper(ConnStr);

            return _DBHelper;
        }

        private void OpenConnection()
        {
            if (this.Conn.State == ConnectionState.Closed)
                this.Conn.Open();
        }

        private void CloseConnection()
        {
            if (this.Conn.State == ConnectionState.Open)
                this.Conn.Close();
        }

        public void ClearParemeters()
        {
            this.Cmd.Parameters.Clear();
        }

        public void AddParameter(string Key, object Val)
        {
            if (this.Cmd.Parameters.Contains(Key))
                this.Cmd.Parameters[Key].Value = Val;
            else
                this.Cmd.Parameters.AddWithValue(Key, Val);
        }

        public void BeginTran()
        {
            OpenConnection();
            Tran = Conn.BeginTransaction();
            Cmd.Transaction = Tran;
        }

        public void CommitTran()
        {
            Tran.Commit();
            Tran = null;
            CloseConnection();
        }

        private void RollbackTran()
        {
            Tran.Rollback();
            Tran = null;
            CloseConnection();
        }

        public int ExecuteMethod(string Query, bool IsTransaction, bool IsProc)
        {
            try
            {
                //this.Conn.ConnectionString = this.ConnectionString;
                this.Cmd.CommandText = Query;
                if (!IsTransaction)
                    this.OpenConnection();
                if (IsProc)
                    Cmd.CommandType = CommandType.StoredProcedure;
                else
                    Cmd.CommandType = CommandType.Text;
                return this.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (IsTransaction)
                    RollbackTran();
                return -1;
            }
            finally
            {
                if (IsProc)
                    Cmd.CommandType = CommandType.Text;
                if (!IsTransaction)
                    this.CloseConnection();
            }
        }

        public DataTable ReaderMethod(string Query, bool Isproc)
        {
            try
            {
                if (Isproc)
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = Query;
                }
                else
                    this.Cmd.CommandText = Query;
                this.OpenConnection();
                DataTable dt = new DataTable();
                SqlDataReader dr = this.Cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
