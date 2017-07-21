using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    internal class ActiveRepository : IActiveRepository
    {
        private Database CWDB = new Database(Properties.Settings.CWCMS);

        public void Add(CWCMS.Core.Models.Active activeRecord)
        {
            CWDB.Insert(activeRecord);
        }

        public void Edit(CWCMS.Core.Models.Active activeRecord)
        {
            CWDB.Update(activeRecord);
        }

        void IActiveRepository.Remove(int activeRecordID)
        {
            CWDB.Delete(activeRecordID);
        }

        IEnumerable<dynamic> IActiveRepository.ListActive()
        {
            var list = CWDB.Query<CWCMS.Core.Models.Active>("SELECT * FROM Active");
            return list;
        }

        CWCMS.Core.Models.Active IActiveRepository.FindActiveByID(int activeID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.Active>(activeID);
            return record;
        }

        CWCMS.Core.Models.Active IActiveRepository.FindActiveByDocument(Guid documentGUID)
        {
            throw new NotImplementedException();
        }
    }
}