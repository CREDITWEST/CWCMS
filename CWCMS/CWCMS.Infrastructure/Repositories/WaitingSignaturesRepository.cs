﻿using CWCMS.Core.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace CWCMS.Infrastructure.Repositories
{
    public class WaitingSignaturesRepository : IWaitingSignaturesRepository
    {
        private Database CWDB = new Database("CWCMSConnection");

        public void Add(CWCMS.Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            CWDB.Insert(waitingSignaturesRecord);
        }

        public void Edit(CWCMS.Core.Models.WaitingSignatures waitingSignaturesRecord)
        {
            CWDB.Update(waitingSignaturesRecord);
        }

        public IEnumerable<dynamic> FindWaitingSignaturesByDocument(Guid documentGUID)
        {
            var list = CWDB.Fetch<CWCMS.Core.Models.WaitingSignatures>("WHERE DocumentID = @0", documentGUID);
            return list;
        }

        public CWCMS.Core.Models.WaitingSignatures FindWaitingSignaturesByID(int waitingSignatureID)
        {
            var record = CWDB.Single<CWCMS.Core.Models.WaitingSignatures>(waitingSignatureID);
            return record;
        }

        public IEnumerable<dynamic> ListWaitingSignatures()
        {
            var list = CWDB.Query<CWCMS.Core.Models.WaitingSignatures>("SELECT * FROM WaitingSignatures");
            return list;
        }

        public void Remove(int waitingSignatureRecordID)
        {
            CWDB.Delete(waitingSignatureRecordID);
        }
    }
}