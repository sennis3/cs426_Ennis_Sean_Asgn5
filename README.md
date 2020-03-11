# cs426_Ennis_Sean_Asgn5

Sean Ennis

cs426

Assignment 5

The game is generally the same as the previous version with a few additional features. I did change the layout of the map by condensing all the elements into a smaller portion of the map to make the game faster and easier to play. However, this left a lot of the map open and unused. The previous Readme file explaining the overall gameplay is also in the repository. These are the additions:

Physics Constructs

The previous version already involved a good amount of physics contructs including collision detections and those that revolve around the chararacter's bird flying such as gravity. I improved this a little by adding in drag to simulate the air resistance while flying, and I also allowed the boxes to rotate so they could roll and move more realistically. In addition to this I added new features including jump zones and wind. The jump zones are little yellow zones scattered across the map that will launch you up in the air when you collide with them. This is to help with the flying aspect of the game. The wind affects your character by pushing it slightly in one direction, which creates more of a challenge. It has more of an effect when you're in the air. The wind blows the leaves on the trees as well. (Note: The wind was much stronger in the build than it was in the editor so I decreased it.)

Billboards

The billboards I added can be found at the bottom of the player's screen, and they represent the amount of speed boosts the player has accumulated. The speed boosts permanantly increase the character's speed at small intervals. When the player collects each speed boost, one of the billboards will change from being transparent to showing the speed boost icon.

Lighting

Since the goal zones are discs on the ground, they can sometimes be a little difficult to find when you're moving across the map. To improve this, I added spotlights above the zones to illuminate them in the color respective to that zone. I did the same thing with the jump zones too in a yellow color. This causes them to glow and make them easier to spot.

Sounds

I added two different sound effects to the game. The first is a bird chirp, which happens when the player collects a speed boost and also when the player hits the space bar. The other is a celebratory sound when a computer part is collected by knocking it into one of the goal zones. Since the players aren't assigned specific colors for their goal and can decide for themselves, the sound happens when a point is scored for either side.
