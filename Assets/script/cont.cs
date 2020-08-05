using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class cont : MonoBehaviour

{
    public Text text;
    public float speed;
    private Rigidbody rb;
    public int count;
    public Text score;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveVertical, 0.0f, moveHorizontal);

        rb.AddForce(movement * speed);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            count++;
            Debug.Log("canın ak");
            other.gameObject.SetActive(false);
            score.text = "score:" + count.ToString();


        }

        if (other.gameObject.CompareTag("bonuscoins"))
        {
            count = count + 5;
            Debug.Log("tekrardan canın ak ");
            other.gameObject.SetActive(false);
            score.text = "score:" + count.ToString();
        }

        if (other.gameObject.CompareTag("restart"))

        {
            Debug.Log("restart");
            SceneManager.LoadScene(0);
            gameObject.transform.position = new Vector3(0, 2, 0);

        }

    }


    private void Update()
    {
        if (count == 48)
        {
            text.text = "görev tamamlandı";
        }

    }
}
