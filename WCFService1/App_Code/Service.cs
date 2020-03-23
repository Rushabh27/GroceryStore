using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public DataSet getcat()
	{
        DataSet ds = new DataSet();
       
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=store;Integrated Security=True;Pooling=False");
            string Query = "SELECT * FROM Category";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.Fill(ds,"category");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

        return ds;
    }
    public DataSet getPro()
    {
        
        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=store;Integrated Security=True;Pooling=False");
            string Query = "SELECT * FROM Products";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.Fill(ds, "product");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

        return ds;
    }
    public DataSet getUsr()
    {

        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=store;Integrated Security=True;Pooling=False");
            string Query = "SELECT * FROM register";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.Fill(ds, "login");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

        return ds;
    }
    public void getReg(String u,String e,String p)
    {

        //DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=store;Integrated Security=True;Pooling=False");
            string Query = "insert into register(uname,email,password)values(@uname,@email,@password)";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@uname", u);
            cmd.Parameters.AddWithValue("@email", e);
            cmd.Parameters.AddWithValue("@password", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
         //   SqlDataAdapter sda = new SqlDataAdapter(Query, con);
          //  sda.Fill(ds, "register");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }
    }
    public void Inorder(String oname, String oimage, int weight,int price,int pid,int cid)
    {

        //DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=store;Integrated Security=True;Pooling=False");
            string Query = "insert into [Order](oname,oimage,weight,price,pid,cid)values(@oname,@oimage,@weight,@price,@pid,@cid)";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@oname", oname);
            cmd.Parameters.AddWithValue("@oimage", oimage);
            cmd.Parameters.AddWithValue("@weight", weight);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@cid", cid);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //   SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            //  sda.Fill(ds, "register");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }
    }
    public DataSet getOrder()
    {

        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=store;Integrated Security=True;Pooling=False");
            string Query = "SELECT * FROM [Order]";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.Fill(ds, "order");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

        return ds;
    }
    public void delOrder(int id)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=store;Integrated Security=True;Pooling=False");
            string Query = "delete from [Order] where oid="+id;
            SqlCommand cmd = new SqlCommand(Query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            //sda.Fill(ds, "order");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }
    }
}
