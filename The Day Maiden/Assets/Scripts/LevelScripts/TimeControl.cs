using UnityEngine;

public class TimeControl : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void TimeStopPlay()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

        else
        {
            Time.timeScale = 1;
        }
    }
}
