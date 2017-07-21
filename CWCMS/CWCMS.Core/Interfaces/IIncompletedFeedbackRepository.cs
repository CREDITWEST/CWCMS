using CWCMS.Core.Models;
using System.Collections.Generic;

namespace CWCMS.Core.Interfaces
{
    public interface IIncompletedFeedbackRepository
    {
        // Adding new Incompleted Feedback record to the table
        void Add(IncompletedFeedback incompletedFeedbackRecord);

        // Editing Incompleted Feedback record which is actually on the table
        void Edit(IncompletedFeedback incompletedFeedbackRecord);

        // Removing Incompleted Feedback record by ID
        void Remove(int incompletedFeedbackRecordID);

        // Getting the all Incompleted Feedback Records from the DB
        IEnumerable<dynamic> ListIncompletedFeedback();

        // Finding specific record by ID
        IncompletedFeedback FindIncompletedRecordByID(int incompletedFeedbackID);
    }
}