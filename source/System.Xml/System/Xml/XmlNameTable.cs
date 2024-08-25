using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A9")]
	public abstract class XmlNameTable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000791")]
		public abstract string Get(string array);

		[global::Cpp2ILInjected.Token(Token = "0x6000792")]
		public abstract string Add(char[] array, int offset, int length);

		[global::Cpp2ILInjected.Token(Token = "0x6000793")]
		public abstract string Add(string array);

		[global::Cpp2ILInjected.Token(Token = "0x6000794")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFB30", Offset = "0x1DAFB30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlNameTable()
		{
			throw null;
		}
	}
}
