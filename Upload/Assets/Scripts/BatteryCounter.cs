using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCounter : MonoBehaviour
{
    // public battery count variable
    public static int numBatteries = 0;

    // call events based on the number of batteries picked up
    public static void CallProgression()
    {
        if (numBatteries == 1)
        {
            Messenger.Broadcast(GameEvent.EVENT_1);
        }
        else if (numBatteries == 3)
        {
            Messenger.Broadcast(GameEvent.EVENT_3);
        }
        else if (numBatteries == 6)
        {
            Messenger.Broadcast(GameEvent.EVENT_6);
        }
    }
}
