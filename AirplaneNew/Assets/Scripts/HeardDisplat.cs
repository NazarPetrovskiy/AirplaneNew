
using UnityEngine;
using UnityEngine.UI;

public class HeardDisplat : MonoBehaviour
{
    [SerializeField] private Airplane _airplane;
    [SerializeField] private Image _image;
    [SerializeField] private Transform _spawnposition;

    void Start()
    {
        Vector3 spawnPosition = _spawnposition.position;

        for (int i = 0; i < _airplane.HealthValaue; i++)
        {
            //Instantiate(_image, _spawnposition, Quaternion.Identity, transform);
            //_spawnposition.x += 100;
        }
    }
}
   // private void OnEnable()=> _airplane.
