
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Bomb _bombTemplate;
    [SerializeField] private Coin _coinTemplate;
    [SerializeField] private int _objectCount;


    void Update()
    {
        for(int i = 0; i<_objectCount; i++)
        {
            Vector3 randomSpanVector = new Vector3(Random.Range(-100, 100), Random.Range(-10, 10), Random.Range(-10, 10));

            if (Random.Range(0,2) == 0)
            {
                Instantiate(_coinTemplate, randomSpanVector, Quaternion.identity, transform);
            }
            else
            {
                Instantiate(_bombTemplate, randomSpanVector, Quaternion.identity, transform);
            }

        }
    }
}
