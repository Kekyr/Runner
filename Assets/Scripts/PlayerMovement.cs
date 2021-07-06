using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _turnForce;

    public Text HpText;
    private Rigidbody _rigidbody;
    private Vector3 _speed=new Vector3(0,0,50f);
    private int _hp = 3;
    private bool _damage=true;
    

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move(_speed);
    }

    private void Move(Vector3 force)
    {
        _rigidbody.AddForce(force);
    }

    public void ChangeSpeed(Slider slider)
    {
        _speed.z = slider.value;
    }

    public void MoveRight()
    {
        Move(_turnForce);
    }

    public void MoveLeft()
    {
        Move(-_turnForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            if(_damage)
            {
                _hp -= 1;
                HpText.text = "HP: " + _hp;
                StartCoroutine(Delay());
            }
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            _hp -= 1;
            HpText.text = "HP: " + _hp;
        }
    }

    private IEnumerator Delay()
    {
        _damage = false;
        yield return new WaitForSeconds(10f);
        _damage = true;
    }
}
