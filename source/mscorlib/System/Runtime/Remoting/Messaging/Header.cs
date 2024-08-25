using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003A8")]
	[global::System.Serializable]
	public class Header
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string HeaderNamespace;

		[global::Cpp2ILInjected.Token(Token = "0x4000F24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool MustUnderstand;

		[global::Cpp2ILInjected.Token(Token = "0x4000F25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string Name;

		[global::Cpp2ILInjected.Token(Token = "0x4000F26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public object Value;
	}
}
