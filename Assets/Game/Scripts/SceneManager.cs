using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Andremani.VisualDesign2D
{
    public class SceneManager : MonoBehaviour
    {
        [SerializeField] private string sceneToLoad;
        [SerializeField] private Button changeSceneButton;

        private void Start()
        {
            changeSceneButton.onClick.AddListener(() => SceneChange());
        }

        public void SceneChange()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
        }
    }
}