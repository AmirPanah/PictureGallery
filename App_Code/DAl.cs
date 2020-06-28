using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DAl
/// </summary>
public class DAl
{

    SqlConnection cnn;
    SqlCommand cmd;
    SqlDataAdapter da;
	public DAl()
	{
        cnn = new SqlConnection();
        cmd = new SqlCommand();
        da = new SqlDataAdapter();
        cmd.Connection = cnn;
        da.SelectCommand = cmd;
	}

    public void connect()
    {
        string cs = @"Server=.;Database=test;Integrated Security=True";
        cnn.ConnectionString = cs;
        cnn.Open();
    }
    public void disconnect()
    {
        cnn.Close();
    }
    public DataTable select(string sql)
    {
        connect();
        DataTable dt = new DataTable();
        cmd.CommandText = sql;
        da.Fill(dt);
        disconnect();
        return dt;
    }
    public DataRow selectRow(string sql)
    {
        connect();
        DataRow dr;
        DataTable dt = new DataTable();
        cmd.CommandText = sql;
        da.Fill(dt);
        dr = dt.Rows[0];
        disconnect();
        return dr;

    }
    public DataColumn SelectColumn(string sql)
    {
        DataTable dt = new DataTable();
        DataColumn dc = new DataColumn();
        cmd.CommandText = sql;
        da.Fill(dt);
        dc = dt.Columns[0];
        return dc;
    }

    public SqlDataReader Reader(string sql)
    {
        cmd.CommandText = sql;
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public void docommand(SqlCommand cmd)
    {
        cmd.ExecuteNonQuery();
    }
    public void docommand(string sql)
    {
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public string GetOneString(string sql)
    {
        string Answer = "";
        cmd.CommandText = sql;
        object ob = cmd.ExecuteScalar();
        if (ob == DBNull.Value)
        {
            Answer = "";
        }
        else
        {
            Answer = Convert.ToString(ob);
        }
        return Answer;
    }
    public int GetOneInt(string sql)
    {
        int Answer;
        cmd.CommandText = sql;
        object ob = cmd.ExecuteScalar();
        Answer = Convert.ToInt32(ob);
        return Answer;
    }
    public bool GetOneBool(string sql)
    {
        bool Answer;
        cmd.CommandText = sql;
        object ob = cmd.ExecuteScalar();
        Answer = Convert.ToBoolean(ob);
        return Answer;
    }

}