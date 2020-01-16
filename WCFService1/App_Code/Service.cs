using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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

    
}
