using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private int healthValue;
    private int scoreValue;
    public int HealthValaue => healthValue;

    private void Start()
    {
        _healthText.text = healthValue.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Coin coin))
        {
            scoreValue++;
            _scoreText.text = scoreValue.ToString();
            Destroy(coin.gameObject);
        }
        else if(other.TryGetComponent(out Bomb bomb))
        {
            healthValue--;
            _healthText.text = healthValue.ToString();
            Destroy(bomb.gameObject);
        }
    }
}
