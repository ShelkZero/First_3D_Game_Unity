using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Song : MonoBehaviour
{
    public GameObject BGMusicl;
    private AudioSource audioSrcl;
    public GameObject[] objs11;

    void Awake()
    {
        objs11 = GameObject.FindGameObjectsWithTag("Song");

        if (objs11.Length == 0)
        {
            BGMusicl = Instantiate(BGMusicl);
            BGMusicl.name = "BGMusicl";
            DontDestroyOnLoad(BGMusicl.gameObject);
        }
        else
        {
            BGMusicl = GameObject.Find("BGMusicl");
        }
    }

    void Start()
    {
        audioSrcl = BGMusicl.GetComponent<AudioSource>();
    }
}