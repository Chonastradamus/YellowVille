using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rewind[] rewinds;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (var item in rewinds)
            {
                print("save");
                item.Save();
            }
        } 
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (var item in rewinds)
            {
                print("Load");
                item.Load();
            }
        }
    }
}
