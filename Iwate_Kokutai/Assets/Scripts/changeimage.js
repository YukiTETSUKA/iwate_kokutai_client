#pragma strict

var per_frame : int; //FixedUpdata()が何フレーム回ったら画像を変えるか
var textures : Texture2D[]; //inspectorでtexture_numの値と一致させる
private var id : int;
private var count : int;

function Start () {
	count = 0;
	id = 0;
}

function FixedUpdate() {
	if(count<per_frame){
		renderer.material.mainTexture = textures[id];
		count++;
	}
	else if(count>=per_frame){
		count=0;
		if(id<textures.Length) id++;
		if(id>=textures.Length) id=0;
	}

	

}