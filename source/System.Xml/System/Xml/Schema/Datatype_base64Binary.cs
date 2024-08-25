using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	internal class Datatype_base64Binary : Datatype_anySimpleType
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000912")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC10D8", Offset = "0x1DC10D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000256")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000913")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC10E4", Offset = "0x1DC10E4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000257")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000914")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC113C", Offset = "0x1DC113C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000258")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000915")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1144", Offset = "0x1DC1144", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000259")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000916")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC119C", Offset = "0x1DC119C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700025A")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000917")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC11F4", Offset = "0x1DC11F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000918")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC11FC", Offset = "0x1DC11FC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "Compare", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000919")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC12B8", Offset = "0x1DC12B8", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600091A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC144C", Offset = "0x1DC144C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_base64Binary()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600091B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC14A0", Offset = "0x1DC14A0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_base64Binary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
		private static readonly Type atomicValueType;

		[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
		private static readonly Type listValueType;
	}
}
