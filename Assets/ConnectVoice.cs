using Photon.Voice.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectVoice : MonoBehaviour
{
    void Start()
    {
        GetComponent<Recorder>().UnityMicrophoneDevice = Microphone.devices[0];
    }
}
