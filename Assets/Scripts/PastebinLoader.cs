using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class PastebinLoader : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public string rawPastebinLink;

    private IEnumerator Start()
    {
        yield return StartCoroutine(DownloadText());
    }

    private IEnumerator DownloadText()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(rawPastebinLink))
        {
            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Error downloading text: " + request.error);
            }
            else
            {
                textMeshPro.text = request.downloadHandler.text;
            }
        }
    }
}
