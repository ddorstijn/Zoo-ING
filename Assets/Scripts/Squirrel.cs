using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Squirrel : Animal, IHerbivore, ITricks
    {
        void Start()
        {
            message = "Squeeck yo";
        }

        public void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "mnom mnom prrr";
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++) {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
