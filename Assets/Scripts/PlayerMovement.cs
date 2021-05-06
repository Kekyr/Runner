using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Vector3 turnForce;

    public Text hpText;
    private Rigidbody rigidbody;
    private Vector3 speed=new Vector3(0,0,50f);
    private int hp = 3;
    private bool damage=true;
    

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move(speed);
    }

    private void Move(Vector3 force)
    {
        rigidbody.AddForce(force);
    }

    public void ChangeSpeed(Slider slider)
    {
        speed.z = slider.value;
    }

    public void MoveRight()
    {
        Move(turnForce);
    }

    public void MoveLeft()
    {
        Move(-turnForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            if(damage)
            {
                hp -= 1;
                hpText.text = "HP: " + hp;
                StartCoroutine(Delay());
            }
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            hp -= 1;
            hpText.text = "HP: " + hp;
        }
    }

    private IEnumerator Delay()
    {
        damage = false;
        yield return new WaitForSeconds(10f);
        damage = true;
    }
}
