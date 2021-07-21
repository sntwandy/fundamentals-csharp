using System;

namespace net
{
  class School {
    /* Attributes */
    public string name;
    public string address;
    public int yearFoundation;

    internal string ceo = "Megan Herrera";

    public void Sound ()
    {
      /* TODO */
      Console.Beep(5000, 3000);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");
      var mySchool = new School();

      mySchool.name = "Platzi Academy";
      mySchool.address = "Calle de la Plata, 1";
      mySchool.yearFoundation = 1999;
      Console.WriteLine("SOUND");
      mySchool.Sound();
    }
  }
}
