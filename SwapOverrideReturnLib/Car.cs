namespace SwapOverrideReturnLib
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Сравнивает между собой свойства текущего и переданного объекта Car
        /// </summary>
        /// <param name="obj">Ожидается объект типа данных Car</param>
        /// <returns>Возвращает false при сравнении не с объектом типа Car.
        /// Возвращает true если значения всех свойств у двух объектов Car совпадают</returns>
        public override bool Equals(object obj)
        {
            if (obj is Car car)
            {
                return this.Model == car.Model && this.Color == car.Color && this.Description == car.Description;
            }
            return false;
        }
        /// <summary>
        /// Возвращает hash код объекта Car
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Model.GetHashCode() ^ Color.GetHashCode() ^ Description.GetHashCode();
        }
    }
}
