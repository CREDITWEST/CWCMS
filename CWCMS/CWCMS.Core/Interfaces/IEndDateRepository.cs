using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IEndDateRepository
    {
        // Adding new End Date record to the table
        void Add(EndDate endDateRecord);

        // Editing End Date record which is actually on the table
        void Edit(EndDate endDateRecord);

        // Removing End Date record by ID
        void Remove(int endDateRecordID);

        // Getting the all End Date Records from the DB
        IEnumerable<dynamic> ListEndDate();

        // Find specific End Date record by ID
        EndDate FindEndDateRecordByID(int endDateRecordID);

        // List End Date records according to date
        IEnumerable<dynamic> ListEndDateByDate(DateTime endDate);

        // List End Date Records by Document ID
        IEnumerable<dynamic> ListEndDateByGuid(Guid documentID);
    }
}