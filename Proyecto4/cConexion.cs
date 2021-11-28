using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
public class cConexion
{
    /*en esta parte se introduce la ruta de la base de datos. Usar el server, user ID, password y database*/
    const String var_ruta = "server=127.0.0.1;user id=root;password=gengen;persist security info=True;database=gimnasio";
    DataSet ds = new DataSet();
    MySql.Data.MySqlClient.MySqlConnection cnSQL = new MySql.Data.MySqlClient.MySqlConnection(var_ruta);
    MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand();

    public DataSet buscar(String strSQL, String tabla)
    {
        DataSet ds = new DataSet();
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter daSQL = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, cnSQL);
            daSQL.Fill(ds, tabla);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
        return ds;
    }
    public void operacion(String strsql)
    {
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmSQL = new MySql.Data.MySqlClient.MySqlCommand(strsql, cnSQL);
            cmSQL.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
    public double escalar_double(String strsql)
    {
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmsSQL = new MySql.Data.MySqlClient.MySqlCommand(strsql, cnSQL);
            return Convert.ToDouble(cmsSQL.ExecuteScalar());
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
    public String escalar_cadena(String strsql)
    {
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmsSQL = new MySql.Data.MySqlClient.MySqlCommand(strsql, cnSQL);
            return Convert.ToString(cmsSQL.ExecuteScalar());
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
    public Int64 valor(String strsql)
    {
        try
        {
            cnSQL.Open();
            MySql.Data.MySqlClient.MySqlCommand cmsSQL = new MySql.Data.MySqlClient.MySqlCommand(strsql, cnSQL);
            return Convert.ToInt64(cmsSQL.ExecuteScalar());
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnSQL.Close();
        }
    }
}
