using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface ICompletedFeedbackRepository
    {
        // Adding new Completed Feedback record to the table
        void Add(CompletedFeedback completedFeedbackRecord);

        // Editing Completed Feedback record which is actually on the table
        void Edit(CompletedFeedback completedFeedbackRecord);

        // Removing Completed Feedback record by ID
        void Remove(int completedFeedbackRecordID);

        // Getting the all Completed Feedback Records from the DB
        IEnumerable<dynamic> ListCompletedFeedback();

        // Finding specific record by ID
        CompletedFeedback FindCompletedRecordByID(int completedFeedbackID);
    }
}