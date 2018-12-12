using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Pig : Animal, ICarnivore, IHerbivore, ITricks
    {
        public void Start()
        {
            message = "oink oink";
        }

        public void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "munch munch oink";
        }

        public void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "nomnomnom oink thx";
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
