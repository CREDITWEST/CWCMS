using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IValidDateRepository
    {
        // Adding new Valid Date record to the table
        void Add(ValidDate validDateRecord);

        // Editing Valid Date record which is actually on the table
        void Edit(ValidDate validDateRecord);

        // Removing Valid Date record by ID
        void Remove(int validDateRecordID);

        // Getting the all Valid Date Records from the DB
        IEnumerable<dynamic> ListValidDate();

        // Find specific Valid Date record by ID
        ValidDate FindValidDateRecordByID(int validDateRecordID);

        // List Valid Date records according to date
        IEnumerable<dynamic> ListValidDateByDate(DateTime validDate);
    }
}