﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Core.Models;
using CWCMS.Infrastructure.Repositories;

namespace CWCMS.Application.BusinessLogicInterfaces.DocumentUploadingLogic
{
    public interface IDocumentUploadRepository
    {
        Guid UploadToServerDocument(Document createdRecord);
    }
}
