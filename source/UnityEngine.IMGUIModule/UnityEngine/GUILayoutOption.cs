using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	public sealed class GUILayoutOption
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C1EC", Offset = "0x1F9C1EC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal GUILayoutOption(GUILayoutOption.Type type, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal GUILayoutOption.Type type;

		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object value;

		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		internal enum Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
			fixedWidth,
			[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
			fixedHeight,
			[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
			minWidth,
			[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
			maxWidth,
			[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
			minHeight,
			[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
			maxHeight,
			[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
			stretchWidth,
			[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
			stretchHeight,
			[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
			alignStart,
			[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
			alignMiddle,
			[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
			alignEnd,
			[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
			alignJustify,
			[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
			equalSize,
			[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
			spacing
		}
	}
}
