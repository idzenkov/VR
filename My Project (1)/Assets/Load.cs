using UnityEngine;
using System.IO;
using System;

public class Load : MonoBehaviour
{
    public GameObject targetObject; // ������, ������� �������� ����� ���������
    public string filePath = Application.dataPath + "/save.json"; // ���� � ����� ��� ��������

    public void LoadPositionFromJSON()
    {
        // ���������, ���������� �� ����
        if (!File.Exists(filePath))
        {
            Debug.LogError("File not found at " + filePath);
            return;
        }

        // ������ ���������� �����
        string jsonData = File.ReadAllText(filePath);

        // ��������� ������ �� ��� � �������
        string[] data = jsonData.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        Debug.Log(data);

        string positionJson = data[0]+"," + data[1] + "," + data[2] ;
        Debug.Log(positionJson);

        // �������� ��������������� ��� � �������
        try
        {
            
            targetObject.transform.position = JsonUtility.FromJson<Vector3>(positionJson);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error parsing JSON: " + e.Message);
        }

        Debug.Log("Position loaded successfully!");
    }
}
