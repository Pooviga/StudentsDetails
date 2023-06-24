using StudentDetails.DataAccess;
using StudentDetails.Model;
using System.Data;

namespace StudentDetails.Rules
{
    public class clsDetailsTracker
    {
        private clsSql objSql=new clsSql();

        public bool AddDetails(CreateAttributes ca)
        {
            if(objSql.InsertDetails(ca)>=1) return true;
            return false;
        }
        public DataTable FetchDetails()
        {
             return objSql.FetchDetails();
        }
        public bool UpDetails(CreateAttributes ca)
        {
            if (objSql.UpdateDetails(ca) >= 1) return true;
            return false;
        }
        public bool DeleteDetails(int ca)
        {
            if( objSql.DeleteDetails(ca)>=1) return true;
            return false;
        }

    }
}