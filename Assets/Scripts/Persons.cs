using UnityEngine;

[System.Serializable]
public class Persons {
    private Person[] _persons;
    public Person[] _Persons {
        get {
            return _persons;
        }
        set {
            _persons = value;
        }
    }
}
