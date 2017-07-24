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
    class DocumentTypeRepository : IDocumentTypeRepository
    {

        private Database CWDB = new Database("CWCMSConnection");

        public void Add(DocumentType documentTypeRecord)
        {
            CWDB.Insert(documentTypeRecord);
        }

        public void Edit(DocumentType documentTypeRecord)
        {
            CWDB.Update(documentTypeRecord);
        }

        public DocumentType FindDocumentTypeByID(int documentTypeID)
        {
            var record = CWDB.Single<Core.Models.DocumentType>(documentTypeID);
            return record;
        }

        public IEnumerable<dynamic> ListDocumentType()
        {
            var list = CWDB.Query<Core.Models.DocumentType>("SELECT * FROM DocumentType");
            return list;
        }

        public void Remove(int documentTypeRecordID)
        {
            CWDB.Delete(documentTypeRecordID);
        }
    }
}
