using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class VirtualPet
  {
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public int Food { get; set; }
    public int Happiness { get; set; }
    public int Stamina { get; set; }
    public bool IsAlive { get; set; }
    private static List<VirtualPet> _instances = new List<VirtualPet> { };
    public VirtualPet(string name, string breed)
    {
      Name = name;
      Breed = breed;
      Age = 1;
      Food = 100;
      Happiness = 100;
      Stamina = 100;
      IsAlive = true;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public string Eat()
    {
      if (this.IsAlive == false)
      {
        return $"You can't feed {this.Name}. They're dead!";
      }
      this.Food += 12;
      Time();
      return $"You fed {this.Name} their favorite food. Yay!";
    }
    public string Sleep()
    {
      if (this.IsAlive == false)
      {
        return $"You can't put {this.Name} to bed. They're dead!";
      }
      this.Stamina += 12;
      Time();
      return $"You put {this.Name} to bed. Yay!";
    }
    public string Play()
    {
      if (this.IsAlive == false)
      {
        return $"You can't play with {this.Name}. They're dead!";
      }
      this.Happiness += 12;
      string timeMessage = Time();
      return $"You play with {this.Name}. Yay! Also: {timeMessage}";
    }
    public string Time()
    {
      foreach (VirtualPet virtualPet in _instances)
      {
        this.Food -= 2;
        this.Stamina -= 2;
        this.Happiness -= 2;
        this.Age += 1;
       
      }
      foreach (VirtualPet virtualPet in _instances)
      {
        if (this.Food == 0 || this.Stamina == 0 || this.Happiness == 0)
        {
          this.IsAlive = false;
          this.Name = $"{this.Name} (RIP)";
        }
        else if (this.Age == 100)
        {
          this.IsAlive = false;
          return $"{this.Name} lived a full happy life, great job! but it died...";
        }
      }
      return "Your pets take one more step down the passage of time...";
    }
    public static List<VirtualPet> GetAll()
    {
      return _instances;
    }
  }
}