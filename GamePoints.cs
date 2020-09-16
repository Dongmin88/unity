using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePoints : MonoBehaviour
{
    public int Gold;
    public int Success;
    public int Fail;
    public int Day;
    // Start is called before the first frame update
    void Start()
    {
        Gold = 0;
        Success = 0;
        Fail = 0;
        Day = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
