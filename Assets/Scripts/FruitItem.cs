using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitItem : MonoBehaviour
{
    public GameObject collectedEffect;

    private SpriteRenderer spriteRenderer;
    private CircleCollider2D circleCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        circleCollider2D = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spriteRenderer.enabled = false;
            circleCollider2D.enabled = false;

            collectedEffect.SetActive(true);

            Destroy(gameObject, 0.2f);
        }
    }
}
