using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public MoveBase Base { get; set; } //short way to create a getter/setter
    public int PP { get; set; }
    public Move(MoveBase eBase)
    {
        Base = eBase;
        PP = eBase.PP;
    }
}
