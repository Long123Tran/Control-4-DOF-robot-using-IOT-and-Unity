using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayAngle : MonoBehaviour
{
    public Scrollbar scrollBar;
    // Start is called before the first frame update
    private TextMeshProUGUI angle;
    void UpdateAngle()
    {
        angle.text = scrollBar.value.ToString();
    }
}
