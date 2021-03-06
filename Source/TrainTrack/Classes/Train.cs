﻿using System.Collections.Generic;
using System.IO;

namespace TrainTrack.Classes
{
    public class Train : IGenericList<Train>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool Operated { get; set; }

        public string FilePath { get; set; } = @"data/trains.txt";
        public List<Train> Trains { get; set; } = new List<Train>();


        public static Train CreateFromLine(string line)
        {
            string[] split = line.Split(',');
            Train train = new Train
            {
                ID = int.Parse(split[0]),
                Name = split[1],
                MaxSpeed = int.Parse(split[2]),
                Operated = bool.Parse(split[3])
            };

            return train;
        }

        public List<Train> ReadFile()
        {
            var lines = File.ReadAllLines(FilePath);

            for (int i = 1; i < lines.Length; i++)
            {
                Train train = CreateFromLine(lines[i]);
                Trains.Add(train);
            }

            return Trains;
        }
    }
}
