using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200014A")]
	public class XmlSchemaInfo : IXmlSchemaInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEB34", Offset = "0x1DCEB34", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSchemaInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEB80", Offset = "0x1DCEB80", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XmlSchemaInfo(XmlSchemaValidity validity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000321")]
		public XmlSchemaValidity Validity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEBBC", Offset = "0x1DCEBBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000322")]
		public bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEBC4", Offset = "0x1DCEBC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000323")]
		public bool IsNil
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEBCC", Offset = "0x1DCEBCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000324")]
		public XmlSchemaSimpleType MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEBD4", Offset = "0x1DCEBD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000325")]
		public XmlSchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEBDC", Offset = "0x1DCEBDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000326")]
		public XmlSchemaElement SchemaElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEBE4", Offset = "0x1DCEBE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000327")]
		public XmlSchemaAttribute SchemaAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCEBEC", Offset = "0x1DCEBEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEB64", Offset = "0x1DCEB64", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000598")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool isDefault;

		[global::Cpp2ILInjected.Token(Token = "0x4000599")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool isNil;

		[global::Cpp2ILInjected.Token(Token = "0x400059A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSchemaElement schemaElement;

		[global::Cpp2ILInjected.Token(Token = "0x400059B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlSchemaAttribute schemaAttribute;

		[global::Cpp2ILInjected.Token(Token = "0x400059C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlSchemaType schemaType;

		[global::Cpp2ILInjected.Token(Token = "0x400059D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlSchemaSimpleType memberType;

		[global::Cpp2ILInjected.Token(Token = "0x400059E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XmlSchemaValidity validity;

		[global::Cpp2ILInjected.Token(Token = "0x400059F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private XmlSchemaContentType contentType;
	}
}
