using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IFeedbackRepository
    {
        // Adding new Feedback record to the table
        void Add(Feedback feedbackRecord);

        // Editing Feedback record which is actually on the table
        void Edit(Feedback feedbackRecord);

        // Removing Feedback record by ID
        void Remove(int feedbackRecordID);

        // Getting the all Feedback Records from the DB
        IEnumerable<dynamic> ListFeedback();

        // Finding specific record by ID
        Feedback FindFeedbackByID(int feedbackRecordID);

        // List Feedback records by UserID
        IEnumerable<dynamic> ListFeedbackRecordsByUserID(Guid userRecordID);

        // List Feedback records by DocumentID
        IEnumerable<dynamic> ListFeedbackRecordsByDocumentID(Guid documentRecordID);

        // List Feedback records by SendDate
        IEnumerable<dynamic> ListFeedbackRecordsBySendDate(DateTime sendingDate);
    }
}