using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIScreen : MonoBehaviour
{
    public abstract IEnumerator PlayInAnimation();
    public abstract IEnumerator PlayOutAnimation();
}
