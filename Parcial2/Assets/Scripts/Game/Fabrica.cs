using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Parcial2.Game {
    public class Fabrica : MonoBehaviour
    {
        public GameObject enemy;
        // Use this for initialization

        public void CreateEnemy()
        {
            Instantiate(enemy, new Vector3(Random.Range(-24, 30), 0, Random.Range(-27, 27)), Quaternion.identity);
            enemy.GetComponent<Enemy>().SetVariables(Random.Range(1, 100), Random.Range(5, 40));
        }
    }
}


