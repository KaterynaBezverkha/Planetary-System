using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IPlanetaryObject
{
    public static MassClass.massClass massClass;
    public MassClass.massClass MassClass { get { return massClass; } set { massClass = value; } }

    public static double mass;
    public double Mass { get { return mass; } set { mass = value; } }
}
