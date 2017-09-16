using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPool : MonoBehaviour
{

    List<GameObject> list;
    //public GameObject bullet;
    public bulletPool(int size, GameObject bullet)
    {
        list = new List<GameObject>();
        for (int i = 0; i < size; i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet);
            list.Add(obj);
        }
    }

}
