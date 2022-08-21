using UnityEngine;

public class LumaBlitter : MonoBehaviour {
	public RenderTexture source,dest;
	public Material mat;

	void Update() {
		Graphics.Blit(source, dest, mat);
	}
}
