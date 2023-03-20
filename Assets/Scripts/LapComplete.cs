using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    void OnTriggerEnter()
    {
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if(LapTimeManger.RawTime <= RawTime)
        {
        if(LapTimeManger.SecCount <= 9)
        {
            SecDisplay.GetComponent<Text>().text = "0" + LapTimeManger.SecCount + ".";
        }
        else
        {
            SecDisplay.GetComponent<Text>().text = "" + LapTimeManger.SecCount + ".";
        }

        if (LapTimeManger.MinCount <= 9)
        {
            MinDisplay.GetComponent<Text>().text = "0" + LapTimeManger.MinCount + ".";
        }
        else
        {
            MinDisplay.GetComponent<Text>().text = "" + LapTimeManger.MinCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManger.MilliCount;
        }

        PlayerPrefs.SetInt("MinSave", LapTimeManger.MinCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManger.SecCount);
        PlayerPrefs.SetFloat("MilliSave", LapTimeManger.MilliCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeManger.RawTime);
        LapTimeManger.RawTime = 0;

        LapTimeManger.MinCount = 0;
        LapTimeManger.SecCount = 0;
        LapTimeManger.MilliCount = 0;

        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
