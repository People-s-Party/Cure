using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassDoorOpen : MonoBehaviour
{
    public string[] needs;
    private bool[] activecount;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        activecount = new bool[needs.Length];
    }

    // Update is called once per frame
    void Update()
    {
        bool open =true;
        foreach (bool i in activecount)
        {
            if (!i) open = false;
        }
        if (open) active = true;
    }
    private void OnEnable()
    {
        Messenger.AddListener<string,string>(Events.)
    }
}
