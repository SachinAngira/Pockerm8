using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Web : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {

        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/Pockerm8%20Backend/Date.php"))
        {
            yield return www.Send();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);

            }
            else {
                Debug.Log(www.downloadHandler.text);

                byte[] results = www.downloadHandler.data;
            
            }
        }

    }
}
