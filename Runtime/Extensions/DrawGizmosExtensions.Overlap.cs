#if GENITY_OVERLAP

namespace Genity
{
    public static partial class DrawGizmosExtensions
    {
        public static void Draw(this GizmosData gizmos, OverlapData overlapData)
        {
            switch (overlapData)
            {
                case BoxData box: gizmos.DrawBox(box); break;
                case SphereData sphere: gizmos.DrawSphere(sphere); break;
                case RayData ray: gizmos.DrawRay(ray); break;
            }
        }

        public static void DrawBox(this GizmosData gizmos, BoxData box) => gizmos.DrawBox(box.Center, box.Orientation, box.Size);
        public static void DrawSphere(this GizmosData gizmos, SphereData sphere) => gizmos.DrawSphere(sphere.Center, sphere.Radius);
        public static void DrawRay(this GizmosData gizmos, RayData ray) => gizmos.DrawRay(ray.Center, ray.Direction, ray.MaxDistance);
    }
}

#endif