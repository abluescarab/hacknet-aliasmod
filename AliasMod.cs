﻿using Pathfinder;
using Pathfinder.Command;
using Pathfinder.Util;

namespace AliasMod {
    public class AliasMod : IPathfinderMod {
        public const string Name = "Alias Mod";
        public const string Version = "1_1";
        public const string Filename = "aliases.sys";
        public const string ID = Name + " v" + Version;
        public string Identifier => ID;
        public const string Homepage = "https://github.com/abluescarab/hacknet-aliasmod";

        public void Load() {
            Logger.Verbose("Loading " + ID + "...");
        }

        public void LoadContent() {
            Handler.AddCommand(Commands.Aliases.Key, Commands.Aliases.RunCommand, Commands.Aliases.Description, true);
        }

        public void Unload() {
            Logger.Verbose("Unloading " + Name + "...");
        }
    }
}