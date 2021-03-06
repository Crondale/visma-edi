﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crondale.VismaEdi.File
{
    public class EdiFile
    {
        private string firmId = "1";
        private List<EdiTable> sets = new List<EdiTable>();

        public EdiFile()
        {

        }

        public EdiFile(string firmId)
            :this()
        {
            this.firmId = firmId;
        }

        public void RemoveUnusedFields()
        {
            foreach(EdiTable set in sets)
            {
                set.RemoveUnusedFields();
            }
        }

        internal EdiTable this[int index]
        {
            get
            {
                return sets[index];
            }
        }

        internal void Add(EdiTable ediSet)
        {
            sets.Add(ediSet);
        }

        public void Save(String path)
        {
            SaveToStream(new FileStream(path, FileMode.Create));
        }

        public void SaveToStream(Stream stream)
        {
            TextWriter writer = new StreamWriter(stream, Encoding.GetEncoding(1252));

            writer.WriteLine("@FIRM_BEGIN({0})", firmId);
            writer.WriteLine();

            foreach (EdiTable set in sets)
            {
                writer.WriteLine("@IMPORT_METHOD({0})", set.ImportMethod);

                writer.WriteLine("@{0} ({1}{2})", set.Name, set.ImportMethod == 1 ? "=" : "", String.Join(",", set.Headers));
                
                foreach(EdiRow row in set)
                {
                    writer.WriteLine(String.Join(",", set.Headers.Select(h => "\"" + row[h] + "\"")));
                }

                writer.WriteLine();
            }


            writer.Close();
        }

        public static EdiFile FromFile(String path)
        {
            return FromStream(new FileStream(path, FileMode.Open));
        }

        public static EdiFile FromStream(Stream stream)
        {
            TextReader reader = new StreamReader(stream, Encoding.GetEncoding(1252));

            EdiFile ediFile = new EdiFile();
            EdiTable ediSet = null;

            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                    break;

                if (String.IsNullOrWhiteSpace(line))
                {

                }
                else if (line.StartsWith("@"))
                {
                    Match match = Regex.Match(line, @"\@(?<name>[a-zA-Z]+)\s*\(((?<header>[a-zA-Z0-9]+)(\,\s|\)))+");

                    if (match.Success)
                    {
                        ediSet = new EdiTable(match.Groups["name"].Value);

                        foreach (Capture header in match.Groups["header"].Captures)
                        {
                            ediSet.AddHeader(header.Value);
                        }

                        ediFile.Add(ediSet);
                    }
                }
                else
                {
                    Match match = Regex.Match(line, @"(\""(?<value>[^\""]*)\""\s*)*");

                    if (match.Success)
                    {
                        EdiRow row = new EdiRow();

                        int i = 0;
                        foreach (Capture c in match.Groups["value"].Captures)
                        {
                            String v = c.Value;

                            if (String.IsNullOrWhiteSpace(v))
                                v = null;

                            row[ediSet.Headers[i]] = v;
                            i++;
                        }

                        ediSet.Add(row);
                    }


                }

            }


            reader.Close();

            return ediFile;
        }
    }
}
