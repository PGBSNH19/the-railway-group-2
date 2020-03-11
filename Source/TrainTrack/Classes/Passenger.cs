using System;
using System.Collections.Generic;
using System.IO;

namespace TrainTrack.Classes
{
    public class Passenger :IGenericList<Passenger>
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public List<Passenger> Passengers { get; set; } = new List<Passenger>();

        public static Passenger CreateFromLine(string line)
        {
            string[] split = line.Split(';', ':');
            Passenger passenger = new Passenger
            {
                ID = int.Parse(split[0]),
                Name = split[1]
            };
            return passenger;
        }

        public List<Passenger> ReadFile(string path)
        {
            var lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                Passenger passenger = CreateFromLine(lines[i]);
                Passengers.Add(passenger);
            }

            return Passengers;
        }

    }
}
