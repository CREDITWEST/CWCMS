using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Core.Models;
using CWCMS.Application.DocumentLogic.DocumentRetrievingRepositories;

namespace CWCMS.TemporaryTest
{
    class Program
    {
        static void Main(string[] args)
        {


            BulkDocumentRetrievingRepository repo = new BulkDocumentRetrievingRepository();


            IEnumerable<Document> testDocument = repo.GetWholeActiveList();

            Console.WriteLine( testDocument.ToList().ElementAt<Document>(0).DocumentID);
            Console.ReadLine();

        }
    }
}
