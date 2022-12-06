using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlowed : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SlowMode();
        }

        if (Input.GetKeyUp(KeyCode.E))
        {

            NormalMode();
        }
    }

    public void SlowMode()
    {
        Time.timeScale = 0.5f;
    }

    public void NormalMode()
    {
        Time.timeScale = 1f;
    }

}
