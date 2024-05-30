using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImageFound : MonoBehaviour
{
    public TextMeshProUGUI scanText;
    public GameObject controlPanel;
    public GameObject scan;
    // Start is called before the first frame update
    public void FoundImage()
    {
        scanText.text = "Image found!!!";
        scan.SetActive(false);
        controlPanel.SetActive(true);

    }

}
