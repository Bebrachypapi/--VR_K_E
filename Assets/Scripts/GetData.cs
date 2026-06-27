using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class GetData : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GetDataFromUrl());
    }

    IEnumerator GetDataFromUrl()
    {
        string url = "https://karasevv.com/testtin/axi/data.txt";
        
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Ответ от сервера: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Ошибка запроса: " + request.error);
            }
        }
    }
}