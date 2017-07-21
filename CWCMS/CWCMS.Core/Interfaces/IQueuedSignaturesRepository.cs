using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IQueuedSignaturesRepository
    {
        // Adding new Queued Signature record to the table
        void Add(QueuedSignatures queuedSignaturesRecord);

        // Editing Queued Signature record which is actually on the table
        void Edit(QueuedSignatures queuedSignaturesRecord);

        // Removing Queued Signature record by ID
        void Remove(int queuedSignatureRecordID);

        // Getting the all Queued Signature Records from the DB
        IEnumerable<dynamic> ListQueuedSignatures();

        // Finding specific record by ID
        QueuedSignatures FindQueuedSignaturesByID(int queuedSignatureID);

        // Find Queued Signature Records by Document Guid
        IEnumerable<dynamic> FindQueuedSignaturesByDocument(Guid documentGUID);
    }
}