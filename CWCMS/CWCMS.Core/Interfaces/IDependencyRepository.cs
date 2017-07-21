using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IDependencyRepository
    {
        // Adding new Dependency record to the table
        void Add(Dependency dependencyRecord);

        // Editing Dependency record which is actually on the table
        void Edit(Dependency dependencyRecord);

        // Removing Dependency record by ID
        void Remove(int dependencyRecordID);

        // Getting the all Dependency Records from the DB
        IEnumerable<dynamic> ListDependency();

        // Find specific Dependency record by DependencyID
        Dependency FindRecordByID(int dependencyId);

        // List records by Depending Documents
        IEnumerable<dynamic> ListDependencyByDependingID(Guid dependingDocID);

        // List records by Depended Documents
        IEnumerable<dynamic> ListDependencyByDependedID(Guid dependedDocID);
    }
}