using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characther : MonoBehaviour
{
    Sword currentSword;
    // Start is called before the first frame update
    void Start()
    {
        currentSword = new LongSword("espadota");
        currentSword = new FireSword(currentSword);
        currentSword = new FireSword(currentSword);
        currentSword = new FireSword(currentSword);
        currentSword = new FireSword(currentSword);
        currentSword = new FireSword(currentSword);
        currentSword = new FireSword(currentSword);
        currentSword = new IceSword(currentSword);
        currentSword = new FireSword(currentSword);
        currentSword = new IceSword(currentSword);
        /* remover los poderes como si fueran desde el ultimo que se agrego  y se va restando
        currentSword = currentSword.Remove();
        currentSword = currentSword.Remove();
        currentSword = currentSword.Remove();
        currentSword = currentSword.Remove();
        currentSword = currentSword.Remove();
        currentSword = currentSword.Remove();
*/

        Debug.Log(currentSword.GetDescrition() + " " +  currentSword.Hit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
