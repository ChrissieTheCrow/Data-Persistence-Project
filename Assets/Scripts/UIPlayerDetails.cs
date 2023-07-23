using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerDetails : MonoBehaviour
{
    private string input;

    public void StorePlayerName(string inputName)
    {
        
        Debug.Log(inputName);
        GenManager.Instance.playerName = inputName;
        
    }


}
