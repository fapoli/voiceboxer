# VoiceBoxer
A Unity component to handle sounds. It can group sounds and play them in random order, or in a sequence.

## Package Contents
The project is divided into 2 folders:

**Prefabs** contains the actual prefab (called AudioManager) that should be added to your scene.

**Scripts** contains the code for the component, which should be used as a singleton.

## Usage
Just add the AudioManager prefab into your scene, populate it with sounds and call the singleton from your code. There are *three* main functions that you can invoke:

**void Play(AudioClip clip, float volume = 1f)** Plays an external AudioClip. 

    AudioManager.instance.Play(someAudioClip);

**void Play(string groupName)** Plays a random sound from the group.

    AudioManager.instance.Play("pickup-coin");


**void PlaySequence(string groupName)** Plays the next sound in the group (preserves order).

    AudioManager.instance.PlaySequence("pickup-coin");

