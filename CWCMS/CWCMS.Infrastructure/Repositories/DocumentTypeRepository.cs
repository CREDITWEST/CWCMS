using CWCMS.Core.Interfaces;
using CWCMS.Core.Models;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class DocumentTypeRepository : IDocumentTypeRepository
    {
        private Database _CWDB;

        public DocumentTypeRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(DocumentType documentTypeRecord)
        {
            _CWDB.Insert(documentTypeRecord);
        }

        public void Edit(DocumentType documentTypeRecord)
        {
            _CWDB.Update(documentTypeRecord);
        }

        public DocumentType FindDocumentTypeByID(int documentTypeID)
        {
            var record = _CWDB.Single<Core.Models.DocumentType>(documentTypeID);
            return record;
        }

        public IEnumerable<dynamic> ListDocumentType()
        {
            var list = _CWDB.Query<Core.Models.DocumentType>("SELECT * FROM DocumentType");
            return list;
        }

        public void Remove(int documentTypeRecordID)
        {
            _CWDB.Delete(documentTypeRecordID);
        }
    }
}