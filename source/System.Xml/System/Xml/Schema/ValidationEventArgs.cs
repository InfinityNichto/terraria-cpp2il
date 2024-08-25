using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000136")]
	public class ValidationEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000303")]
		public XmlSeverityType Severity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDF8", Offset = "0x1DCBDF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000304")]
		public XmlSchemaException Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBE00", Offset = "0x1DCBE00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000561")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaException ex;

		[global::Cpp2ILInjected.Token(Token = "0x4000562")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSeverityType severity;
	}
}
