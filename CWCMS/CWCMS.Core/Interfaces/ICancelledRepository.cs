using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface ICancelledRepository
    {
        // Adding new Cancelled record to the table
        void Add(Cancelled cancelledRecord);

        // Editing Cancelled record which is actually on the table
        void Edit(Cancelled cancelledRecord);

        // Removing Cancelled record by ID
        void Remove(int cancelledRecordID);

        // Getting the all Cancelled Records from the DB
        IEnumerable<dynamic> ListCancelled();

        // Finding specific record by ID
        Cancelled FindCancelledByID(int cancelledID);

        // Find Cancelled Record by Document Guid
        Cancelled FindCancelledByDocument(Guid documentGUID);
    }
}