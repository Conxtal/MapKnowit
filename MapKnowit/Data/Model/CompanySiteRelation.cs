using System.ComponentModel.DataAnnotations;

namespace MapIt.Data.Model
{
    public class CompanySiteRelation
    {
        [Key]
        public int CompanySiteRelationID { get; set; }

        public int CompanyID { get; }

        public int SiteID { get; set; }
    }
}