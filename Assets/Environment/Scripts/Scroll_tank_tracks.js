var scrollSpeed :float = 10; 

function Update () { 
var offset : float = Time.time * scrollSpeed * Time.deltaTime % 1;

GetComponent.<Renderer>().material.SetTextureOffset ("_MainTex", Vector2(0, offset)); 


}