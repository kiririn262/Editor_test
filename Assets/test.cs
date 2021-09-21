using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
    public string pub;
    [SerializeField]private string pri;
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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
