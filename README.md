# DMBot
Simple terminal app to auto-generate D&amp;D 5e character with stats, HP, etc. for D&amp;D 5e GMs.

To use, clone locally, open the DMBot.sln file in Visual Studio, build, and run.

Current Functionality 
- 
Based on user-inputted character class and level, 
1) calculate average HP using (level * ((hit die/2) + 0.5)) + CON modifier
2) roll base stats using 4d6 drop method

Upcoming Functionality
- 
1) Transform base stats into modifier scores dynamically
2) Dynamically calculate AC
3) Dynamically calculate initiative
4) Dynamically calculate speed
5) Dynamically calculate proficiency
6) Add support for inspiration
7) Integrate D&amp;D race feats
8) Dynamically generate basic moveset (melee) or spell list (spellcaster)
9) Extend Player class for Animal/Beast
10) Add support for saving throws
11) Improvements to visual display
12) Add support to write character details to txt
