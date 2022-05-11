using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class OnlineVideoLoader : MonoBehaviour
{
    private bool finished = false;
    public VideoPlayer videoPlayer;
    //public string videoUrl = "yourvideourl";

    // Start is called before the first frame update
    void Start()
    {
        //videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        videoPlayer.loopPointReached += EndReached;
        if (finished == true)
        {
            LoadTutorial();
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
       // vp.playbackSpeed = vp.playbackSpeed / 10.0F;
        finished = true;
    }

    void LoadTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
    }

}