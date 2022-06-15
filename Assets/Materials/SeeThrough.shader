Shader "Unlit/SeeThrough"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "Queue" = "Transparent+1" } //3001 queue
        Pass { Blend Zero One }
    }
}
