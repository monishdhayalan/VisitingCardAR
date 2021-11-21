using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void callhim()
    {
        Application.OpenURL("tel://919841146946");
    }

    public void messagehim()
    {
        Application.OpenURL("https://api.whatsapp.com/send?phone=919841146946&text=hello");
    }

    public void directions()
    {
        Application.OpenURL("https://www.google.com/maps/dir//sri+ganapathy+car+care/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x3a52615358be2f2f:0xa9d58a572bbcbbe0?sa=X&ved=2ahUKEwjyq4mEpan0AhWd5DgGHXluC8QQ9Rd6BAhEEAQ");
    }
}
