using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenManager : MonoBehaviour
{

    public static GenManager Instance;

    public string playerName;


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
}
