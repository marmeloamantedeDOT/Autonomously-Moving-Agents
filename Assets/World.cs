using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class World 
{
    private static readonly World instance = new World();
    private static GameObject[] hidingSpots;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    static World()
    {
        hidingSpots = GameObject.FindGameObjectsWithTag("hide");
    }
    private World() { }

    public static World Instance
    {
        get { return instance; }
    }
    // Update is called once per frame
    public GameObject[] GetHidindSpots()
    {
        return hidingSpots;
    }
}
