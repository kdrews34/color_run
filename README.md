# color_run
Controls:
A -> Move left
S -> Move backwards
D -> Move right
W -> Move forward
Space -> Jump
E -> Alternate Between color

Game:
The game is a platformer where the goal is to reach the end. But the
way to progress is by using colors to activate platforms. If there is player
does no switch the platform, they can not progress. Of course every platform
needs challenges so we implemented some animation platforms and physics. To 
help make the game fit its theme which is the reach the end.

Physics:
Box Colliders - every object in the game has a box collider so player cannot fall or pass through them
Hinge Joint - one of the platforms rotates on a hinge joint for extra challenge
Spring Joint - a hanging ball flails around on a spring joint as an added obstacle

Lights:
two wall lights - lights added to wall to simulator torches
end of level light - light added to end of level to show that it is the destination

Sounds:
jump sound - jumping sound for added realism
death sound - death sound to let you know you messed up
switch sound - sound that indicates the platform colors have been switched

textures:
wall texture - general dark ominous wall texture
floor texture - made to look like spikes so you know not to fall
end platforms texture - differentiated from wall and floor to signify safe zones

Mechanim:
Intro Character - Fernando Martinez
This Character is the intro character that brought you through the color world
And no he watches you complete the mission to obtain color
Cube Animation - Kevin Andrews
Is a collectible that you grab when you complete the level. It has an
animation to let the player know you need to grab it
Levitating platform - Trishla Shah
Its a platform that goes up down, effecting how the player navigates the
level

**AI: our game design really doesn't warrant any AI use. it is a platformer at its core and there are no enemies, so we were unable to find a place for any kind of AI that wasn't forced and didn't completely undermine the vision of the game
