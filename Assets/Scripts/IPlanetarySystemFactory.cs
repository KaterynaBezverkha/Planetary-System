using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetarySystemFactory
{
    static IPlanetarySystem planetarySystem;
    public static IPlanetarySystem Create(double mass)
    {
        IPlanetarySystem.Mass = mass;
        return planetarySystem;
    }
}
