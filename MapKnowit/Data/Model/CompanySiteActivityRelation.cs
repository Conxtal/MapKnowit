using System.ComponentModel.DataAnnotations;

namespace MapIt.Data.Model
{
    public class CompanySiteActivityRelation
    {
        [Key]
        public int CompanySiteID { get; set; } 

        public int ActivityID { get; set; } 
    }
}
