﻿using UnityEngine;

namespace Editor.CommandFuntions
{
    public static class Slomo
    {
        public static bool Process(string[] args)
        {
            if (args.Length < 2)
                return false;

            var scale = float.Parse(args[1], System.Globalization.CultureInfo.InvariantCulture);
            Time.timeScale = scale;
                
            return true;
        }
    }
}
