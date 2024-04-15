namespace Lab6Csh
{
    public abstract class Transport
    {
        public abstract double Speed { get; }
        public abstract double CargoCapacity { get; }
        public abstract double Range { get; }

        public abstract string GetDescription();
    }



    public abstract class Car(double speed, double cargoCapacity, double range) : Transport
    {
        public override double Speed { get; } = speed;
        public override double CargoCapacity { get; } = cargoCapacity;
        public override double Range { get; } = range;

        public override string GetDescription()
        {
            return $"Автомобиль грузоподъемностью в {CargoCapacity} может проехать {Range}";
        }
    }

    public abstract class Airplane(double speed, double cargoCapacity, double range) : Transport
    {
        public override double Speed { get; } = speed;
        public override double CargoCapacity { get; } = cargoCapacity;
        public override double Range { get; } = range;

        public override string GetDescription()
        {
            return $"Самолет грузоподъемностью в {CargoCapacity} может проехать {Range}";
        }
    }

    public abstract class Ship(double speed, double cargoCapacity, double range) : Transport
    {
        public override double Speed { get; } = speed;
        public override double CargoCapacity { get; } = cargoCapacity;
        public override double Range { get; } = range;

        public override string GetDescription()
        {
            return $"Корабль грузоподъемностью в {CargoCapacity} может проехать {Range}";
        }
    }
    public class Titanic(double speed, double cargoCapacity, double range) : Ship(speed, cargoCapacity, range) {}
    public class Sedan(double speed, double cargoCapacity, double range) : Car(speed, cargoCapacity, range) {}
    public class Boeing747(double speed, double cargoCapacity, double range) : Airplane(speed, cargoCapacity, range) {}

    class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan = new(120, 500, 5000);
            Boeing747 boeing747 = new(900, 150000, 12000);
            Titanic titanic = new(15, 50000, 7000);

            Console.WriteLine(sedan.GetDescription());
            Console.WriteLine(boeing747.GetDescription());
            Console.WriteLine(titanic.GetDescription());
        }
    }
}