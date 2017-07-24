using CWCMS.Core.Models;
using System;

namespace CWCMS.Application.BusinessLogicInterfaces.DocumentRetrievingLogic
{
    public interface ISpecificDocumentReturnRepository
    {
        /* Get specific data */

        // Necessity of retrieving single document according to one parameter is searching document by unique identifier

        //------------------------------------//
        // Get Document By Reference Number

        // Active Documents -> Under Construction
        Document GetActiveDocumentByReferenceCode(string referenceCode);

        // Revised Documents -> Under Construction
        Document GetRevisedDocumentByReferenceCode(string referenceCode);

        // Cancelled Documents -> Under Construction
        Document GetCancelledDocumentByReferenceCode(string referenceCode);

        //------------------------------------//
        // Get Document By Guid Number

        // Active Documents -> Under Construction
        Document GetActiveDocumentByGuid(Guid documentGuid);

        // Revised Documents -> Under Construction
        Document GetRevisedDocumentByGuid(Guid documentGuid);

        // Cancelled Documents -> Under Construction
        Document GetCancelledDocumentByGuid(Guid documentGuid);
    }
}