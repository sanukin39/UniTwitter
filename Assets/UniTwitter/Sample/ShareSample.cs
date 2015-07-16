using UnityEngine;
using System.Collections;

public class ShareSample : MonoBehaviour {

    public void Share(){
        UniTwitter.Share ("Share your game info!");
    }
}
