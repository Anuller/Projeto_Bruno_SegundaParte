using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    #region Variaveis
    [Header("RigidBody do player")]
    public static Rigidbody2D rb;

    // Em qual sentido ele vai andar
    private float direcao;

    [Header("Velocidade do Player")]
    public float speed;

    [Header("Força do Pulo do Player")]
    public float jumpforce;

    [Header("Animator do Player")]
    public Animator player;

    // Para onde ele vai olhar
    private bool facingRight;

    // verificar se está no chao
    private bool terra;

    [Header("Transform para detectar se está no chao")]
    public Transform chaoDetecta;

    [Header("Layer para indicar o que é o chao")]
    public LayerMask chao;

    [Header("Quantidade de Pulo")]
    public int extraPulo;

    [Header("Game Controller do Player")]
    public gamecontroller gameController;

    //[Header("Tela de Morte")]
    //public GameObject telaMorte;

    private gameControllerUI uiPlayer;

    private AudioSource som;

    #endregion Variaveis

    

    public void Awake()
    {
        som = GetComponent<AudioSource>();
    }

    void Start()
    {
        uiPlayer = gameControllerUI.UI;
        uiPlayer.patosColetados = 0;
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        #region Move do player
        terra = Physics2D.OverlapCircle(chaoDetecta.position, 0.3f, chao);

        direcao = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(direcao * speed, rb.velocity.y);

        if (terra == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpforce;
            player.SetBool("Jump", true);
        }

        if (terra == false && extraPulo > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpforce;
            player.SetBool("Jump", true);
            extraPulo--;
        }

        if (terra)
        {
            extraPulo = 1;
        }

        if (direcao < 0 && !facingRight || direcao > 0 && facingRight)
        {
            Flip(direcao);
        }
        #endregion Move do player
    }
    void OnCollisionEnter2D(Collision2D collsion)
    {
      Debug.Log("Eu colidi com algo" + collsion.collider.name);

       if (collsion.collider.CompareTag("dano") == true)
        {
            gameController.GameOver();
        }

        if (collsion.collider.CompareTag("ground"))
        {
            player.SetBool("Jump", false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "patocolet")
        {
            Destroy(collision.gameObject);
            uiPlayer.patosColetados++;
            uiPlayer.patoText.text = uiPlayer.patosColetados.ToString();
            som.Play();
        }
    }

    #region Flip Personagem
    void Flip(float direcao)
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    #endregion Flip Personagem
}
