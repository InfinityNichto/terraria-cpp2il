using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200011F")]
	public enum ShaderPropertyFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004CF")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40004D0")]
		HideInInspector = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40004D1")]
		PerRendererData = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40004D2")]
		NoScaleOffset = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40004D3")]
		Normal = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40004D4")]
		HDR = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40004D5")]
		Gamma = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40004D6")]
		NonModifiableTextureData = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40004D7")]
		MainTexture = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40004D8")]
		MainColor = 256
	}
}
