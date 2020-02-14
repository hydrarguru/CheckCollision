using UnityEngine;

public static class CollisionUtility
{
    public static bool Intersect(SphereCollider a, SphereCollider b)
    {
        #region Spoiler
        // If the distance between the two spheres are less than their combined radiuses you have a collision.
        #endregion Spoiler
        float distance = Mathf.Sqrt((a.bounds.center.x - b.bounds.center.x) * (a.bounds.center.x - b.bounds.center.x) +
                         (a.bounds.center.y - b.bounds.center.y) * (a.bounds.center.y - b.bounds.center.y) +
                         (a.bounds.center.z - b.bounds.center.z) * (a.bounds.center.z - b.bounds.center.z));


        return distance < (a.radius + b.radius);

    }

    public static bool Intersect(BoxCollider a, BoxCollider b)
    {
        #region Spoiler
        // Check for any overlapping axis.
        // Get the bounds.
        // For each axis check that minimum for a is <= than max for b and max for a is >= minimum for b.
        // If it's true for all thre axises you have a collision.
        #endregion Spoiler
        if(a.bounds.min.x <= b.bounds.max.x && a.bounds.max.x >= b.bounds.min.x &&
           a.bounds.min.y <= b.bounds.max.y && a.bounds.max.y >= b.bounds.min.y &&
           a.bounds.min.z <= b.bounds.max.z && a.bounds.max.z >= b.bounds.min.z)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool Intersect(BoxCollider box, SphereCollider sphere)
    {
        #region Spoiler
        // Get the closest point of the box to the spheres center.
        // For each axis take the lowest value between the spheres position and the max of the box bounds.
        // Then take the max value between that and the minimum value of the box bounds.
        // if the distance between the closest point and the spheres position is less than its radius you have a collision.
        #endregion Spoiler

        float x = Mathf.Max(box.bounds.min.x, Mathf.Min(sphere.transform.position.x, box.bounds.max.x));
        float y = Mathf.Max(box.bounds.min.y, Mathf.Min(sphere.transform.position.y, box.bounds.max.y));
        float z = Mathf.Max(box.bounds.min.z, Mathf.Min(sphere.transform.position.z, box.bounds.max.z));
        float distance = Mathf.Sqrt((x - sphere.transform.position.x) * (x - sphere.transform.position.x) +
                                 (y - sphere.transform.position.y) * (y - sphere.transform.position.y) +
                                 (z - sphere.transform.position.z) * (z - sphere.transform.position.z));
        return distance < sphere.radius;
    }
}

