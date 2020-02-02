using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoorOpen : MonoBehaviour
{

    void Update()
    {
        if (GameObject.Find("EventSystem").GetComponent<PassDoorOpen>().active) gameObject.GetComponent<ItemInform>().needName = "";
        else gameObject.GetComponent<ItemInform>().needName = "Qifei";
    }
}
