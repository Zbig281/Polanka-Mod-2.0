# Polanka mod v2.0

- Knools
- Knools Weapons, Tools 
- New horse cart
- Knool Spawn random 5 in 1 group
- All finish for work server. 
- update folder is for client send basilMod.

For the Knole trigger to drop their items, you need MariaDB v10.

Auto restart with in-game information about the restart and the countdown time.
ServerRestart/Restart.cs
- how add? 
- In in Rcon on the online map from feudal.tools https://i.imgur.com/H61reft.png
- Stop restart "CancelRestart();"

in check_server.cmd you have to change the server ID as it is entered in config / world_1.xml for example.
- world_1.xml
- ID>1/ID, ID>2</ID, ID>3</ID

- check_server.cmd
- WorldID %1 , WorldID %2 , WorldID %3