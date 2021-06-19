using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public bool bool1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") Inactive();
    }
    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    public void Inactive()
    {
        gameObject.SetActive(false);
    }
}
