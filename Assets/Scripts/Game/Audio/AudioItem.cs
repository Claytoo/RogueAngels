using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioItem : MonoBehaviour
{
    public void PlayAudio()
    {
        SoundManager.instance.PlaySound(4);
    }
}
