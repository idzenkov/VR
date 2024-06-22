using UnityEngine;
using System.IO;
using System;


public class SaveLoad : MonoBehaviour
{
    public Transform targetObject; // Объект, позицию которого нужно сохранить
    public string filePath = Application.dataPath+"/save.json"; // Путь к файлу для сохранения
    public void Start()
    {
        

    }
    public void SavePositionToJSON()
    {
        // Проверяем, что целевой объект существует
        if (targetObject == null)
        {
            Debug.LogError("Target object not set.");
            return;
        }

        
        
            
        string jsonData = JsonUtility.ToJson(targetObject.position);

        
        File.WriteAllText(filePath, jsonData);

        Debug.Log("Position saved successfully!");
    }

    public void LoadPositionFromJSON()
    {
        // Проверяем, существует ли файл
        if (!File.Exists(filePath))
        {
            Debug.LogError("File not found at " + filePath);
            return;
        }

        // Читаем содержимое файла
        string jsonData = File.ReadAllText(filePath);

        // Разделяем данные на имя и позицию
        string[] data = jsonData.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        Debug.Log(data);

        string positionJson = data[0] + "," + data[1] + "," + data[2];
        Debug.Log(positionJson);

        // Пытаемся десериализовать имя и позицию
        try
        {

            targetObject.position = JsonUtility.FromJson<Vector3>(positionJson);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error parsing JSON: " + e.Message);
        }

        Debug.Log("Position loaded successfully!");
    }
}

