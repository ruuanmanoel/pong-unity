using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    public float meuY;
    public float velocidade = 5f;
    public float limites = 3.45f;
    // Start is called before the first frame update
    void Start()
    {
        minhaPosicao.x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;
        if (Input.GetKey(KeyCode.UpArrow) && meuY < limites)
        {
            meuY += velocidade * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow) && meuY > -limites){
            meuY -= velocidade * Time.deltaTime;
        }
    }
}
