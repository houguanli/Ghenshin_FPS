using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementCalcuation : MonoBehaviour
{
    GameObject target;

}

public class Element
{
    public static int
        GRASS = 0,
        FIRE = 1,
        WATER = 2,
        ICE = 3,
        WIND = 4,
        THUNDER = 5,
        ROCK = 6;



    private int Element_value;
    private int Element_type;
}