namespace InterfaceAssignment
{
    class Pet
    {
        private IAmMammal _amMammal;
        private ICanFly _canFly;

        public Pet(IAmMammal amMammal, ICanFly canFly)
        {
            _amMammal = amMammal;
            _canFly = canFly;
        }

        public bool IsMammal()
        {
            return _amMammal.IsMammal();
        }        

        public bool CanFly()
        {
            return _canFly.CanFly();
        }
    }
}
