using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class SoundPlay : MonoBehaviour
{
  private AudioSource button_AudioSource;

  // Use this for initialization
  void Start()
  {
    button_AudioSource = GetComponent<AudioSource>();
  }

  public void ButtonClick()
  {
    button_AudioSource.Play();
  }
}
