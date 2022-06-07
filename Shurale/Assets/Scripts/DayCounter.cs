using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DayCounter : MonoBehaviour
{
    public int now = 1;

    [SerializeField] private List<Day> days = new List<Day>();
    [SerializeField] public UnityEvent PlayNextDay;


    public void Next(){
        now += 1;
        PlayNextDay.Invoke();
        PlayNextDay.Invoke();
        Debug.Log(now + "nownow");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
