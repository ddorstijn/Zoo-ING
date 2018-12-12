namespace Zoo
{
    class Lion : Animal, ICarnivore
    {
        public void Start()
        {
            message = "roooaoaaaaar";
        }

        public void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }
    }
}
