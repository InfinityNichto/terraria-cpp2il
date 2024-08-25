using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public struct UILineInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int startCharIdx;

		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int height;

		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float topY;

		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float leading;
	}
}
