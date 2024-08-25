using System;
using Cpp2ILInjected;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x20005BD")]
	internal struct InternalCodePageDataItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x40018F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal ushort codePage;

		[global::Cpp2ILInjected.Token(Token = "0x40018F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		internal ushort uiFamilyCodePage;

		[global::Cpp2ILInjected.Token(Token = "0x40018F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		internal uint flags;

		[global::Cpp2ILInjected.Token(Token = "0x40018F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal string Names;
	}
}
