using UnityEngine;

namespace Genity
{
    public static partial class DrawGizmosExtensions
    {
        private delegate void DrawBoxDelegate(Vector3 center, Vector3 size);

        private delegate void DrawSphereDelegate(Vector3 center, float radius);

        public static void DrawBox(this GizmosData gizmos, Vector3 center, Quaternion orientation, Vector3 size)
        {
            if (gizmos.drawType == 0) return;

            Gizmos.color = gizmos.gizmosColor;
            Gizmos.matrix = Matrix4x4.TRS(center, orientation, Vector3.one);

            DrawBoxDelegate draw = null;
            if ((gizmos.drawType & GizmosData.DrawType.Wire) != 0) draw += Gizmos.DrawWireCube;
            if ((gizmos.drawType & GizmosData.DrawType.Solid) != 0) draw += Gizmos.DrawCube;
            draw?.Invoke(Vector3.zero, size);

            Gizmos.matrix = Matrix4x4.identity;
        }

        public static void DrawSphere(this GizmosData gizmos, Vector3 center, float radius = 1.0f)
        {
            if (gizmos.drawType == 0) return;

            Gizmos.color = gizmos.gizmosColor;

            DrawSphereDelegate draw = null;
            if ((gizmos.drawType & GizmosData.DrawType.Wire) != 0) draw += Gizmos.DrawWireSphere;
            if ((gizmos.drawType & GizmosData.DrawType.Solid) != 0) draw += Gizmos.DrawSphere;
            draw?.Invoke(center, radius);
        }

        public static void DrawRay(this GizmosData gizmos, Vector3 center, Vector3 direction, float maxDistance)
        {
            if (gizmos.drawType == 0) return;

            Gizmos.color = gizmos.gizmosColor;
            Gizmos.DrawRay(center, direction * maxDistance);
        }
    }
}