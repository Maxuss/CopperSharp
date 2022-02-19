tellraw Xtremum {"text":"Hello!","color":"gold","bold":true}
title Xtremum title {"text":"Title"}
title Xtremum subtitle {"text":"Subtitle"}
title Xtremum actionbar {"text":"Actionbar"}
advancement grant Xtremum only minecraft:adventure/adventuring_time
playsound minecraft:entity.axolotl.attack master Xtremum ~ ~ ~ 1 1 1
effect give Xtremum glowing 10 1 false
particle dust 0.99609375 0.6640625 0.99609375 1 ~ ~ ~ 1 0 1 1 50 normal Xtremum
give Xtremum minecraft:diamond_sword{} 1
item replace entity Xtremum armor.head with minecraft:diamond_block{} 1
item replace entity Xtremum hotbar.5 with minecraft:nether_star{} 1

# Built with CopperSharp v0.2.1
