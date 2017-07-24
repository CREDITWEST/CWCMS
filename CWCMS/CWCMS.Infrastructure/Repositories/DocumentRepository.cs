using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private Database _CWDB;

        public DocumentRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(Core.Models.Document documentRecord)
        {
            _CWDB.Insert(documentRecord);
        }

        public void Edit(Core.Models.Document documentRecord)
        {
            _CWDB.Update(documentRecord);
        }

        public Core.Models.Document FindDocumentByID(Guid documentRecordID)
        {
            var record = _CWDB.Single<Core.Models.Document>(documentRecordID);
            return record;
        }

        public Core.Models.Document FindDocumentByReferenceNumber(string referenceNumber)
        {
            var record = _CWDB.Single<Core.Models.Document>("WHERE ReferenceNumber = @0", referenceNumber);
            return record;
        }

        public IEnumerable<dynamic> ListDocument()
        {
            var list = _CWDB.Query<Core.Models.Document>("SELECT * FROM Document");
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByPublishDate(DateTime publishDateTime)
        {
            var list = _CWDB.Fetch<Core.Models.Document>("WHERE PublishDate = @0", publishDateTime);
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByPublisherID(Guid publisherId)
        {
            var list = _CWDB.Fetch<Core.Models.Document>("WHERE PublisherID = @0", publisherId);
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByDocumentTypeID(int documentTypeID)
        {
            var list = _CWDB.Fetch<Core.Models.Document>("WHERE DocumentTypeID = @0", documentTypeID);
            return list;
        }

        public void Remove(Guid documentRecordID)
        {
            _CWDB.Delete(documentRecordID);
        }

        /* Bulk Document Retrieving Methods */

        public IEnumerable<Document> GetWholeActiveList()
        {
            var list = _CWDB.Fetch<Document>("SELECT * FROM Document AS Doc  INNER JOIN Active AS Act ON Act.DocumentID = Doc.DocumentID");
            return list;
        }

        public IEnumerable<Document> GetWholeRevisedList()
        {
            var list = _CWDB.Fetch<Document>("SELECT * FROM Document AS Doc  INNER JOIN Revised AS Rev ON Rev.DocumentID = Doc.DocumentID");
            return list;
        }

        public IEnumerable<Document> GetWholeCancelledList()
        {
            var list = _CWDB.Fetch<Document>("SELECT * FROM Document AS Doc  INNER JOIN Cancelled AS Can ON Can.DocumentID = Doc.DocumentID");
            return list;
        }

        // Categorised Document Retrieving Methods */

        public IEnumerable<Document> GetActiveListByCategory(int categoryCode)
        {
            var list = _CWDB.Fetch<Document>("SELECT * FROM Document AS Doc  INNER JOIN Active AS Act ON Act.DocumentID = Doc.DocumentID  WHERE Doc.DocumentTypeID = @0", categoryCode);
            return list;
        }

        public IEnumerable<Document> GetRevisedListByCategory(int categoryCode)
        {
            var list = _CWDB.Fetch<Document>("SELECT * FROM Document AS Doc  INNER JOIN Revised AS Rev ON Rev.DocumentID = Doc.DocumentID  WHERE Doc.DocumentTypeID = @0", categoryCode);
            return list;
        }

        public IEnumerable<Document> GetCancelledListByCategory(int categoryCode)
        {
            var list = _CWDB.Fetch<Document>("SELECT * FROM Document AS Doc  INNER JOIN Cancelled AS Can ON Can.DocumentID = Doc.DocumentID  WHERE Doc.DocumentTypeID = @0", categoryCode);
            return list;
        }

        /* Specific Document Listing */

        public Document GetActiveDocumentByReferenceCode(string referenceCode)
        {
            var record = _CWDB.Single<Document>("SELECT * FROM Document AS Doc  INNER JOIN Active AS Act ON Act.DocumentID = Doc.DocumentID  WHERE Doc.ReferenceNumber = @0", referenceCode);
            return record;
        }

        public Document GetRevisedDocumentByReferenceCode(string referenceCode)
        {
            var record = _CWDB.Single<Document>("SELECT * FROM Document AS Doc  INNER JOIN Revised AS Rev ON Rev.DocumentID = Doc.DocumentID  WHERE Doc.ReferenceNumber = @0", referenceCode);
            return record;
        }

        public Document GetCancelledDocumentByReferenceCode(string referenceCode)
        {
            var record = _CWDB.Single<Document>("SELECT * FROM Document AS Doc  INNER JOIN Cancelled AS Can ON Can.DocumentID = Doc.DocumentID  WHERE Doc.ReferenceNumber = @0", referenceCode);
            return record;
        }

        public Document GetActiveDocumentByGuid(Guid documentGuid)
        {
            var record = _CWDB.Single<Document>("SELECT * FROM Document AS Doc  INNER JOIN Active AS Act ON Act.DocumentID = Doc.DocumentID  WHERE Doc.DocumentID = @0", documentGuid);
            return record;
        }

        public Document GetRevisedDocumentByGuid(Guid documentGuid)
        {
            var record = _CWDB.Single<Document>("SELECT * FROM Document AS Doc  INNER JOIN Revised AS Rev ON Rev.DocumentID = Doc.DocumentID  WHERE Doc.DocumentID = @0", documentGuid);
            return record;
        }

        public Document GetCancelledDocumentByGuid(Guid documentGuid)
        {
            var record = _CWDB.Single<Document>("SELECT * FROM Document AS Doc  INNER JOIN Cancelled AS Can ON Can.DocumentID = Doc.DocumentID  WHERE Doc.DocumentID = @0", documentGuid);
            return record;
        }
    }
}