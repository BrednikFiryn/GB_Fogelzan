using UnityEngine;

public class TimeControl : MonoBehaviour
{
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
