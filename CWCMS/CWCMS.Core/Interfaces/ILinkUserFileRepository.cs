using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface ILinkUserFileRepository
    {
        // Adding new Link-User-File record to the table
        void Add(LinkUserFile linkUserFileRecord);

        // Editing Link-User-File record which is actually on the table
        void Edit(LinkUserFile linkUserFileRecord);

        // Removing Link-User-File record by ID
        void Remove(int linkUserFileRecordID);

        // Getting the all Link-User-File Records from the DB
        IEnumerable<dynamic> ListLinkUserFile();

        // Find specific Link-User-File Record by ID
        LinkUserFile FindLinkUserFileByID(int linkUserFileRecordID);

        // List Link-User-File Records by UserID
        IEnumerable<dynamic> ListLinkUserFileByUser(Guid userId);

        // List Link-User-File Records by DocumentID
        IEnumerable<dynamic> ListLinkUserFileByFile(Guid documentId);
    }
}