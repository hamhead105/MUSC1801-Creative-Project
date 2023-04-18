using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Director : MonoBehaviour
{
    [SerializeField] private int movieState;
    private Animator stateAnimator;

    [SerializeField] private VideoPlayer intro;
    [SerializeField] private VideoPlayer interview1Video;
    [SerializeField] private VideoPlayer montageVideo;

    [SerializeField] private bool hasFinishedFlag;

    // Start is called before the first frame update
    void Start()
    {
        stateAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Intro 
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 1;
        }

        // What Kinda Music
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 2;
        }

        // Living Room Intro
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 3;
        }

        // Yussef Dayes Interview
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 4;
        }

        // Sensational
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 5;
        }

        // Living Room 2 
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 6;
        }

        // Zutomayo Intro
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 7;
        }

        // Kansaete Kuyashiiwa
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 8;
        }

        // Conclusion
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            stateAnimator.SetTrigger("UseSkip");
            movieState = 9;
        }

        if (hasFinishedFlag)
        {
            print("finish movie");
            movieState++;
            stateAnimator.SetTrigger("UseSkip");
            hasFinishedFlag = false;
        }

        stateAnimator.SetInteger("DirectorState", movieState);
        UpdateVideoStates();
    }

    private void UpdateVideoStates()
    {
        if (movieState == 1)
        {
            intro.Play();
        }
        if (movieState == 4)
        {
            interview1Video.Play();
        }
        if (movieState == 7)
        {
            montageVideo.Play();
        }
    }
}
