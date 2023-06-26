using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andremani.VisualDesign2D
{
    public class FireCrystal : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer fireRenderer;
        [SerializeField] private Animator fireAnimator;

        private bool isBurning = false;

        private void Start()
        {
            fireRenderer.enabled = false;
            fireAnimator.enabled = false;
        }

        private void OnMouseUpAsButton()
        {
            if (!isBurning)
            {
                isBurning = true;

                fireRenderer.enabled = true;
                fireAnimator.enabled = true;
            }
        }
    }
}