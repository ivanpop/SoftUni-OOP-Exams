﻿using System;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU(string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;
        }

        public string Brand { get; set; }

        public int Cores { get; set; }

        public double Frequency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Brand} CPU:" + Environment.NewLine);
            sb.Append($"Cores: {Cores}" + Environment.NewLine);
            sb.Append($"Frequency: {Frequency:f1} GHz");
            return sb.ToString().TrimEnd();
        }
    }
}