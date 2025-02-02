using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fapoli.VoiceBoxer {

public class VoiceBoxer : MonoBehaviour {
    public static VoiceBoxer instance { get; private set; }

    [SerializeField] private List<AudioClip> letters;


    private Dictionary<string, AudioClip> _letterMap;
    private AudioSource _audioSource;

    private void Start() {
        _audioSource = GetComponent<AudioSource>();
        _letterMap = new Dictionary<string, AudioClip>();

        foreach (var l in letters)
            _letterMap.Add(l.name, l);

        instance = this;
    }

    public void Speak(string letter) {
        if (_letterMap.ContainsKey(letter.ToLower()))
            _audioSource.PlayOneShot(letterMap[letter.ToLower()]);
        else if (letter == ".")
            _audioSource.PlayOneShot(letterMap["longblank"]);
        else if (letter == " ")
            _audioSource.PlayOneShot(letterMap["blank"]);
    }

    public void Talk(string text) {
        StartCoroutine(DoTalk(text));
    }

    private IEnumerator DoTalk(string text, float delay = 0.03f) {
        for (var i = 0; i < text.Length; i++) {
            Speak(text[i].ToString());
            yield return new WaitForSeconds(delay);
        }
    }
}
}