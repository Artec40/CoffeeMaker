namespace CoffeeMaker.ConsoleApp
{
    /// <summary>
    /// Пищевая добавка со стоимостью за одну порцию.
    /// </summary>
    public interface IAdditive
    {
        /// <summary>
        /// Цена
        /// </summary>
        Money Price { get; }
    }
}
