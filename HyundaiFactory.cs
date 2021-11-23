namespace AbstractFactory1
{
    class HyundaiFactory : ICarmaker
    {
        public ISedan CreateSedan()
        {
            return new HyundaiHB20();
        }

        public ISuv CreateSuv()
        {
            return new HyundaiCreta();
        }
    }
}
