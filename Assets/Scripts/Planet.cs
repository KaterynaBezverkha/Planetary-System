using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour, IPlanetaryObject
{
    [SerializeField] private Color[] planetColors;

    private float radius;
    public float Radius { get { return radius; } }

    private void Start()
    {
        SetRadius();
    }

    public void SetRadius()
    {
        switch (IPlanetaryObject.massClass)
        {
            case MassClass.massClass.Asteroidan:
                radius = Random.Range(0, 0.03f);
                break;
            case MassClass.massClass.Mercurian:
                radius = Random.Range(0.03f, 0.7f);
                break;
            case MassClass.massClass.Subterran:
                radius = Random.Range(0.8f, 1.9f);
                break;
            case MassClass.massClass.Superterran:
                radius = Random.Range(1.3f, 3.3f);
                break;
            case MassClass.massClass.Neptunian:
                radius = Random.Range(2.1f, 5.7f);
                break;
            case MassClass.massClass.Jovian:
                radius = Random.Range(3.5f, 27);
                break;
        }

        transform.localScale = new Vector3(1,1,1) * radius;
    }

    public void SetColor()
    {
        int rand = Random.Range(0, planetColors.Length);
        gameObject.GetComponent<Renderer>().material.color = planetColors[rand];
    }

    public IEnumerator RotationMove(Vector3 star, float rotationSpeed, float localRotationSpeed)
    {
        while (true)
        {
            transform.Rotate(Vector3.up, localRotationSpeed);
            yield return null;
            transform.RotateAround(star, Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
