using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using StraightPath.Core.Services;

namespace StraightPath.Services.Tests
{
    [TestFixture]
    public class ImportServiceTests
    {
        [Test]
        public void GetDocumentReturnValidDocument()
        {

            var importService = new ImportService();
            var doucment = importService.GetDocument("quran-uthmani.xml");
        }

        [Test]
        public void ImportDocument()
        {
            var importService = new ImportService();
            var document = importService.GetDocument("quran-uthmani.xml");
            importService.Import(document);
        }
    }
}
