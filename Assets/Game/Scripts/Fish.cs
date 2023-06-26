using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andremani.VisualDesign2D
{
    public class Fish : MonoBehaviour
    {
        private void OnMouseUpAsButton()
        {
            gameObject.SetActive(false);
        }
    }
}