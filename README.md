# Scene Streamer

# Overview
Plugin for Unity. Scene Streamer automatically loads and unloads scenes to help you manage large environments
such as continuous game worlds.

# Example Scene
To play the example scene:
1. Add the scenes Pixel Crushers/Scene Streamer/Example/Scenes/Scene 1 – Scene 6 to your project's Build Settings.
2. Play the scene Pixel Crushers/Scene Streamer/Example/Start. 
3. Walk through the scene. The rooms (Scene 1 – Scene 6) will stream in and out as needed.

# Setup
To set up your project for streamed scenes:
1. Create scenes containing separate geographical areas. Each scene should be contained in a single root GameObject.
Example: See Example/Scenes/Scene 1.
2. At each edge that connects to another scene (a "neighbor"), add a GameObject with a trigger collider. Add a SceneEdge component to the object. Set Current Scene Root to the
root GameObject. Set Next Scene Name to the name of the neighboring scene.
Example: See Scene 1's "Edge to 2" object.
3. Add a Neighboring Scenes component to the scene's root object, and list all of the neighboring scenes. This is optional, but it saves Scene Streamer from having to analyze
the scene when loading at runtime.
4. Add your scenes to the project's build settings.
5. Create a startup scene. Drag the prefab Prefabs/Scene Streamer into the scene. 
  - Set Max Neighbor Distance to specify how many neighboring scenes out from the current scene should be loaded. Increase this to prevent visible "popping" of scenes as they're loaded and unloaded. It also helps to design scene edges around corners so the player can't see scenes being loaded and unloaded.
  - Set Set Start Scene Name to the name of the first scene to load.

# Events and Scripting
To manually load and unload scenes, use SceneStreamer.LoadScene() and UnloadScene().
To check whether a scene is loaded, use SceneStreamer.IsSceneLoaded().
You can also assign your own methods to the SceneStreamer events OnLoading and OnLoaded.

# More Info

Questions: support@pixelcrushers.com

More Pixel Crushers products:

Dialogue System for Unity<br> 
AAA-Quality Dialogue & Quest System<br>
https://assetstore.unity.com/packages/tools/ai/dialogue-system-for-unity-11672

Quest Machine<br>
Procedural & Hand-written Quests<br>
https://assetstore.unity.com/packages/templates/systems/quest-machine-39834

Love/Hate<br>
Give your characters dynamic, emotion-driven relationships<br>
https://assetstore.unity.com/packages/tools/ai/love-hate-33063

