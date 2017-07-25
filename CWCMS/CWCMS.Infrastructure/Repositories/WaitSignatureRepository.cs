﻿using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class WaitSignatureRepository : IWaitSignatureRepository
    {
        private Database _CWDB;

        public WaitSignatureRepository()
        {
            this._CWDB = new Database("CWCMSConnection");
        }

        public void Add(Core.Models.WaitSignature waitSignatureRecord)
        {
            _CWDB.Insert(waitSignatureRecord);
        }

        public void Edit(Core.Models.WaitSignature waitSignatureRecord)
        {
            _CWDB.Update(waitSignatureRecord);
        }

        public Core.Models.WaitSignature FindWaitSignatureByDocument(Guid documentGUID)
        {
            var record = _CWDB.Single<Core.Models.WaitSignature>("WHERE DocumentID = @0", documentGUID);
            return record;
        }

        public Core.Models.WaitSignature FindWaitSignatureByID(int waitSignatureID)
        {
            var record = _CWDB.Single<Core.Models.WaitSignature>(waitSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitSignature()
        {
            var list = _CWDB.Query<Core.Models.WaitSignature>("SELECT * FROM WaitSignature");
            return list;
        }

        public void Remove(int waitSignatureRecordID)
        {
            _CWDB.Delete(waitSignatureRecordID);
        }
    }
}