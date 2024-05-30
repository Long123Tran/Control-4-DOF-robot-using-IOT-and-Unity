using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScanClick1 : MonoBehaviour
{
    public GameObject imageTarget;

    public GameObject scanButton;

    public GameObject scanText;
    // Start is called before the first frame update
    public void Scan()
    {
        scanButton.SetActive(false);
        scanText.SetActive(true);
        Debug.Log("Scanning...");
        imageTarget.SetActive(true);
    }

}
