using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    private readonly int _defaultSizeX = 10;
    private readonly int _defaultSizeY = 10;

    public GameBoard()
    {
        _size = new Vector2Int(_defaultSizeX, _defaultSizeY);
    }

    [SerializeField]
    private Transform _cell;

    public Transform Cell
    {
        get { return _cell; }
        set { _cell = value; }
    }

    [SerializeField]
    private Vector2Int _cellSize;

    public Vector2Int CellSize
    {
        get { return _cellSize; }
        set { _cellSize = value; }
    }

    [SerializeField]
    private Vector2Int _size;

    public Vector2Int Size
    {
        get { return _size; }
        set { _size = value; }
    }

    private void Awake()
    {
        InitializeBoard();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void InitializeBoard()
    {
        Cell.localScale = new Vector3(CellSize.x, CellSize.y, 1f);
    }
}
