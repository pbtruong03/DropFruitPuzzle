using UnityEngine;

public class Fruit : MonoBehaviour
{
    [Header("Info")] 
    public FruitType type;
    public bool inBox;


    [Header("UI")]
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] CircleCollider2D colider;
    [SerializeField] Rigidbody2D rb;


    public void SetVisual(FruitData fruitData)
    {
        if (fruitData == null) return;

        type = fruitData.type;
        spriteRenderer.sprite = fruitData.sprite;
        colider.radius = fruitData.radiusSize;
    }




    private void OnCollisionEnter2D(Collision2D col)
    {
        inBox = true;

        if (col.gameObject.CompareTag("Fruit"))
        {
            Fruit otherFruit = col.gameObject.GetComponent<Fruit>();

            if (otherFruit == null) return;

            if (otherFruit.type == type)
            {
                // Merge Fruit

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!inBox) return;

        // Game Over
    }

}
