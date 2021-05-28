using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class MusicSnapshotChanger : MonoBehaviour
{

    // audio mixer snapshots
    public AudioMixerSnapshot first;
    public AudioMixerSnapshot second;
    public AudioMixerSnapshot third;
    public AudioMixerSnapshot fourth;
    public AudioMixerSnapshot fifth;

    //subscribe all functions to respective events
    private void Start()
    {
        Messenger.AddListener(GameEvent.EVENT_0, ChangeToPreRememberMe);
        Messenger.AddListener(GameEvent.EVENT_1, ChangeToRememberMe);
        Messenger.AddListener(GameEvent.EVENT_3, ChangeToLowkey);
        Messenger.AddListener(GameEvent.EVENT_6, ChangeToAdoreYou);
    }
    public void ChangeToPreRememberMe()
    {
        second.TransitionTo(.01f);
    }

    public void ChangeToRememberMe()
    {
        third.TransitionTo(.01f);
    }

    public void ChangeToLowkey()
    {
        fourth.TransitionTo(1.7f);
    }

    public void ChangeToAdoreYou()
    {
        fifth.TransitionTo(1.7f);
    }
}