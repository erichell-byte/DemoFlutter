using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    [SerializeField] private string url;

    public void OpenStringUrl()
    {
        Application.OpenURL(url);
    }
}
