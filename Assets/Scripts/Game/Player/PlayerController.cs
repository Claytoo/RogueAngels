using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region _PLAYER VAR
    [Header("Info")]
    public float moveSpeed;

    [Header("Attack")]
    public float attackRange;
    public float attackDelay;
    public float lastAttackTime;
    public int damage;

    [Header("Components")]
    public Animator anim;
    private Rigidbody2D rb;
    #endregion

    public static PlayerController me;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();

        if (Input.GetMouseButtonDown(0) && Time.time - lastAttackTime > attackDelay)
        {
            Attack();
        }
        float mouseX = (Screen.width / 2) - Input.mousePosition.x;
        //if (mouseX < 0)
        //{
        //    transform.localScale = new Vector3(1, 1, 1);
        //}
        //else
        //{
        //    transform.localScale = new Vector3(-1, 1, 1);
        //}
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x, y) * moveSpeed;
    }

    void Attack()
    {
        anim.SetTrigger("Attack");
    }
}
