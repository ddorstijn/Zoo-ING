using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, rabbit, wolf;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.Name = "henk";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.Name = "elsa";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.Name = "dora";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.Name = "wally";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.Name = "marty";
            Squirrel stamper = Instantiate(rabbit, transform).GetComponent <Squirrel>();
            stamper.Name = "stamper";
            Wolf kiba = Instantiate(wolf, transform).GetComponent<Wolf>();
            kiba.Name = "kiba";
        }
    }
}
