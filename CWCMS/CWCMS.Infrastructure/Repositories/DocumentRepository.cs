using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class DocumentRepository : IDocumentRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.Document documentRecord)
        {
            CWDB.Insert(documentRecord);
        }

        public void Edit(CWCMS.Core.Models.Document documentRecord)
        {
            CWDB.Update(documentRecord);
        }

        public CWCMS.Core.Models.Document FindDocumentByID(Guid documentRecordID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Document>(documentRecordID);
            return record;
        }

        public CWCMS.Core.Models.Document FindDocumentByReferenceNumber(string referenceNumber)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Document>("WHERE ReferenceNumber = @0", referenceNumber);
            return record;
        }

        public IEnumerable<dynamic> ListDocument()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Document>("SELECT * FROM Document");
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByPublishDate(DateTime publishDateTime)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.Document>("WHERE PublishDate = @0", publishDateTime);
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByPublisherID(Guid publisherId)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.Document>("WHERE PublisherID = @0", publisherId);
            return list;
        }

        public void Remove(Guid documentRecordID)
        {
            CWDB.Delete(documentRecordID);
        }
    }
}