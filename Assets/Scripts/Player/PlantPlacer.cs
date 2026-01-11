using UnityEngine;

public class PlantPlacer : MonoBehaviour
{
    public GameObject plantPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                GridCell cell = hit.collider.GetComponent<GridCell>();

                if (cell != null && !cell.isOccupied)
                {
                    Instantiate(plantPrefab, cell.transform.position, Quaternion.identity);
                    cell.isOccupied = true;
                }
            }
        }
    }
}
