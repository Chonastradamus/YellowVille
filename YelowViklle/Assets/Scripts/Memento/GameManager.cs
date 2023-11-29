using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rewind[] rewinds;

    public static GameManager instance;


    private void Awake()
    {
        instance = this;
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



