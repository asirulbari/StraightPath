using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraightPath.Core.Orthography
{
    public class Document
    {
        public int Id { get; set; }

        public List<Chapter> Chapters { get; set; }
    }
}
