using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(Core.Models.Document documentRecord)
        {
            CWDB.Insert(documentRecord);
        }

        public void Edit(Core.Models.Document documentRecord)
        {
            CWDB.Update(documentRecord);
        }

        public Core.Models.Document FindDocumentByID(Guid documentRecordID)
        {
            var record = CWDB.Single<Core.Models.Document>(documentRecordID);
            return record;
        }

        public Core.Models.Document FindDocumentByReferenceNumber(string referenceNumber)
        {
            var record = CWDB.Single<Core.Models.Document>("WHERE ReferenceNumber = @0", referenceNumber);
            return record;
        }

        public IEnumerable<dynamic> ListDocument()
        {
            var list = CWDB.Query<Core.Models.Document>("SELECT * FROM Document");
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByPublishDate(DateTime publishDateTime)
        {
            var list = CWDB.Fetch<Core.Models.Document>("WHERE PublishDate = @0", publishDateTime);
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByPublisherID(Guid publisherId)
        {
            var list = CWDB.Fetch<Core.Models.Document>("WHERE PublisherID = @0", publisherId);
            return list;
        }

        public void Remove(Guid documentRecordID)
        {
            CWDB.Delete(documentRecordID);
        }
    }
}