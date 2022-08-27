using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static SoundManager instance;

   private AudioSource _audioSource;
   public AudioClip[] clips;

   private void Awake()
   {
      instance = this;
   }

   private void Start()
   {
      _audioSource = GetComponent<AudioSource>();
   }

   public void PlaySound(int index)
   {
      _audioSource.PlayOneShot(clips[index]);
   }
}
