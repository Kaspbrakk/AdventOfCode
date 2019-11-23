﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AdventOfCode
{
    public static class FileHandler
    {
        public static string[] OpenFile(string fileName, int year)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"{year}\Inputs\{fileName}.txt");
            return File.ReadAllLines(path);
        }
    }
}