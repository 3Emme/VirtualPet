using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class VirtualPet
  {
    public string Name { get; set;}
    public int Age { get; set;}
    public int Food { get; set;}
    public int Happiness { get; set;}
    public int Stamina { get; set;}
    public VirtualPet (string name)
    {
      Name = name;
      Age = 1;
      Food = 100;
      Happiness = 100;
      Stamina = 100;
    }
    public void Eat()
    {
      Food += 10;
    }
    public void Sleep()
    {
      Stamina += 10;
    }
    public void Play()
    {
      Happiness += 10;
    }
  }
}