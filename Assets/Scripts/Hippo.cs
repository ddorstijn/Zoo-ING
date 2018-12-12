namespace Zoo
{
    class Hippo : Animal, IHerbivore
    {
        public void Start()
        {
            message = "splash";
        }

        public void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "munch munch lovely";
        }
    }
}
