using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassClass : MonoBehaviour, IPlanetaryObject
{
    public static MassClass instance;

    public enum massClass {Asteroidan, Mercurian, Subterran, Terran, Superterran, Neptunian, Jovian}

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    public massClass GetMassClass(double mass)
    {
        if (0 < mass && mass <= 0.00001f)
        {
            IPlanetaryObject.massClass = massClass.Asteroidan;
        }
        else if (0.00001f < mass && mass <= 0.1f)
        {
            IPlanetaryObject.massClass = massClass.Mercurian;
        }
        else if (0.1f < mass && mass <= 0.5f)
        {
            IPlanetaryObject.massClass = massClass.Subterran;
        }
        else if (0.5f < mass && mass <= 2)
        {
            IPlanetaryObject.massClass = massClass.Terran;
        }
        else if (2 < mass && mass <= 10)
        {
            IPlanetaryObject.massClass = massClass.Superterran;
        }
        else if (10 < mass && mass <= 50)
        {
            IPlanetaryObject.massClass = massClass.Neptunian;
        }
        else if (50 < mass && mass <= 5000)
        {
            IPlanetaryObject.massClass = massClass.Jovian;
        }
        return IPlanetaryObject.massClass;
    }
}
