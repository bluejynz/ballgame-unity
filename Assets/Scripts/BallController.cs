using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private float spd = 5f;

    private int points = 0;
    public TextMeshProUGUI scoreText;

    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(move * spd);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collectable"))
        {
            points++;
            scoreText.text = "Score: " + points;
            Instantiate(particle, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
