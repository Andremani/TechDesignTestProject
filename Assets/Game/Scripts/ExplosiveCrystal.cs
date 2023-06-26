using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andremani.VisualDesign2D
{
    public class ExplosiveCrystal : MonoBehaviour
    {
        [SerializeField] private Explosion explosionController;
        [SerializeField] private SpriteRenderer spriteRenderer;

        [SerializeField] private List<Sprite> crystalSizes;

        private int currentSize;

        private void Start()
        {
            currentSize = crystalSizes.Count;
            spriteRenderer.sprite = crystalSizes[(crystalSizes.Count - 1) - (currentSize - 1)];
        }

        private void CrystalShrink()
        {
            if (currentSize > 0)
            {
                currentSize--;
                explosionController.Explode();

                if(currentSize == 0)
                {
                    spriteRenderer.sprite = null;
                }
                else
                {
                    spriteRenderer.sprite = crystalSizes[(crystalSizes.Count - 1) - (currentSize - 1)];
                }
            }
        }

        private void OnMouseUpAsButton()
        {
            CrystalShrink();
        }
    }
}