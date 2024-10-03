using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ActionSetter : MonoBehaviour
{
    public SteamVR_ActionSet primarySet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && primarySet != null)
        {
            bool active = primarySet.IsActive();
            active = !active;

            if (active)
                primarySet.Activate();
            else
                primarySet.Deactivate();

            print("Active set is:" + primarySet.IsActive());
        }
    }
}
