using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
    public string var_public;
    [SerializeField]private string var_private;
    public string test1;
    [Multiline(10)]public string test2;
    [TextArea(3,10)]public string test3;
    [ContextMenuItem("Random", "RandomNumber")]
    [SerializeField, Range(100, 1000)] float speed = 100;

    void RandomNumber()
    {
        speed = Random.Range(0, 1000);
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Privateは" + var_private + "，Publicは" + var_public);
        Debug.Log(test1);
        Debug.Log(test2);
        Debug.Log(test3);
    }

    // Update is called once per frame
    void Update()
    {
        move(speed, this.gameObject.transform.position);
    }

    private Vector3 defPosition;

    void move(float s, Vector3 pos)
    {
        float T = speed;
        float f = 1.0f / T;
        float sin = Mathf.Sin(2 * Mathf.PI * f * Time.time);
        this.transform.position = new Vector3(sin, defPosition.y, defPosition.z);
    }
}
