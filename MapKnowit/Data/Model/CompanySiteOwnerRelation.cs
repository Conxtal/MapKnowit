using System.ComponentModel.DataAnnotations;

namespace MapIt.Data.Model
{
    public class CompanySiteOwnerRelation
    {
        [Key]
        public int CompanySiteID { get; set; }

        public int OwnershipTupeID { get; set; }

        public bool IsInternal { get; set;}
    }
}
