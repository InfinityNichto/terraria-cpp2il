using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200006D")]
	public enum RenderTextureCreationFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
		MipMap = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
		AutoGenerateMips = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
		SRGB = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
		EyeTexture = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
		EnableRandomWrite = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40002CC")]
		CreatedFromScript = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40002CD")]
		AllowVerticalFlip = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40002CE")]
		NoResolvedColorSurface = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
		DynamicallyScalable = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
		BindMS = 2048
	}
}
