// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Brandon/TiendaActivacion"
{
	Properties
	{
		_Color("Color", Color) = (0.8962264,0,0.1184583,0)
		_Cutoff( "Mask Clip Value", Float ) = 0.5
		_Intensidad("Intensidad", Float) = 2
		_5455("5455", 2D) = "white" {}
		_Variante("Variante", Float) = 0.13
		_ring("ring", 2D) = "white" {}
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "TransparentCutout"  "Queue" = "Geometry+0" "IgnoreProjector" = "True" "IsEmissive" = "true"  }
		Cull Back
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf Standard keepalpha addshadow fullforwardshadows exclude_path:deferred 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform float4 _Color;
		uniform float _Intensidad;
		uniform sampler2D _ring;
		uniform float4 _ring_ST;
		uniform float _Variante;
		uniform sampler2D _5455;
		uniform float4 _5455_ST;
		uniform float _Cutoff = 0.5;

		void surf( Input i , inout SurfaceOutputStandard o )
		{
			float4 color38 = IsGammaSpace() ? float4(0,0.8768053,1,0) : float4(0,0.7422916,1,0);
			float2 uv_ring = i.uv_texcoord * _ring_ST.xy + _ring_ST.zw;
			float4 tex2DNode33 = tex2D( _ring, uv_ring );
			float4 lerpResult34 = lerp( color38 , _Color , ( _Intensidad * tex2DNode33 ));
			o.Emission = lerpResult34.rgb;
			o.Alpha = 1;
			float2 uv_5455 = i.uv_texcoord * _5455_ST.xy + _5455_ST.zw;
			float clampResult23 = clamp( ( ( (0.0 + (_Variante - -0.5) * (1.0 - 0.0) / (0.5 - -0.5)) + -1.0 ) + tex2D( _5455, uv_5455 ).r ) , 0.0 , 1.0 );
			float lerpResult21 = lerp( 0.0 , 1.0 , clampResult23);
			clip( ( tex2DNode33.r * lerpResult21 ) - _Cutoff );
		}

		ENDCG
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=16200
822;111;1050;1010;1139.407;242.9901;1;False;False
Node;AmplifyShaderEditor.RangedFloatNode;25;-1414.524,859.0148;Float;False;Property;_Variante;Variante;4;0;Create;True;0;0;False;0;0.13;2;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.TFHCRemapNode;31;-1229.945,872.4318;Float;False;5;0;FLOAT;0;False;1;FLOAT;-0.5;False;2;FLOAT;0.5;False;3;FLOAT;0;False;4;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;32;-1023.244,923.1318;Float;False;2;2;0;FLOAT;0;False;1;FLOAT;-1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;18;-1239.976,1090.154;Float;True;Property;_5455;5455;3;0;Create;True;0;0;False;0;f9a19241135f86c4d821ee4c61e0c447;f9a19241135f86c4d821ee4c61e0c447;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleAddOpNode;24;-913.7239,1084.315;Float;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;23;-768.7238,1042.315;Float;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;15;-1015.814,158.9831;Float;False;Property;_Intensidad;Intensidad;2;0;Create;True;0;0;False;0;2;14.17;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;29;-778.0168,960.1265;Float;False;Constant;_Float4;Float 4;7;0;Create;True;0;0;False;0;1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;33;-1066.965,282.5366;Float;True;Property;_ring;ring;5;0;Create;True;0;0;False;0;None;026fe2a86575b794890600d6fe18c32f;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;28;-782.1895,883.991;Float;False;Constant;_Float3;Float 3;7;0;Create;True;0;0;False;0;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;21;-552.7239,965.3149;Float;True;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;44;-752.4594,133.1791;Float;True;2;2;0;FLOAT;0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.ColorNode;38;-683.558,-334.8209;Float;False;Constant;_Color0;Color 0;7;0;Create;True;0;0;False;0;0,0.8768053,1,0;0,0,0,0;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ColorNode;3;-677.1017,-137.9317;Float;False;Property;_Color;Color;0;0;Create;True;0;0;False;0;0.8962264,0,0.1184583,0;0.1898889,0,1,0;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;30;-278.86,716.2921;Float;True;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;34;-346.0653,-113.0635;Float;True;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;0,0;Float;False;True;2;Float;ASEMaterialInspector;0;0;Standard;Brandon/TiendaActivacion;False;False;False;False;False;False;False;False;False;False;False;False;False;False;True;False;False;False;False;False;Back;0;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Custom;0.5;True;True;0;True;TransparentCutout;;Geometry;ForwardOnly;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;True;0;1;False;-1;10;False;-1;0;4;False;-1;1;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;1;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;16;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;31;0;25;0
WireConnection;32;0;31;0
WireConnection;24;0;32;0
WireConnection;24;1;18;1
WireConnection;23;0;24;0
WireConnection;21;0;28;0
WireConnection;21;1;29;0
WireConnection;21;2;23;0
WireConnection;44;0;15;0
WireConnection;44;1;33;0
WireConnection;30;0;33;1
WireConnection;30;1;21;0
WireConnection;34;0;38;0
WireConnection;34;1;3;0
WireConnection;34;2;44;0
WireConnection;0;2;34;0
WireConnection;0;10;30;0
ASEEND*/
//CHKSM=79C3B657806F1D6DE0CA6A5876D8413280A18D26