using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball")) // Si colisionamos con la bola
        {
            GameManager.Instance.ReloadScene(); // Recargamos la escena
        }
    }
}
