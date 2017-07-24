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

        // Active Documents -> Done , Not Tested
        Document GetActiveDocumentByReferenceCode(string referenceCode);

        // Revised Documents -> Done , Not Tested
        Document GetRevisedDocumentByReferenceCode(string referenceCode);

        // Cancelled Documents -> Done , Not Tested
        Document GetCancelledDocumentByReferenceCode(string referenceCode);

        //------------------------------------//
        // Get Document By Guid Number

        // Active Documents -> Done , Not Tested
        Document GetActiveDocumentByGuid(Guid documentGuid);

        // Revised Documents -> Done , Not Tested
        Document GetRevisedDocumentByGuid(Guid documentGuid);

        // Cancelled Documents -> Done , Not Tested
        Document GetCancelledDocumentByGuid(Guid documentGuid);
    }
}