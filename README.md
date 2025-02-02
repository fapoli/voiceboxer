# VoiceBoxer
A Unity Component which allows funny dialogues with gibberish sounds, as seen in some games like *Animal Crossing* or *Celeste*.

## Package Contents
The project is divided into 3 folders:

**Prefabs** contains the actual prefab (called VoiceBoxer) that should be added to your scene.

**SFX** contains sounds for each letter of the alphabet and some blank sounds for pauses. This can be replaced with other voices if you like.

**Scripts** contains the code for the component, which should be used as a singleton.

## Usage
Just add the VoiceBoxer prefab into your scene, and call the singleton from your code. There are *two* main functions that you can invoke:

**Speak(string letter)** plays a single letter.

    VoiceBoxer.instance.Speak("A");

**Talk(string text, [float delay])** calls the *Speak* function multiple times inside a coroutine (for a whole text)

    VoiceBoxer.instance.Talk("Hi, I speak in a funny way.");

## Customization
You can add some separation between words by passing the optional delay parameter in the *Talk* function. The default value is *0.03*

    VoiceBoxer.instance.Talk("Hi, I speak in a funny way.", 0.05f);

