using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IWaitSignatureRepository
    {
        // Adding new Wait Signature record to the table
        void Add(WaitSignature waitSignatureRecord);

        // Editing Wait Signature record which is actually on the table
        void Edit(WaitSignature waitSignatureRecord);

        // Removing Wait Signature record by ID
        void Remove(int waitSignatureRecordID);

        // Getting the all Wait Signature Records from the DB
        IEnumerable<dynamic> ListWaitSignature();

        // Finding specific record by ID
        WaitSignature FindWaitSignatureByID(int waitSignatureID);

        // Find Active Record by Document Guid
        WaitSignature FindWaitSignatureByDocument(Guid documentGUID);
    }
}