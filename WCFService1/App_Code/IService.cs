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

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        int cid;
        string cname;

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
    }
