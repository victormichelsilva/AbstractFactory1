namespace AbstractFactory1
{
    class HondaFactory : ICarmaker
    {
        public ISedan CreateSedan()
        {
            return new HondaCivic();
        }

        public ISuv CreateSuv()
        {
            return new HondaCRV();
        }
    }
}
