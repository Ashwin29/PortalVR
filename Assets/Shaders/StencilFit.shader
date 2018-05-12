Shader "Custom/StencilFit"
{
	Properties
	{
		_Color("Color", color) = ( 1, 1, 1, 1)
	    [Enum(Equal, 3, NotEqual, 6)] _StencilTest("Stencil Test", int) = 6
	}
	SubShader
	{
		Color [_Color]
		Stencil {
		Ref 1
		Comp [_StencilTest]
	}

		Pass
		{
			
		}
	}
}
