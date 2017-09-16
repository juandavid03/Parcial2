using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Parcial2.Game
{
    public class Controlador : MonoBehaviour
    {
        public float waveTimer;
        public int maxEnemies;
        public GameObject[] enemies;
        public GameObject[] fabricas;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(waveTimer);
            waveTimer -= Time.deltaTime;
            if (waveTimer <= 0)
            {
                //InstanciarOla();
                InstanciasDesdeFabricas();
                waveTimer += 6;
            }
        }

        public void InstanciarOla()
        {

            for (int i = 0; i < maxEnemies; i++)
            {
                var enemy = enemies[Random.Range(0, 3)];
                Instantiate(enemy, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
            }
        }

        public void InstanciasDesdeFabricas()
        {
            for (int i = 0; i < maxEnemies; i++)
            {
                var fabrica = fabricas[Random.Range(0, fabricas.Length)].GetComponent<Fabrica>();
                fabrica.CreateEnemy();
            }
        }
    }
}
