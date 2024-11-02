using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int multiplicand = 5;
        int result;

        for (int i = 1; i <= 10; i++)
        {
            result = Multiply(i, multiplicand);
            Debug.Log(multiplicand + " x " + i + " = " + result);
        }
    }

    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
