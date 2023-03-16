using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManger : MonoBehaviour
{
    public static int MinCount;
    public static int SecCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondsBox;
    public GameObject MillisBox;


    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("F0");
        MillisBox.GetComponent<Text>().text = "" + MilliDisplay;

        if(MilliCount >= 10)
        {
            MilliCount = 0;
            SecCount += 1;
        }

        if(SecCount <= 9)
        {
            SecondsBox.GetComponent<Text>().text = "0" + SecCount + ".";
        }
        else
        {
            SecondsBox.GetComponent<Text>().text = "" + SecCount + ".";
        }

        if(SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if(MinCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinCount + ":";

        }
    }
}
