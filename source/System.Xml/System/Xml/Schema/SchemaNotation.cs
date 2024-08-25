using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000134")]
	internal sealed class SchemaNotation
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCBDA8", Offset = "0x1DCBDA8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SchemaNotation(XmlQualifiedName name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000300")]
		internal XmlQualifiedName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDD0", Offset = "0x1DCBDD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000301")]
		internal string SystemLiteral
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDD8", Offset = "0x1DCBDD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDE0", Offset = "0x1DCBDE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000302")]
		internal string Pubid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDE8", Offset = "0x1DCBDE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDF0", Offset = "0x1DCBDF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000559")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlQualifiedName name;

		[global::Cpp2ILInjected.Token(Token = "0x400055A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string systemLiteral;

		[global::Cpp2ILInjected.Token(Token = "0x400055B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string pubid;
	}
}
