using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x2000509")]
	internal struct MonoEventInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x40014DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.Type declaring_type;

		[global::Cpp2ILInjected.Token(Token = "0x40014DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public global::System.Type reflected_type;

		[global::Cpp2ILInjected.Token(Token = "0x40014E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string name;

		[global::Cpp2ILInjected.Token(Token = "0x40014E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public MethodInfo add_method;

		[global::Cpp2ILInjected.Token(Token = "0x40014E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public MethodInfo remove_method;

		[global::Cpp2ILInjected.Token(Token = "0x40014E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public MethodInfo raise_method;

		[global::Cpp2ILInjected.Token(Token = "0x40014E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public EventAttributes attrs;

		[global::Cpp2ILInjected.Token(Token = "0x40014E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public MethodInfo[] other_methods;
	}
}
