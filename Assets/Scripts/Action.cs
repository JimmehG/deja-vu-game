using System;
using UnityEngine;

abstract public class Action : MonoBehaviour
{
    abstract public void Perform();
    public AudioClip audioClip;
}