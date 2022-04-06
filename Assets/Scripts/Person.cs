using UnityEngine;

[System.Serializable]
public class Person
{
    public string name;
    public string Name {
        get {
            return name;
        } 
        set {
            name = value;
        }
    }

    public int age;
    public int Age {
        get {
            return age;
        }
        set {
            age = value;
        }
    }
}
