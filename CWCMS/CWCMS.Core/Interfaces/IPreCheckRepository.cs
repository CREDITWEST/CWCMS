using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IPreCheckRepository
    {
        // Adding new Pre Check record to the table
        void Add(PreCheck preCheckRecord);

        // Editing Pre Check record which is actually on the table
        void Edit(PreCheck preCheckRecord);

        // Removing Pre Check record by ID
        void Remove(int preCheckRecordID);

        // Getting the all Pre Check Records from the DB
        IEnumerable<dynamic> ListPreCheck();

        // Finding specific record by ID
        PreCheck FindPreCheckByID(int preCheckID);

        // Find Pre Check Record by Document Guid
        PreCheck FindPreCheckByDocument(Guid documentGUID);
    }
}