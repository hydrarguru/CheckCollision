using UnityEngine;

public class CollisionTester : MonoBehaviour
{
    public Material _notCollidedMaterial;
    public Material _isCollidedMaterial;

    public SphereCollider _sphereA;
    public SphereCollider _sphereB;

    public BoxCollider _boxA;
    public BoxCollider _boxB;

    public BoxCollider _boxC;
    public SphereCollider _sphereC;

    private void Update()
    {
        SphereToSphere();
        BoxToBox();
        BoxToSphere();
    }

    private void SphereToSphere()
    {
        if (CollisionUtility.Intersect(_sphereA, _sphereB))
        {
            _sphereA.GetComponent<Renderer>().sharedMaterial = _isCollidedMaterial;
            _sphereB.GetComponent<Renderer>().sharedMaterial = _isCollidedMaterial;
        }
        else
        {
            _sphereA.GetComponent<Renderer>().sharedMaterial = _notCollidedMaterial;
            _sphereB.GetComponent<Renderer>().sharedMaterial = _notCollidedMaterial;
        }
    }

    private void BoxToBox()
    {
        if (CollisionUtility.Intersect(_boxA, _boxB))
        {
            _boxA.GetComponent<Renderer>().sharedMaterial = _isCollidedMaterial;
            _boxB.GetComponent<Renderer>().sharedMaterial = _isCollidedMaterial;
        }
        else
        {
            _boxA.GetComponent<Renderer>().sharedMaterial = _notCollidedMaterial;
            _boxB.GetComponent<Renderer>().sharedMaterial = _notCollidedMaterial;
        }
    }

    private void BoxToSphere()
    {
        if (CollisionUtility.Intersect(_boxC, _sphereC))
        {
            _boxC.GetComponent<Renderer>().sharedMaterial = _isCollidedMaterial;
            _sphereC.GetComponent<Renderer>().sharedMaterial = _isCollidedMaterial;
        }
        else
        {
            _boxC.GetComponent<Renderer>().sharedMaterial = _notCollidedMaterial;
            _sphereC.GetComponent<Renderer>().sharedMaterial = _notCollidedMaterial;
        }
    }
}
