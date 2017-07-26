using CWCMS.Core.Interfaces;
using PetaPoco;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class FileRevisionsRepository : IFileRevisionsRepository
    {
        private Database _CWDB;

        public FileRevisionsRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.FileRevisions fileRevisionRecord)
        {
            _CWDB.Insert("FileRevisions","FileReID",true,fileRevisionRecord);
        }

        public void Edit(Core.Models.FileRevisions fileRevisionRecord)
        {
            _CWDB.Update("FileRevisions", "FileReID",fileRevisionRecord);
        }

        public Core.Models.FileRevisions FindFileRevisionsByID(int fileRevisionsRecordID)
        {
            var record = _CWDB.Single<Core.Models.FileRevisions>(fileRevisionsRecordID);
            return record;
        }

        public int LastRevisionNumberOfSpecificDocument(string typeCode, int sequenceNumber)
        {
            int revisionNumber = _CWDB.ExecuteScalar<int>("SELECT fr.RevisionNumber FROM FileRevisions AS fr WHERE fr.FileType = '" + typeCode + "' AND fr.SequenceNumber =" + sequenceNumber);

            return revisionNumber;
        }

        public IEnumerable<dynamic> ListFileRevisions()
        {
            var list = _CWDB.Query<Core.Models.FileRevisions>("SELECT * FROM FileRevisions");
            return list;
        }

        public IEnumerable<dynamic> ListFileRevisionsByDocumentType(string documentTypeCode)
        {
            var list = _CWDB.Fetch<Core.Models.FileRevisions>("WHERE FileType = @0", documentTypeCode);
            return list;
        }

        public void Remove(int fileRevisionRecordID)
        {
            _CWDB.Delete(fileRevisionRecordID);
        }
    }
}