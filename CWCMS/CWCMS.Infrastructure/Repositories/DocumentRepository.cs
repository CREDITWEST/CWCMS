using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;

namespace CWCMS.Infrastructure.Repositories
{
    class DocumentRepository : IDocumentRepository
    {

        Database CWDB = new Database(CWCMS.Infrastructure.Properties.Settings.CWCMS);

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
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListDocument()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Document>("SELECT * FROM Document");
            return list;
        }

        public IEnumerable<dynamic> ListDocumentByPublishDate(DateTime publishDateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> ListDocumentByPublisherID(Guid publisherId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid documentRecordID)
        {
            CWDB.Delete(documentRecordID);
        }
    }
}
