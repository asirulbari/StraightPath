using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraightPath.Core.Orthography
{
    public class Verse
    {
        public int Id { get; set; }

        public int Index { get; set; }

        public Chapter Chapter { get; set; }

        public List<Token> Tokens { get; set; }
    }
}
