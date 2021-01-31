using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceBoxer : MonoBehaviour
{
    public static VoiceBoxer instance { get; private set; }

    public List<AudioClip> letters;

    public Dictionary<string, AudioClip> letterMap;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        letterMap = new Dictionary<string, AudioClip>();

        foreach (var l in letters)
            letterMap.Add(l.name, l);

        instance = this;
    }

    public void Speak(string letter)
    {
        if (letterMap.ContainsKey(letter.ToLower()))
            audioSource.PlayOneShot(letterMap[letter.ToLower()]);
        else if (letter == ".")
            audioSource.PlayOneShot(letterMap["longblank"]);
        else if (letter == " ")
            audioSource.PlayOneShot(letterMap["blank"]);
    }

    public void Talk(string text)
    {
        StartCoroutine(DoTalk(text));
    }

    private IEnumerator DoTalk(string text)
    {
        for (var i = 0; i < text.Length; i++)
        {
            Speak(text[i].ToString());
            yield return new WaitForSeconds(0.03f);
        }
    }


}
