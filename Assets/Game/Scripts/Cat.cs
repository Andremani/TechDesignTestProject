using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andremani.VisualDesign2D
{
    public class Cat : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private List<AudioClip> catClickSounds;

        private void OnMouseUpAsButton()
        {
            AudioClip randomCatSound = catClickSounds[Random.Range(0, catClickSounds.Count)];
            audioSource.PlayOneShot(randomCatSound, 0.5f);
        }
    }
}