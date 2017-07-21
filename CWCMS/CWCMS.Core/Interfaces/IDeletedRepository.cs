using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IDeletedRepository
    {
        // Adding new Deleted record to the table
        void Add(Deleted deletedRecord);

        // Editing Deleted record which is actually on the table
        void Edit(Deleted deletedRecord);

        // Removing Deleted record by ID
        void Remove(int deletedRecordID);

        // Getting the all Deleted Records from the DB
        IEnumerable<dynamic> ListDeleted();

        // Finding specific record by ID
        Deleted FindDeletedByID(int deletedID);

        // Find Deleted Record by Document Guid
        Deleted FindDeletedByDocument(Guid documentGUID);
    }
}