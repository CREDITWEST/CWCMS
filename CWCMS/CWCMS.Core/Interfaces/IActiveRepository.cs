using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IActiveRepository
    {
        // Adding new Active record to the table
        void Add(Active activeRecord);

        // Editing Active record which is actually on the table
        void Edit(Active activeRecord);

        // Removing Active record by ID
        void Remove(int activeRecordID);

        // Getting the all Active Records from the DB
        IEnumerable<dynamic> ListActive();

        // Finding specific record by ID
        Active FindActiveByID(int activeID);

        // Find Active Record by Document Guid
        Active FindActiveByDocument(Guid documentGUID);
    }
}