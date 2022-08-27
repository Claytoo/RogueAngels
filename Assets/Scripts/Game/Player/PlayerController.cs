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
    public GameObject azielWeapon;
    public GameObject belielWeapon;
    private bool azielState = true;

    [Header("Explosion Effect")]
    public GameObject[] explosionEffect;

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
                Instantiate(explosionEffect[1], this.transform);
                azielStateHandler.SetActive(false);
                belielStateHandler.SetActive(true);
                belielWeapon.SetActive(true);
                azielWeapon.SetActive(false);
                azielState = false;
            }

            else
            {
                Instantiate(explosionEffect[0], this.transform);
                azielStateHandler.SetActive(true);
                belielStateHandler.SetActive(false);
                azielWeapon.SetActive(true);
                belielWeapon.SetActive(false);
                azielState = true;
            }
        }
    }
}
