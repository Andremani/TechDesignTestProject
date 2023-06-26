using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andremani.VisualDesign2D
{
    public class Skeleton : MonoBehaviour
    {
        [SerializeField] private Explosion explosionController;
        [SerializeField] private Animator skeletonAnimator;

        private bool isAlive = true;

        private void OnMouseUpAsButton()
        {
            if(isAlive)
            {
                isAlive = false;
                explosionController.Explode();
                skeletonAnimator.SetBool("dead", true);
            }
        }
    }
}