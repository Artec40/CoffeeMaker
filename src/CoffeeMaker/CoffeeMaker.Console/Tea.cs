namespace CoffeeMaker.ConsoleApp
{
    /// <summary>
    /// Это чаёк.
    /// </summary>
    public class Tea : Drink
    {
        /// <summary>
        /// Тип чаёчка.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Инициализируем чаёк.
        /// </summary>
        /// <param name="volume"> Значения для поля объёма. </param> 
        /// <param name="type"> Значения для поля типа. </param>
        /// <param name="price"> Значения для поля цены. </param>
        public Tea(int volume, string type, Money price) : base(volume, price)
        {
            this.Type = type;
        }
    }
}
