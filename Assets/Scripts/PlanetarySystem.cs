using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetarySystem : MonoBehaviour, IPlanetarySystem
{
    [SerializeField] private GameObject planetPref;

    [SerializeField] private float offset = 5f;
    [SerializeField] private float time = 1.2f;

    public static List<IPlanetaryObject> planets = new List<IPlanetaryObject>();
    private Vector3 spawnPoint;

    private void Start()
    {
        spawnPoint = transform.position + new Vector3(offset, 0, 0);
        IPlanetarySystem.planetaryObjects = planets;
        CreatePlanets(IPlanetarySystem.Mass);
    }

    public void CreatePlanets(double mass)
    {
        for (int i = 0; i < mass; i++)
        {
            float planetMass = Random.Range(0, (float)mass);
            mass -= planetMass;
            GameObject newPlanet = Instantiate(planetPref, spawnPoint += new Vector3(offset, 0, 0), Quaternion.identity);
            IPlanetaryObject newPlanetaryObject = newPlanet.GetComponent<IPlanetaryObject>();
            newPlanetaryObject.Mass = planetMass;
            newPlanetaryObject.MassClass = MassClass.instance.GetMassClass(newPlanetaryObject.Mass);
            Planet plComp = newPlanet.GetComponent<Planet>();
            plComp.SetRadius();
            plComp.SetColor();
            //newPlanet.transform.position += new Vector3(plComp.Radius * 2, 0, 0);
            AddPlanetToSystem(newPlanetaryObject);
            StartCoroutine(plComp.RotationMove(transform.position, Random.Range(0.2f, 2.5f), Random.Range(0.05f, 3f)));
            //print("mass: " + newPlanetaryObject.Mass + 
            //    "mass class: " + newPlanetaryObject.MassClass);
        }
    }

    public void AddPlanetToSystem(IPlanetaryObject planet)
    {
        planets.Add(planet);
    }

    private void Update()
    {
        IPlanetarySystem.UpdateSystem(time);
    }
}
