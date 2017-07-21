using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IConfirmedSignaturesRepository
    {
        // Adding new Confirmed Signature record to the table
        void Add(ConfirmedSignatures confirmedSignaturesRecord);

        // Editing Confirmed Signature record which is actually on the table
        void Edit(ConfirmedSignatures confirmedSignaturesRecord);

        // Removing Confirmed Signature record by ID
        void Remove(int confirmedSignatureRecordID);

        // Getting the all Confirmed Signature Records from the DB
        IEnumerable<dynamic> ListConfirmedSignatures();

        // Finding specific record by ID
        ConfirmedSignatures FindConfirmedSignaturesByID(int confirmedSignatureID);

        // Find Confirmed Signature Records by Document Guid
        IEnumerable<dynamic> FindConfirmedSignaturesByDocument(Guid documentGUID);
    }
}