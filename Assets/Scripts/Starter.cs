using UnityEngine;

public class Starter : MonoBehaviour {

    Persons _persons;

    // Start is called before the first frame update
    void Start() {
        _persons = new Persons();
        //Persons _persons = ScriptableObject.CreateInstance<JsonLoader>().LoadingJson<Persons>("PersonsConfig.json");
        JsonLoader jLoader = new JsonLoader();
        Person person = jLoader.LoadingJson<Person>("PersonConfig.json");
        //_persons = jLoader.LoadingJson<Persons>("PersonsConfig.json");

        Debug.Log(person.Name);

        //foreach (Person person in _persons._Persons) {
        //    Debug.Log("name: " + person._Name + ", age: " + person._Age);
        //}
    }
}
