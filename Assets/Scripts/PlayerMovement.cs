using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float horMove;
    public float verMove;
  
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horMove = Input.GetAxis("Horizontal");
        verMove = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horMove,0,verMove) * playerSpeed * Time.deltaTime);
    }
}
