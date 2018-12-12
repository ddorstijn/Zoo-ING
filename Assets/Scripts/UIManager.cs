using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace Zoo
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private Text textAnimalName;

        public void GiveLeaves()
        {
            var herbivores = FindObjectsOfType<Animal>().OfType<IHerbivore>();
            foreach (var animal in herbivores) {
                animal.EatLeaves();
            }
        }

        public void GiveMeat()
        {
            var carnivores = FindObjectsOfType<Animal>().OfType<ICarnivore>();
            foreach (var animal in carnivores) {
                animal.EatMeat();
            }
        }

        public void DoTrick()
        {
            var tricksters = FindObjectsOfType<Animal>().OfType<ITricks>();
            foreach (var animal in tricksters) {
                animal.PerformTrick();
            }
        }

        public void SayHello()
        {
            string name = textAnimalName.text;
            foreach (var animal in FindObjectsOfType<Animal>()) {
                if (name == "") {
                    animal.SayHello();
                    continue;
                }

                if (animal.Name == name) {
                    animal.SayHello();
                }
            }
        }
    }
}