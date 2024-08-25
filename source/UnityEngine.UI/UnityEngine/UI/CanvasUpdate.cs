using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public enum CanvasUpdate
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		Prelayout,
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		Layout,
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		PostLayout,
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		PreRender,
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		LatePreRender,
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		MaxUpdateValue
	}
}
