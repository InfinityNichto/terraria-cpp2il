using System;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000108 RID: 264
	[global::Cpp2ILInjected.Token(Token = "0x2000138")]
	public sealed class XmlAtomicValue : XPathItem, ICloneable
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x00004C58 File Offset: 0x00002E58
		[global::Cpp2ILInjected.Token(Token = "0x6000AA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCBF4C", Offset = "0x1DCBF4C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBooleanConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBooleanConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlAtomicValue(XmlSchemaType xmlType, bool value)
		{
			throw null;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00004C5B File Offset: 0x00002E5B
		[global::Cpp2ILInjected.Token(Token = "0x6000AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCBFD4", Offset = "0x1DCBFD4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
		{
			throw null;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00004C5E File Offset: 0x00002E5E
		[global::Cpp2ILInjected.Token(Token = "0x6000AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC058", Offset = "0x1DCC058", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(double),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(double),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlAtomicValue(XmlSchemaType xmlType, double value)
		{
			throw null;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00004C61 File Offset: 0x00002E61
		[global::Cpp2ILInjected.Token(Token = "0x6000AA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC0E4", Offset = "0x1DCC0E4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlAtomicValue(XmlSchemaType xmlType, int value)
		{
			throw null;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00004C64 File Offset: 0x00002E64
		[global::Cpp2ILInjected.Token(Token = "0x6000AA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC168", Offset = "0x1DCC168", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(long),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(long),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlAtomicValue(XmlSchemaType xmlType, long value)
		{
			throw null;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00004C67 File Offset: 0x00002E67
		[global::Cpp2ILInjected.Token(Token = "0x6000AA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC1EC", Offset = "0x1DCC1EC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBooleanConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBooleanConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlStringConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlStringConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal XmlAtomicValue(XmlSchemaType xmlType, string value)
		{
			throw null;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00004C6A File Offset: 0x00002E6A
		[global::Cpp2ILInjected.Token(Token = "0x6000AA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC288", Offset = "0x1DCC288", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_TypeCode", ReturnType = typeof(XmlTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = "GetPrefixFromQName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00004C6D File Offset: 0x00002E6D
		[global::Cpp2ILInjected.Token(Token = "0x6000AA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC5C4", Offset = "0x1DCC5C4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal XmlAtomicValue(XmlSchemaType xmlType, object value)
		{
			throw null;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00004C70 File Offset: 0x00002E70
		[global::Cpp2ILInjected.Token(Token = "0x6000AA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC660", Offset = "0x1DCC660", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_List), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_TypeCode", ReturnType = typeof(XmlTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00004C73 File Offset: 0x00002E73
		[global::Cpp2ILInjected.Token(Token = "0x6000AA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC82C", Offset = "0x1DCC82C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private object System.ICloneable.Clone()
		{
			throw null;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00004C76 File Offset: 0x00002E76
		[global::Cpp2ILInjected.Token(Token = "0x17000305")]
		public override XmlSchemaType XmlType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCC830", Offset = "0x1DCC830", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00004C79 File Offset: 0x00002E79
		[global::Cpp2ILInjected.Token(Token = "0x17000306")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCC838", Offset = "0x1DCC838", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00004C7C File Offset: 0x00002E7C
		[global::Cpp2ILInjected.Token(Token = "0x17000307")]
		public override object TypedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCC84C", Offset = "0x1DCC84C", Length = "0x190")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00004C7F File Offset: 0x00002E7F
		[global::Cpp2ILInjected.Token(Token = "0x17000308")]
		public override bool ValueAsBoolean
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCCA54", Offset = "0x1DCCA54", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00004C82 File Offset: 0x00002E82
		[global::Cpp2ILInjected.Token(Token = "0x17000309")]
		public override DateTime ValueAsDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCCB04", Offset = "0x1DCCB04", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00004C85 File Offset: 0x00002E85
		[global::Cpp2ILInjected.Token(Token = "0x1700030A")]
		public override double ValueAsDouble
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCCBC8", Offset = "0x1DCCBC8", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00004C88 File Offset: 0x00002E88
		[global::Cpp2ILInjected.Token(Token = "0x1700030B")]
		public override int ValueAsInt
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCCC88", Offset = "0x1DCCC88", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00004C8B File Offset: 0x00002E8B
		[global::Cpp2ILInjected.Token(Token = "0x1700030C")]
		public override long ValueAsLong
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCCD40", Offset = "0x1DCCD40", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00004C8E File Offset: 0x00002E8E
		[global::Cpp2ILInjected.Token(Token = "0x6000AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCCE04", Offset = "0x1DCCE04", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00004C91 File Offset: 0x00002E91
		[global::Cpp2ILInjected.Token(Token = "0x1700030D")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD014", Offset = "0x1DCD014", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00004C94 File Offset: 0x00002E94
		[global::Cpp2ILInjected.Token(Token = "0x6000AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD0E8", Offset = "0x1DCD0E8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00004C97 File Offset: 0x00002E97
		[global::Cpp2ILInjected.Token(Token = "0x6000AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCC4D4", Offset = "0x1DCC4D4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidateNames), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string GetPrefixFromQName(string value)
		{
			throw null;
		}

		// Token: 0x040003DB RID: 987
		[global::Cpp2ILInjected.Token(Token = "0x4000563")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaType xmlType;

		// Token: 0x040003DC RID: 988
		[global::Cpp2ILInjected.Token(Token = "0x4000564")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object objVal;

		// Token: 0x040003DD RID: 989
		[global::Cpp2ILInjected.Token(Token = "0x4000565")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TypeCode clrType;

		// Token: 0x040003DE RID: 990
		[global::Cpp2ILInjected.Token(Token = "0x4000566")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlAtomicValue.Union unionVal;

		// Token: 0x040003DF RID: 991
		[global::Cpp2ILInjected.Token(Token = "0x4000567")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlAtomicValue.NamespacePrefixForQName nsPrefix;

		// Token: 0x02000176 RID: 374
		[global::Cpp2ILInjected.Token(Token = "0x2000139")]
		[StructLayout(2, Pack = 1)]
		private struct Union
		{
			// Token: 0x04000676 RID: 1654
			[global::Cpp2ILInjected.Token(Token = "0x4000568")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public bool boolVal;

			// Token: 0x04000677 RID: 1655
			[global::Cpp2ILInjected.Token(Token = "0x4000569")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public double dblVal;

			// Token: 0x04000678 RID: 1656
			[global::Cpp2ILInjected.Token(Token = "0x400056A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public long i64Val;

			// Token: 0x04000679 RID: 1657
			[global::Cpp2ILInjected.Token(Token = "0x400056B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public int i32Val;

			// Token: 0x0400067A RID: 1658
			[global::Cpp2ILInjected.Token(Token = "0x400056C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public DateTime dtVal;
		}

		// Token: 0x02000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x200013A")]
		private class NamespacePrefixForQName : IXmlNamespaceResolver
		{
			// Token: 0x06000CCA RID: 3274 RVA: 0x000053BA File Offset: 0x000035BA
			[global::Cpp2ILInjected.Token(Token = "0x6000AB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCC598", Offset = "0x1DCC598", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NamespacePrefixForQName(string prefix, string ns)
			{
				throw null;
			}

			// Token: 0x06000CCB RID: 3275 RVA: 0x000053BD File Offset: 0x000035BD
			[global::Cpp2ILInjected.Token(Token = "0x6000AB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD0F4", Offset = "0x1DCD0F4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			public string LookupNamespace(string prefix)
			{
				throw null;
			}

			// Token: 0x06000CCC RID: 3276 RVA: 0x000053C0 File Offset: 0x000035C0
			[global::Cpp2ILInjected.Token(Token = "0x6000AB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD128", Offset = "0x1DCD128", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			public string LookupPrefix(string namespaceName)
			{
				throw null;
			}

			// Token: 0x0400067B RID: 1659
			[global::Cpp2ILInjected.Token(Token = "0x400056D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string prefix;

			// Token: 0x0400067C RID: 1660
			[global::Cpp2ILInjected.Token(Token = "0x400056E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string ns;
		}
	}
}
