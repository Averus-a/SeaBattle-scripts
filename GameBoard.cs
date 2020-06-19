using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [SerializeField]
    private Transform _cell;

    public Transform Cell
    {
        get { return _cell; }
        set { _cell = value; }
    }

    [SerializeField]
    private Vector2Int _size;

    public Vector2Int Size
    {
        get { return _size; }
        set { _size = value; }
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
