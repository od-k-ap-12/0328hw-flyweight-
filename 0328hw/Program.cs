using _0328hw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0328hw
{
    public abstract class MilitaryEquipment {
    public string Sprite { get;set; }
    protected int Speed { get; set; }
    protected int Power { get; set; }
    protected string Position { get; set; }
    public abstract void Show(string Position);
};

public class Infantry : MilitaryEquipment
{
        public Infantry()

        {;
            Sprite = "Light Infantry";
            Speed = 20;
            Power = 10;
        }

        public override void Show(string _Position)
        {
            Position=_Position;
            Console.WriteLine("Light Infantry "+Position);
        }
    }
};

public class Vehicle : MilitaryEquipment
{
    public Vehicle()

    {
        ;
        Sprite = "Vehicle";
        Speed =70;
        Power = 0;
    }

    public override void Show(string _Position)
    {
        Position = _Position;
        Console.WriteLine(Sprite + "Vehicle " + Position);
    }
};
public class HeavyLandCombatEquipment : MilitaryEquipment
{
    public HeavyLandCombatEquipment()

    {
        ;
        Sprite = "Heavy Land Combat Equipment";
        Speed = 15;
        Power = 150;
    }

    public override void Show(string _Position)
    {
        Position = _Position;
        Console.WriteLine("Heavy Land Combat Equipment " + Position);
    }
}
public class LightLandCombatEquipment : MilitaryEquipment
{
    public LightLandCombatEquipment()

    {
        ;
        Sprite = "Light Land Combat Equipment";
        Speed = 50;
        Power = 30;
    }

    public override void Show(string _Position)
    {
        Position = _Position;
        Console.WriteLine("Light Land Combat Equipment " + Position);
    }
}
public class Aircraft : MilitaryEquipment
{
    public Aircraft()

    {
        ;
        Sprite = "Aircraft";
        Speed = 300;
        Power = 100;
    }

    public override void Show(string _Position)
    {
        Position = _Position;
        Console.WriteLine("Aircraft " + Position);
    }
}


class CharacterFactory
{
	List<MilitaryEquipment> Equipment;
	public MilitaryEquipment GetEquipment(MilitaryEquipment ME)
    {

        if (Equipment.Where(t => t.Sprite == ME.Sprite).Count() == 0)
        {
            Equipment.Add(ME);
        }
        return Equipment.Where(t => t.Sprite == ME.Sprite).FirstOrDefault();
    }
};
internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

