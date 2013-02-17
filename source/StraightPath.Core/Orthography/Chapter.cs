using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraightPath.Core.Orthography
{
    public class Chapter
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Verse> Verses { get; set; }

        public Document Document { get; set; }
    }
}
