using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetarySystem
{
    public static IEnumerable<IPlanetaryObject> planetaryObjects;

    private static double mass;
    public static double Mass { get { return mass; } set { mass = value; } }

    public static void UpdateSystem(float deltaTime)
    {
        Time.timeScale = deltaTime;
    }
}
