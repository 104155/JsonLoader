using System.IO;
using UnityEngine;

[System.Serializable]
class JsonLoader {
    public T LoadingJson<T>(string _fileName) {
        string _filePath = Path.Combine(Application.streamingAssetsPath + "/JSON/", _fileName);
        string _dataAsJson = File.ReadAllText(_filePath);
        Debug.Log(_dataAsJson);
        T _newObject = JsonUtility.FromJson<T>(_dataAsJson);
        //T _newObject = JsonSerializer.Deserialize<T>(_dataAsJson)!;
        return _newObject;
    }
}
