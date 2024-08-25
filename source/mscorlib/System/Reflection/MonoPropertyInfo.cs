using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x2000512")]
	internal struct MonoPropertyInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001500")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.Type parent;

		[global::Cpp2ILInjected.Token(Token = "0x4001501")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public global::System.Type declaring_type;

		[global::Cpp2ILInjected.Token(Token = "0x4001502")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string name;

		[global::Cpp2ILInjected.Token(Token = "0x4001503")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public MethodInfo get_method;

		[global::Cpp2ILInjected.Token(Token = "0x4001504")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public MethodInfo set_method;

		[global::Cpp2ILInjected.Token(Token = "0x4001505")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public PropertyAttributes attrs;
	}
}
