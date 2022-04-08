using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getter
{
    private int myField;

    public int GetMyField() 
    { 
        return myField; 
    }
    public void SetMyField(int NewValue) 
    { 
        myField = NewValue; 
    }
}
