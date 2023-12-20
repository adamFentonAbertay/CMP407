ThirdPersonController is mainly an asset from the store by Unity but does have a substantial amount of code from myself involving audio - My code is marked with //ADAM and //ADAMEND
This script is not in this folder but can be found on the PlayerArmature within the scene or at Assets/StarterAssets/ThirdPersonController/Scripts/ThirdPersonController.cs
This also includes the old code for footsteps through Unitys system which is completely ignored;

KNOWN ISSUES
-Moving between biomes too quickly will cause the transitionary music to be skipped 
-Little robot buddy can get stuck on the ramp and slide, causing constant moving music (gameplay bug not audiotary).

List of the features and where to find them:

##REQUIRED FEATURES##

SOUND FILE PLAYBACK 
-Looping sounds - music, buddy rolling
-One shot sounds - Players footsteps, Inital contact with lava stinger.
-Concurrent playback - Sounds/music playing all together no issues, mixed with Wwise soundscape/mixer

SPATIAL LOCALISATION
-Player footsteps and buddy rolling

ATTENUATION
-Player footsteps and buddy rolling
(Not on lava stinger as this is loaded and utilised in Wwise as music, not SFX).

REVERB
-Reverb rooms 1 and 2 in front of player (tunnel to lava)
-Reverb transitonary portal in doorway between room 1 and 2.

COMPRESSED FILE FORMATS
-SFX as Vorbis
-Music files as PCM

##PROJ FOCUS FEATURES##

DYNAMIC MUSIC
-Three different soundtracks for biomes
-Smooth transitions between different biomes
-Health-reactive music (lower HP makes instruments come in (RTPC))


RTPC (Low Pass)
-Underwater area

TRANSITIONS
-Moving between biomes - see known issues

STINGERS
-Initial lava contact

CALLBACKS
-Flashing screen upon low hp

