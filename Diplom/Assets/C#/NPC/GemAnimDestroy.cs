using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemAnimDestroy : MonoBehaviour
{
    public GameObject GemAnim;

    public void OnDestroy()
    {
        Destroy(GemAnim);
    }
}
