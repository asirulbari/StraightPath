using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StraightPath.Core.Orthography;
using System.Xml.Serialization;
using System.IO;
using StraightPath.Core.Repositories;

namespace StraightPath.Core.Services
{
    public class ImportService:IImportService
    {
        public Document GetDocument(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Quran));
            var quran = xml.Deserialize(new StreamReader(path)) as Quran;

            Document document = new Document();

            var chapters = new List<Chapter>(114);

            foreach (var sura in quran.Suras)
            {
                var chapter = new Chapter() { Id = sura.Index, Name = sura.Name };

                var verses = new List<Verse>(sura.Ayas.Count());
                var index = 0;
                foreach (var aya in sura.Ayas)
                {
                    var verse = new Verse() { Chapter = chapter, Id = aya.Index, Index = ++index };
                    var tokens = new List<Token>();
                    var splitTokens = aya.Text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 1; i <= splitTokens.Count(); i++)
                    {
                        var splitToken = splitTokens[i-1];

                        var token = new Token() { Id = i, Text = splitToken };
                        tokens.Add(token);
                    }

                    verse.Tokens = tokens;
                    verses.Add(verse);
                }

                chapter.Verses = verses;
                chapters.Add(chapter);
            }

            document.Chapters = chapters;

            return document;
        }

        public void Import(Document document)
        {
            var context = new StraightPathDbContext();
            context.Documents.Add(document);
            context.SaveChanges();
        }

        #region Serialization models
        [XmlRoot("quran")]
        public class Quran
        {
            [XmlElement("sura")]
            public Sura[] Suras { get; set; }
        }

        public class Sura
        {
            [XmlAttribute("index")]
            public int Index { get; set; }

            [XmlAttribute("name")]
            public string Name { get; set; }

            [XmlElement("aya")]
            public Aya[] Ayas { get; set; }
        }

        
        public class Aya
        {
            [XmlAttribute("index")]
            public int Index { get; set; }

            [XmlAttribute("text")]
            public string Text { get; set; }
        }
        #endregion
    }
}
