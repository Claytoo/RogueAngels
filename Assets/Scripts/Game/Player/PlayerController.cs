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

    [Header("Player State Handler")]
    public GameObject azielStateHandler;
    public GameObject belielStateHandler;
    private bool azielState = true;
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

        }

        ChangeState();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x, y) * moveSpeed;
    }

    internal void ChangeState()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (azielState == true)
            {
                azielStateHandler.SetActive(false);
                belielStateHandler.SetActive(true);
                azielState = false;
            }
            else
            {
                azielStateHandler.SetActive(true);
                belielStateHandler.SetActive(false);
                azielState = true;
            }
        }
    }
}
