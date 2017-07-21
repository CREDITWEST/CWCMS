using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IPostCheckRepository
    {
        // Adding new Post Check record to the table
        void Add(PostCheck postCheckRecord);

        // Editing Post Check record which is actually on the table
        void Edit(PostCheck postCheckRecord);

        // Removing Post Check record by ID
        void Remove(int postCheckRecordID);

        // Getting the all Post Check Records from the DB
        IEnumerable<dynamic> ListPostCheck();

        // Finding specific record by ID
        PostCheck FindPostCheckByID(int postCheckID);

        // Find Post Check Record by Document Guid
        PostCheck FindPostCheckByDocument(Guid documentGUID);
    }
}