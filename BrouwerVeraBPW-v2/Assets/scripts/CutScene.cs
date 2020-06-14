using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{

    public GameObject Audio;
    public GameObject Audio2;
    public GameObject MainCamera;
    public GameObject CutsceneCamera;
    public GameObject ParticleSystem;
    public GameObject Timeline;

    void OnCollisionEnter()
    {
       
        Audio.SetActive(false);
        Audio2.SetActive(true);
        CutsceneCamera.SetActive(true);
        MainCamera.SetActive(false);
        ParticleSystem.SetActive(true);
        Timeline.SetActive(true);

    }


}
