# Alias Mod
This mod adds the ability to alias commands in Hacknet. You need [Hacknet Pathfinder](https://github.com/Arkhist/Hacknet-Pathfinder/releases) to use this mod.

## Usage
    alias [-h] [-l] [-i] [name[=value]]
    
        -h    display usage help
        -l    reload aliases from alias file
        -i    display mod info

    unalias <name>

## Alias File
Aliases are stored in ~/sys/aliases.sys and reloaded every time the game is restarted. If you edit the file manually, you will have to use the `alias -l` command to reload your aliases. You can also remove this file completely to remove all of your aliases at once.
