namespace AbstractFactory1
{
    class Client
    {
        ISuv suv;
        ISedan sedan;

        public Client(ICarmaker factory) 
        {
            suv = factory.CreateSuv();
            sedan = factory.CreateSedan();
        }

        public string GetSuvDetails() 
        {
            return suv.ShowDetails();
        }

        public string GetSedanDetails() 
        {
            return sedan.ShowDetails();
        }
    }
}
