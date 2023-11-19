using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rewind[] rewinds;
    
 

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {LoadManager();}
        if (Input.GetKeyDown(KeyCode.E)) { SaveManager();}

    }

    public void LoadManager()
    {
        foreach (var item in rewinds)
        {
            print("Load");
            item.Load();
        }
    }

    public void SaveManager()
    {
        foreach (var item in rewinds)
        {
            print("save");
            item.Save();
        }
    }


}



