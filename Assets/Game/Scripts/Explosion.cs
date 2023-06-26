using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andremani.VisualDesign2D
{
    public class Explosion : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Animator animator;
        [SerializeField] private AudioSource audioSource;

        private void Start()
        {
            spriteRenderer.enabled = false;
            animator.enabled = false;
        }

        public void Explode()
        {
            spriteRenderer.enabled = true;
            animator.enabled = true;
            animator.Play("explosion", 0, 0);
            audioSource.Play();
        }

        public void OnAnimationEnd()
        {
            spriteRenderer.enabled = false;
        }
    }
}