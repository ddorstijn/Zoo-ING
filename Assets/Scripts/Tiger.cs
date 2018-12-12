using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Tiger : Animal, ICarnivore, ITricks
    {
        void Start()
        {
            message = "rraaarww";
        }

        public void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "nomnomnom thx wubalubadubdub";
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
