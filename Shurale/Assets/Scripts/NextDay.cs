using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NextDay : MonoBehaviour
{

    public Text text;
    public int day_text = 0;

    public void UpdateDay(DayCounter daycounter){
        day_text = daycounter.now;
        text.text = day_text.ToString();
        Debug.Log(day_text + "Сейчас");
    }

}
