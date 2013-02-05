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

        public IEnumerable<Verse> Verses { get; set; }
    }
}
