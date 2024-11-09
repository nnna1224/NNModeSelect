using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioSource audio;
    AudioClip Music;
    bool played;

    [SerializeField] private string songName;

    void Start()
    {
        GManager.instance.Start = false;
        audio = GetComponent<AudioSource>();
        Music = (AudioClip)Resources.Load("Musics/" + songName);  //変数Musicにオーディオファイルを入れる
        played = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !played)
        {
            GManager.instance.Start = true;
            GManager.instance.StartTime = Time.time;
            played = true;
            audio.PlayOneShot(Music);
        }
    }
}
