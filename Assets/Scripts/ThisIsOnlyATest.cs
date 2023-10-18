using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisIsOnlyATest : MonoBehaviour
{
    private int test = 0;

    [SerializeField] private string test2;
    
    private const float test3 = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        if (true)
            Debug.Log("This is only a test");
    }
}
