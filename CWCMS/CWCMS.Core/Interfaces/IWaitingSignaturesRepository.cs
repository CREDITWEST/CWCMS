using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IWaitingSignaturesRepository
    {
        // Adding new Waiting Signature record to the table
        void Add(WaitingSignatures waitingSignaturesRecord);

        // Editing Waiting Signature record which is actually on the table
        void Edit(WaitingSignatures waitingSignaturesRecord);

        // Removing Waiting Signature record by ID
        void Remove(int waitingSignatureRecordID);

        // Getting the all Waiting Signature Records from the DB
        IEnumerable<dynamic> ListWaitingSignatures();

        // Finding specific record by ID
        WaitingSignatures FindWaitingSignaturesByID(int waitingSignatureID);

        // Find Waiting Signature Records by Document Guid
        IEnumerable<dynamic> FindWaitingSignaturesByDocument(Guid documentGUID);
    }
}