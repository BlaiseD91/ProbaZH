using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaZH;

internal class Person
{
    private string name;
    private int age;
    public string Name { get { return name; } }
    public int Age { get { return age; } }
    public Person()
    {
        
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual string GetInfo() {  return $"Név: {Name} - {Age} éves"; }
}
