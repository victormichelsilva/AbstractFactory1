namespace AbstractFactory1
{
    interface ICarmaker
    {
        ISuv CreateSuv();

        ISedan CreateSedan();
    }
}
