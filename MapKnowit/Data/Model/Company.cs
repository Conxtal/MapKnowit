namespace MapIt.Data.Model
{
    public class Company
    {
        //public Company(int companyId, string companyName, int divisionId)
        //{
        //    CompanyID = companyId;
        //    CompanyName = companyName;
        //    DivisionId = divisionId;
        //}

        public int CompanyID { get; set; }
        public bool CompanyName { get; set;}

        public int DivisionID { get; set;}
    }
}
