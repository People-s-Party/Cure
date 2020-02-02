using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassDoorOpen : MonoBehaviour
{
    public GameObject doorA;
    public GameObject doorB;
    public GameObject doorC;
    // Start is called before the first frame update
    void Start()
    {
        doorA = GameObject.Find("passdoorA");
        doorB = GameObject.Find("passdoorB");
        doorC = GameObject.Find("passdoorC");

    }

    // Update is called once per frame
    void Update()
    {
        if(doorA.GetComponent<SpriteRenderer>().sprite.name == "h" | doorB.GetComponent<SpriteRenderer>().sprite.name == "a" | doorC.GetComponent<SpriteRenderer>().sprite.name == "0")
        {
            GetComponent<ItemInform>().needName = "";

        }
    }
}
