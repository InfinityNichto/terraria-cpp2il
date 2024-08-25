using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering
{
	[global::Cpp2ILInjected.Token(Token = "0x200011A")]
	public struct BatchVisibility
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly int offset;

		[global::Cpp2ILInjected.Token(Token = "0x40004B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly int instancesCount;

		[global::Cpp2ILInjected.Token(Token = "0x40004BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int visibleCount;
	}
}
