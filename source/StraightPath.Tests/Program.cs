using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StraightPath.Services.Tests;

namespace StraightPath.Tests
{
    public class Program
    {
        static void Main()
        {
            var t = new ImportServiceTests();
            //t.GetDocumentReturnValidDocument();
            t.ImportDocument();
        }
    }
}
