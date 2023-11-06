using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Moves", menuName = "Enemy/Create new Move")]
public class MoveBase : ScriptableObject
{
    // MoveBase variables
    [SerializeField] string name;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] EnemyType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;

    // Getters
    public string Name { get { return name; } }
    public string Descriptin { get { return description; } }
    public EnemyType Type { get { return type; } }
    public int Power { get { return power; } }
    public int Accuracy { get { return accuracy; } }
    public int PP { get { return pp; } }
}
