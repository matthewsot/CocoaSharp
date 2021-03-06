﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubGen
{
    public class ScrapedParameter
    {
        public string Description { get; set; }
        public ScrapedType Type { get; set; }
        public string Name { get; set; }
        public string InternalName { get; set; }

        public ScrapedParameter(string parameter)
        {
            parameter = parameter.Trim();
            var names = parameter.Split(':')[0].Trim().Split(' ');
            Name = names[0].Trim() == "_" ? names.Last() : names[0];
            InternalName = names.Last();
            Name = Name.Trim().Trim('`');
            if (new[] {"object", "string", "delegate","int","uint","float","class", "this", "new","bool","char","double","short","long", "event" }.Contains(Name))
            {
                Name = "@" + Name;
            }

            try
            {
                var type = parameter.Substring(parameter.IndexOf(':') + 1).Trim();
                Type = ScrapedType.ScrapeType(type);
            }
            catch
            {
                Type = ScrapedType.ScrapeType("WEIRD");
            }
        }

        public static IEnumerable<string> ScrapeParameters(string parameters)
        {
            var output = new List<string>();
            var currBuffer = "";
            var currLevel = 0;
            foreach (var character in parameters)
            {
                switch (character)
                {
                    case '[':
                    case '<':
                    case '-':
                    case '(':
                        currLevel++;
                        currBuffer += character;
                        break;
                    case ']':
                    case '>':
                    case ')':
                        currLevel--;
                        currBuffer += character;
                        break;
                    case ',':
                        if (currLevel == 0)
                        {
                            output.Add(currBuffer);
                            currBuffer = "";
                            break;
                        }
                        currBuffer += character;
                        break;
                    default:
                        currBuffer += character;
                        break;
                }
            }
            output.Add(currBuffer);
            output.RemoveAll(str => string.IsNullOrWhiteSpace(str));
            return output;
        }
    }
}
