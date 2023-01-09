
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _rotatespeed;
    private void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _rotatespeed * Time.deltaTime);
    }
}
