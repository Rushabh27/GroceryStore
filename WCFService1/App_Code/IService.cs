using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    [OperationContract]
    DataSet getcat();
    [OperationContract]
    DataSet getPro();
    [OperationContract]
    DataSet getUsr();
    [OperationContract]
    void getReg(String u, String e, String p);
    [OperationContract]
    void Inorder(String oname, String oimage, int weight, int price, int cid, int pid, int qwt);
    [OperationContract]
    DataSet getOrder();
    [OperationContract]
    void delOrder(int id);

    // TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
    public class CompositeType
    {
        int cid,pid;
        string cname,pname;

        [DataMember]
        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        [DataMember]
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
    [DataMember]
    public int Pid
    {
        get { return pid; }
        set { pid = value; }
    }
    [DataMember]
    public String Pname
    {
        get { return pname; }
        set { pname = value; }
    }
}
