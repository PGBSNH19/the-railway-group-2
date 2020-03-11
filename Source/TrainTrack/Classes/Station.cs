using System;
using System.Collections.Generic;
using System.IO;

namespace TrainTrack.Classes
{
    public class Station : IGenericList<Station>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool EndStation { get; set; }

        public List<Station> Stations { get; set; } = new List<Station>();

        public static Station CreateFromLine(string line)
        {
            string[] split = line.Split('|');
            Station station = new Station
            {
                ID = int.Parse(split[0]),
                Name = split[1],
                EndStation = bool.Parse(split[2])

            };

            return station;
        }

        public List<Station> ReadFile(string path)
        {
            var lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                Station timeTable = CreateFromLine(lines[i]);
                Stations.Add(timeTable);
            }

            return Stations;
        }
    }
}
