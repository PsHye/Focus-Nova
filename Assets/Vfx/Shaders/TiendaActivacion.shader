// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Brandon/TiendaActivacion"
{
	Properties
	{
		_Textura("Textura", 2D) = "white" {}
		_Color("Color", Color) = (0.8962264,0,0.1184583,0)
		_Cutoff( "Mask Clip Value", Float ) = 0.5
		_Intensidad("Intensidad", Float) = 2
		_5455("5455", 2D) = "white" {}
		_Variante("Variante", Float) = 0.13
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "TransparentCutout"  "Queue" = "Transparent+0" "IgnoreProjector" = "True" "IsEmissive" = "true"  }
		Cull Back
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf Standard keepalpha addshadow fullforwardshadows exclude_path:deferred 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform float4 _Color;
		uniform sampler2D _Textura;
		uniform float4 _Textura_ST;
		uniform float _Intensidad;
		uniform float _Variante;
		uniform sampler2D _5455;
		uniform float4 _5455_ST;
		uniform float _Cutoff = 0.5;

		void surf( Input i , inout SurfaceOutputStandard o )
		{
			float2 uv_Textura = i.uv_texcoord * _Textura_ST.xy + _Textura_ST.zw;
			float4 tex2DNode1 = tex2D( _Textura, uv_Textura );
			o.Emission = ( _Color * tex2DNode1 * _Intensidad ).rgb;
			o.Alpha = 1;
			float2 uv_5455 = i.uv_texcoord * _5455_ST.xy + _5455_ST.zw;
			float clampResult23 = clamp( ( ( (0.0 + (_Variante - -0.5) * (1.0 - 0.0) / (0.5 - -0.5)) + -1.0 ) + tex2D( _5455, uv_5455 ).r ) , 0.0 , 1.0 );
			float lerpResult21 = lerp( 0.0 , 1.0 , clampResult23);
			clip( ( tex2DNode1.r * lerpResult21 ) - _Cutoff );
		}

		ENDCG
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=16200
910;148;1050;1004;1008.813;465.0689;1.3;False;False
Node;AmplifyShaderEditor.RangedFloatNode;25;-1418.213,386.8429;Float;False;Property;_Variante;Variante;5;0;Create;True;0;0;False;0;0.13;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.TFHCRemapNode;31;-1233.634,400.2598;Float;False;5;0;FLOAT;0;False;1;FLOAT;-0.5;False;2;FLOAT;0.5;False;3;FLOAT;0;False;4;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;32;-1026.933,450.9598;Float;False;2;2;0;FLOAT;0;False;1;FLOAT;-1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;18;-1243.665,617.9821;Float;True;Property;_5455;5455;4;0;Create;True;0;0;False;0;f9a19241135f86c4d821ee4c61e0c447;f9a19241135f86c4d821ee4c61e0c447;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleAddOpNode;24;-917.4127,612.143;Float;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;29;-781.7056,487.9545;Float;False;Constant;_Float4;Float 4;7;0;Create;True;0;0;False;0;1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;28;-785.8783,411.819;Float;False;Constant;_Float3;Float 3;7;0;Create;True;0;0;False;0;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;23;-772.4126,570.143;Float;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;15;-792.8137,50.98309;Float;False;Property;_Intensidad;Intensidad;3;0;Create;True;0;0;False;0;2;2.88;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ColorNode;3;-1087.902,-308.2317;Float;False;Property;_Color;Color;1;0;Create;True;0;0;False;0;0.8962264,0,0.1184583,0;0,0.3815562,1,0;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;1;-1108.902,-137.2317;Float;True;Property;_Textura;Textura;0;0;Create;True;0;0;False;0;None;d48e737deb4a3af4199993c60b2d74bb;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.LerpOp;21;-556.4127,493.143;Float;True;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;30;-284.96,243.9923;Float;True;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;2;-645.902,-186.2317;Float;True;3;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;0,0;Float;False;True;2;Float;ASEMaterialInspector;0;0;Standard;Brandon/TiendaActivacion;False;False;False;False;False;False;False;False;False;False;False;False;False;False;True;False;False;False;False;False;Back;0;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Custom;0.5;True;True;0;True;TransparentCutout;;Transparent;ForwardOnly;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;True;0;2;False;-1;3;False;-1;0;5;False;-1;10;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;2;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;16;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;31;0;25;0
WireConnection;32;0;31;0
WireConnection;24;0;32;0
WireConnection;24;1;18;1
WireConnection;23;0;24;0
WireConnection;21;0;28;0
WireConnection;21;1;29;0
WireConnection;21;2;23;0
WireConnection;30;0;1;1
WireConnection;30;1;21;0
WireConnection;2;0;3;0
WireConnection;2;1;1;0
WireConnection;2;2;15;0
WireConnection;0;2;2;0
WireConnection;0;10;30;0
ASEEND*/
//CHKSM=450972543152A15D3EB40B83958BDF24D6C982BE