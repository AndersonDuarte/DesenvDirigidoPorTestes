using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


class SqlServer
{
    public SqlServer()
    {
    }


    public DataTable select(string sql)
    {
        //string de conexão com o banco .mdf 
        string _conect = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Potz.mdf;Integrated Security=True;User Instance=True";

        //abrindo conexão com o banco
        SqlConnection conn = new SqlConnection(_conect);
        conn.Open();

        //criando o select e o objeto de consulta
        SqlCommand cmd = new SqlCommand(sql, conn);

        //Pegando valores e colocando no DataTable 
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        DataTable tabela = ds.Tables[0];
        conn.Close();
        return tabela;
    }

    public void insert(string sql)
    {
        //string de conexão com o banco .mdf 
        string _conect = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Potz.mdf;Integrated Security=True;User Instance=True";

        //abrindo conexão com o banco
        SqlConnection conn = new SqlConnection(_conect);
        conn.Open();

        //criando o select e o objeto de consulta
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public void update(string sql)
    {
        //string de conexão com o banco .mdf 
        string _conect = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Potz.mdf;Integrated Security=True;User Instance=True";

        //abrindo conexão com o banco
        SqlConnection conn = new SqlConnection(_conect);
        conn.Open();

        //criando o select e o objeto de consulta
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public void delete(string sql)
    {
        //string de conexão com o banco .mdf 
        string _conect = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Potz.mdf;Integrated Security=True;User Instance=True";

        //abrindo conexão com o banco
        SqlConnection conn = new SqlConnection(_conect);
        conn.Open();

        //criando o select e o objeto de consulta
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}
