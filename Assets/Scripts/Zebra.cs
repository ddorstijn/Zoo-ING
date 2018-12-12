namespace Zoo
{
    class Zebra : Animal, IHerbivore
    {
        void Start()
        {
            message = "zebra zebra";
        }

        public void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "munch munch zank yee bra";
        }
    }
}
