# Unity Gizmos
[![License](https://img.shields.io/github/license/evgjeniy/unity-gizmos?color=318CE7&style=flat-square)](LICENSE.md)
[![Version](https://img.shields.io/github/package-json/v/evgjeniy/unity-gizmos?color=318CE7&style=flat-square)](package.json)

<h3>Useful extensions for drawing gizmos in Unity Engine</h3>

# Navigation
- [Get Started](#get-started)
- [How to use](#how-to-use)
- [Overlap Package](#overlap-package)

# Get Started
**Installation options:**
- Copy git URL `https://github.com/evgjeniy/unity-gizmos.git` in the **Unity Package Manager**
- Add `"com.genity.gizmos": "https://github.com/evgjeniy/unity-gizmos.git"` in `Packages/manifest.json`

# How to use
- Declare the serialized `GizmosData` field
- Invoke `DrawSphere`, `DrawBox`, `DrawRay` or `DrawMesh` methods from `OnDrawGizmos` or `OnDrawGizmosSelected` methods
- Setup `DrawType` and `Color` from **Unity Inspector**

```csharp
public class GizmosExample : MonoBehaviour
{
    [SerializeField] private GizmosData gizmos;

    private void OnDrawGizmos()
    {
        gizmos.DrawSphere(transform.position, 0.25f);
    }
}
```

# Overlap package
- You can install the [unity-overlap](https://github.com/evgjeniy/unity-overlap) package to set up overlap settings from inspector and draw them in scene

```csharp
public class GizmosOverlapExample : MonoBehaviour
{
    [SerializeField] private GizmosData gizmosData;
    [SerializeField] private BoxData boxData;

    private void OnDrawGizmos()
    {
        gizmosData.Draw(boxData);
    }
}
```

Preview:
![gizmos-preview](https://github.com/user-attachments/assets/d1724a8c-febb-4a73-8457-cdc11f013255)
