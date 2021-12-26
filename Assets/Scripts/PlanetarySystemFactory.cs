using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetarySystemFactory : MonoBehaviour, IPlanetarySystemFactory
{
    [SerializeField] private double systemMass;
    IPlanetarySystem plSys;

    void Start()
    {
        plSys = IPlanetarySystemFactory.Create(systemMass);
    }

}
