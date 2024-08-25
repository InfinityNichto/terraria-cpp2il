using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200010A")]
	public enum CompareFunction
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000455")]
		Disabled,
		[global::Cpp2ILInjected.Token(Token = "0x4000456")]
		Never,
		[global::Cpp2ILInjected.Token(Token = "0x4000457")]
		Less,
		[global::Cpp2ILInjected.Token(Token = "0x4000458")]
		Equal,
		[global::Cpp2ILInjected.Token(Token = "0x4000459")]
		LessEqual,
		[global::Cpp2ILInjected.Token(Token = "0x400045A")]
		Greater,
		[global::Cpp2ILInjected.Token(Token = "0x400045B")]
		NotEqual,
		[global::Cpp2ILInjected.Token(Token = "0x400045C")]
		GreaterEqual,
		[global::Cpp2ILInjected.Token(Token = "0x400045D")]
		Always
	}
}
