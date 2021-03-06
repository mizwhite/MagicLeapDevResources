﻿using UnityEngine;
using System.Collections;

namespace LR_Samples {
    public class Vignette : MonoBehaviour {

        #region Public Variables
        public Material vignetteMaterial;
        //public GameObject Controller;
        #endregion
        
        #region Unity Methods	
        void OnRenderImage(RenderTexture srcTexture, RenderTexture destTexture) {
            Graphics.Blit(srcTexture, destTexture, vignetteMaterial);
        }
        #endregion
    }
}
