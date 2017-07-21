using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IRevisedRepository
    {
        // Adding new Revised record to the table
        void Add(Revised revisedRecord);

        // Editing Revised record which is actually on the table
        void Edit(Revised revisedRecord);

        // Removing Revised record by ID
        void Remove(int revisedRecordID);

        // Getting the all Revised Records from the DB
        IEnumerable<dynamic> ListRevised();

        // Finding specific record by ID
        Revised FindRevisedByID(int revisedID);

        // Find Revised Record by Document Guid
        Revised FindRevisedByDocument(Guid documentGUID);
    }
}