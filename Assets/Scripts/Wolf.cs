namespace Zoo
{
    class Wolf : Animal, ICarnivore
    {
        public void Start()
        {
            message = "awooooeee";
        }

        public void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "gromm grramm hmmm loooooeefly";
        }
    }
}
