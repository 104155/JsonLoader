using System.IO;
using UnityEngine;

//[System.Serializable]
class JsonLoader {
    public T LoadingJson<T>(string fileName) {
        string filePath = Path.Combine(Application.streamingAssetsPath + "/JSON/", fileName);
        string dataAsJson = File.ReadAllText(filePath);
        T newObject = JsonUtility.FromJson<T>(dataAsJson);
        return newObject;
    }
}
