﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

namespace ChewyMoonsLux
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ObjectManager.Player.BaseSkinName != "Lux") return;

            var lux = new ChewyMoonsLux();
            CustomEvents.Game.OnGameLoad += lux.OnGameLoad;
        }
    }
}