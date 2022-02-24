using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionToCSharp : MonoBehaviour
{
    //Variable Declaration //
    string name = "Jyothsna"; //String defined
    int someVal = 10; //int declared
    float height = 0.32f; //float declared
    double gravity = 9.81; //double declared
    bool isGrounded; //bool has defined
                     // var enemy; //You can't define var in Global varaiable
                     // Start is called before the first frame update

    //Arrays are meant to be access in Global
    //Type 1: 
    int[] speedLimit;
    // speedLimit = new int [10];
    //Type 2:
    int[] speedLimits = new int[10];
    //Array defined with values
    int[] gravityValues = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //Accessing  the Values with Index
    //   int [1] gravityValues = 2;
    gravityValues[1] = 2;
    //Example
   int len = gravityValues.Length;// - To find Length of an array
    //Multidimensional Array
    int[,] tiles = new int[8, 8];
    //Example
    tiles[1, 2] = 20;
    

    //Constants - These are the values which should not be changed.We Use keyword const before varaible.
    const float gravityR = 9.81f;

    //enums or Enumerations - Enums are nothing but legible List of constants 
    enum state { idlem, walk, jump, run };
    //Example
    state mystate;
    //mystate = state.jump;


    //conversions - it is about converting from one varaiable to another.

    string scorPoints = "2";
    int points = (int)scorPoints;
    points.ToString();
    //switch condition
  // int damage;
  switch(damage)
       {
            case 0:
                print("statement - 0");
                break;
            case 1:
                print("statement - 0");
                break;
            default:
                print("over");
        }
//Foreach loop is used to run through the array
foreach(int localLimit in gravityValues)
{
    if (localLimit == 10)
    {
        print("Hello");
    }
}









        
    void Start()
    {
        var enemyLife = 5;
        var enemy = "Happy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
