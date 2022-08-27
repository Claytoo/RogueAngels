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

    [Header("Player State Handler")]
    public GameObject azielStateHandler;
    public GameObject belielStateHandler;
    private bool azielState = true;

    [HideInInspector] public Rigidbody2D rigidBody;
    #endregion

    public static PlayerController me;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time - lastAttackTime > attackDelay)
        {

        }
        ChangeState();
    }

    internal void ChangeState()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SoundManager.instance.PlaySound(5);
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
