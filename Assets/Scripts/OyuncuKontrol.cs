using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public AudioClip altin, dusme;
    public OyunKontrol oyunK;
    private float hiz = 10;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunK.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
    }
      void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin"))
        {
            GetComponent<AudioSource>().PlayOneShot(altin, 1f);
            oyunK.AltinArttir();
            Destroy(c.gameObject);

        } else if (c.gameObject.tag.Equals("dusman"))
        {
            GetComponent<AudioSource>().PlayOneShot(dusme, 1f);
            oyunK.oyunAktif = false;
        }
        
    }
}
