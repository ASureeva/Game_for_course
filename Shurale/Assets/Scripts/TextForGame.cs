using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextForGame : MonoBehaviour
{
    public Text text;
    public int day;

    public void UpdateText(DayCounter daycounter)
    {
        day = daycounter.now;
        if (day==1) {
            text.text = "Забери семена урожая \n из первого сарая";
        } else if (day==2) {
            text.text = "Посади урожай на огороде";
        } else if (day==3) {
            text.text = "Забери лейку с водой\n из второго сарая";
        } else if (day==4) {
            text.text = "Полей урожай на огороде";
        } else if (day==5) {
            text.text = "Собери урожай на огороде";
        } else if (day==6) {
            text.text = "Отнеси урожай в третий сарай";
        } else {
            text.text = "хуй";
        }
        Debug.Log(";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
    }
}
