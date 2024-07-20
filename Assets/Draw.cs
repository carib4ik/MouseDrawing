using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;
    private List<Vector3> _points = new();
    
    private void Update()
    {
        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ray.z = 0;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _points.Clear();
            _lineRenderer.positionCount = 0;
            AddPoint(ray);
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            AddPoint(ray);
        }
    }
    
    private void AddPoint(Vector3 point)
    {
            _points.Add(point);
            _lineRenderer.positionCount = _points.Count;
            _lineRenderer.SetPosition(_points.Count - 1, point);
    }
}
