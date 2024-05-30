using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using M2MqttUnity;
using TMPro;
using uPLibrary.Networking.M2Mqtt.Messages;


public class ReadInput : MonoBehaviour
{
    private float motor1;
    private float motor2;
    private float motor3;
    private float motor4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput1(string s)
    {
        motor1 = float.Parse(s);
        Debug.Log(string.Format("Motor 1 angle: {0}",motor1));
    }

    public void ReadStringInput2(string s)
    {
        motor2 = float.Parse(s);
        Debug.Log(string.Format("Motor 2 angle: {0}", motor2));
    }

    public void ReadStringInput3(string s)
    {
        motor3 = float.Parse(s);
        Debug.Log(string.Format("Motor 3 angle: {0}", motor3));
    }

    public void ReadStringInput4(string s)
    {
        motor4 = float.Parse(s);
        Debug.Log(string.Format("Motor 4 angle: {0}", motor4));
    }
}
