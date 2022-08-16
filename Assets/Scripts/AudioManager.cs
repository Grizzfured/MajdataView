using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class AudioManager : MonoBehaviour
{
    public AudioSource SE_Answer;
    public AudioSource SE_Break;
    public AudioSource SE_Slide;
    public AudioSource SE_Ex;
    public AudioSource SE_Touch;
    public AudioSource SE_TouchHold;
    public AudioSource SE_Hanabi;
    public AudioSource SE_AllPerfect;
    public AudioSource BGM;

    private uint TouchHoldSignal;

    AudioTimeProvider timeProvider;

    // Start is called before the first frame update
    void Start()
    {
        TouchHoldSignal = 0u;
        timeProvider = GameObject.Find("AudioTimeProvider").GetComponent<AudioTimeProvider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadBGM(string path, float speed)
    {
        StartCoroutine(LoadAudio(path + "/track.mp3", speed, BGM));
    }

    public IEnumerator LoadAudio(string path, float speed, AudioSource target)
    {
        path = "file:///" + path;
        Debug.Log(path);
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(path, AudioType.MPEG))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(www.error);
            }
            else
            {
                target.clip = DownloadHandlerAudioClip.GetContent(www);
                StartCoroutine(waitFumenStart());

            }
        }
    }

    IEnumerator waitFumenStart()
    {
        while (timeProvider.AudioTime <= 0) yield return new WaitForEndOfFrame();
        while (BGM.clip.loadState != AudioDataLoadState.Loaded) yield return new WaitForEndOfFrame();
        BGM.Play();
    }

    public void PlaySE_Tap(bool isBreak = false, bool isEx = false)
    {
        if (isEx)
        {
            //SE_Ex.Stop();
            SE_Ex.Play();
        }
        else
        {
            //SE_Answer.Stop();
            SE_Answer.Play();
        }
        if (isBreak)
        {
            //SE_Break.Stop();
            SE_Break.Play();
        }
    }

    public void PlaySE_Slide()
    {
        //SE_Slide.Stop();
        SE_Slide.Play();
    }

    public void PlaySE_Touch(bool isHanabi = false)
    {
        //SE_Answer.Stop();
        SE_Answer.Play();

        //SE_Touch.Stop();
        SE_Touch.Play();

        if (isHanabi)
        {
            //SE_Hanabi.Stop();
            SE_Hanabi.Play();
        }
    }

    public void PlaySE_TouchHold(bool head, bool isHanabi = false)
    {
        if (head)
        {
            //SE_Answer.Stop();
            SE_Answer.Play();

            TouchHoldSignal++;
            //SE_TouchHold.Stop();
            SE_TouchHold.Play();
        }
        else
        {
            //SE_Answer.Stop();
            SE_Answer.Play();

            //SE_Touch.Stop();
            SE_Touch.Play();

            TouchHoldSignal--;
            if (TouchHoldSignal == 0)
            {
                // 理论上来说 不会出现两个TouchHold重叠的情况 但是为了保证所有情况都不会出问题 还是增加了信号量的机制
                SE_TouchHold.Stop();
            }
            if (isHanabi)
            {
                //SE_Hanabi.Stop();
                SE_Hanabi.Play();
            }
        }
    }

    public void PlaySE_AllPerfect()
    {
        //SE_AllPerfect.Stop();
        SE_AllPerfect.Play();
    }
}
