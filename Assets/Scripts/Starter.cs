using UnityEngine;

public class Starter : MonoBehaviour {

    // Start is called before the first frame update
    void Start() {
        Persons persons = new JsonLoader().LoadingJson<Persons>("PersonsConfig.json");

        foreach (Person person in persons.persons) {
            Debug.Log("name: " + person.name + ", age: " + person.age);
        }
    }
}
