# HW4
## Devlog
In my code, the AudioPlayer and UpdateUI classes define the view side of the model-view-control pattern. As their names describes, the AudioPlayer class plays audio when the player jumps or scores a point and the UpdateUI class updates the UI when the player gets a point or crashes into a pipe. The Player and GameController classes define the control side of the pattern. The Player class holds the code for controlling the player, points, and detects collisions with pipes and point colliders. The GameController class holds the logic for spawning the pipes. The GameController class is also a Singleton that acts as the locator for the Player class. The Player class also contains 3 events that the AudioPlayer and UpdateUI classes are subscribed to. These events help keep our code decoupled since we don't have to notify every system that relies on the Player class.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
