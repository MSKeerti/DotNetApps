namespace FirstApi.Models
{
    public class CarAccessories
    {
        private IAccessories  _accessories;

        public CarAccessories(IAccessories a)
        {
            _accessories = a;
        }
    }
    public interface IAccessories { }
    public class Stearing : IAccessories { }
    public class Gear : IAccessories { }
    public class Tire : IAccessories { }
    public class Seat : IAccessories { }
}
