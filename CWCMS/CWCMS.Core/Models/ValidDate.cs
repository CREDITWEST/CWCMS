using System;

namespace CWCMS.Core.Models
{
    public class ValidDate
    {
        // Auto-increment integer type variable and Primary Key of the valid date table
        public int ValidDateID { get; set; }

        // Guid type uniqueidentifier of the document which has to wait till this date to enter to the operation
        public Guid DocumentID { get; set; }

        // Validation date of the document
        public DateTime ValidationDate { get; set; }
    }
}