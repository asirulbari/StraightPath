using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StraightPath.Core.Orthography;

namespace StraightPath.Core.Services
{
    interface IImportService
    {
        Document GetDocument(string path);
        void Import(Document document);
    }
}
