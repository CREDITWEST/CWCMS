using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class ActiveRepository : IActiveRepository
    {
        private Database _CWDB;

        public ActiveRepository()
        {
            this._CWDB = new Database("CWCMSConnSecVers");
        }

        public void Add(Core.Models.Active activeRecord)
        {
            _CWDB.Insert(activeRecord);
        }

        public void Edit(Core.Models.Active activeRecord)
        {
            _CWDB.Update(activeRecord);
        }

        void IActiveRepository.Remove(int activeRecordID)
        {
            _CWDB.Delete(activeRecordID);
        }

        IEnumerable<dynamic> IActiveRepository.ListActive()
        {
            var list = _CWDB.Query<Core.Models.Active>("SELECT * FROM Active");
            return list;
        }

        Core.Models.Active IActiveRepository.FindActiveByID(int activeID)
        {
            var record = _CWDB.Single<Core.Models.Active>(activeID);
            return record;
        }

        Core.Models.Active IActiveRepository.FindActiveByDocument(Guid documentGUID)
        {
            var record = _CWDB.Single<Core.Models.Active>("WHERE DocumentID = @0", documentGUID);
            return record;
        }
    }
}