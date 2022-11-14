using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OyunKontrol : MonoBehaviour
{
    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public TextMeshProUGUI altinSayText;
    public UnityEngine.UI.Button baslaButonu;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AltinArttir()
    {
        altinSayisi += 1;
        altinSayText.text = " "+ altinSayisi;
    }
    public void OyunaBasla()
    {
        oyunAktif = true;
        baslaButonu.gameObject.SetActive(false);
    }
}
