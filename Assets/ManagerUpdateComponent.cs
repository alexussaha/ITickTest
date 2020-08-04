﻿using UnityEngine;

public class ManagerUpdateComponent : MonoBehaviour
{

    private ManagerUpdate mng;

    public void Setup(ManagerUpdate mng)
    {
        this.mng = mng;
    }


    private void Update()
    {
        mng.Tick();
    }


}