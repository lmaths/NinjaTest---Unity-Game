using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinho : MonoBehaviour
{

    private Rigidbody2D espinhoRb;
    public int atrito;
    public int atritoMaximo;
    public Vector3 posicao;
    public GameObject espinhoPreFab;
   

    // Start is called before the first frame update
    void Start()
    {

        espinhoRb = GetComponent<Rigidbody2D>();

        atrito = Random.Range(2, atritoMaximo);
        espinhoRb.drag = atrito;

        posicao = transform.position;
        
    }

    private void OnBecameInvisible()
    {
        Instantiate(espinhoPreFab, posicao, transform.localRotation);
        pontuacao.pontos += 1;
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
