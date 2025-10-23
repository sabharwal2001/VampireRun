using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    
    public float playerSpeed =  2;
    public float horizontalSpeed = 3;
    public float leftLimit = 5.5f;
    public float rightLimit = 5.5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
        if (Input.GetKey(KeyCode.A))
        {
//            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
//            if (this.gameObject.transform.position.y > rightLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }
        }
    }
}
