using CWCMS.Core.Models;
using System;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IWaitingForFeedbackRepository
    {
        // Adding new Waiting For Feedback record to the table
        void Add(WaitingForFeedback waitingForFeedbackRecord);

        // Editing Waiting For Feedback record which is actually on the table
        void Edit(WaitingForFeedback waitingForFeedbackRecord);

        // Removing Waiting For Feedback record by ID
        void Remove(int waitingForFeedbackRecordID);

        // Getting the all Waiting For Feedback Records from the DB
        IEnumerable<dynamic> ListWaitingForFeedback();

        // Finding specific record by ID
        WaitingForFeedback FindWaitingForFeedbackByID(int waitingForFeedbackID);

        // Find Waiting For Feedback Record by Document Guid
        WaitingForFeedback FindWaitingForFeedbackByDocument(Guid documentGUID);
    }
}