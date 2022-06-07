using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NextDay : MonoBehaviour
{

    public Text text;
    public Text plot;
    public int day_text = 0;

    public void UpdateDay(DayCounter daycounter){
        day_text = daycounter.now;
        text.text = day_text.ToString();
        Debug.Log(day_text + "Сейчас");      
          if (day_text==1) {
            plot.text = "Забери семена урожая \n из первого сарая";
        } else if (day_text==2) {
            plot.text = "Посади урожай на огороде";
        } else if (day_text==3) {
            plot.text = "Забери лейку с водой\n из второго сарая";
        } else if (day_text==4) {
            plot.text = "Полей урожай на огороде";
        } else if (day_text==5) {
            plot.text = "Собери урожай на огороде";
        } else if (day_text==6) {
            plot.text = "Отнеси урожай в третий сарай";
        } else {
            plot.text = "Все или ничего";
        }
    }

}
