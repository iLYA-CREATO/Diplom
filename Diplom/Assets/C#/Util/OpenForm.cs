using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenForm : MonoBehaviour
{
    public void _OpenForm(GameObject Form)
    {
        Form.SetActive(true);
    }

    public void _ClouseForm(GameObject Form)
    {
        Form.SetActive(false);
    }
}
