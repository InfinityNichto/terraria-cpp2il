using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000CD RID: 205
	[global::Cpp2ILInjected.Token(Token = "0x20000F9")]
	internal class Datatype_hexBinary : Datatype_anySimpleType
	{
		// Token: 0x06000873 RID: 2163 RVA: 0x000047B1 File Offset: 0x000029B1
		[global::Cpp2ILInjected.Token(Token = "0x6000908")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0C50", Offset = "0x1DC0C50", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x000047B4 File Offset: 0x000029B4
		[global::Cpp2ILInjected.Token(Token = "0x17000251")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000909")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0C5C", Offset = "0x1DC0C5C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x000047B7 File Offset: 0x000029B7
		[global::Cpp2ILInjected.Token(Token = "0x17000252")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600090A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0CB4", Offset = "0x1DC0CB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000047BA File Offset: 0x000029BA
		[global::Cpp2ILInjected.Token(Token = "0x17000253")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600090B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0CBC", Offset = "0x1DC0CBC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000047BD File Offset: 0x000029BD
		[global::Cpp2ILInjected.Token(Token = "0x17000254")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600090C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0D14", Offset = "0x1DC0D14", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000047C0 File Offset: 0x000029C0
		[global::Cpp2ILInjected.Token(Token = "0x17000255")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x600090D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0D6C", Offset = "0x1DC0D6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000047C3 File Offset: 0x000029C3
		[global::Cpp2ILInjected.Token(Token = "0x600090E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0D74", Offset = "0x1DC0D74", Length = "0xBC")]
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

		// Token: 0x0600087A RID: 2170 RVA: 0x000047C6 File Offset: 0x000029C6
		[global::Cpp2ILInjected.Token(Token = "0x600090F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0E30", Offset = "0x1DC0E30", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "FromBinHexString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000047C9 File Offset: 0x000029C9
		[global::Cpp2ILInjected.Token(Token = "0x6000910")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0FC8", Offset = "0x1DC0FC8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_hexBinary()
		{
			throw null;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000047CC File Offset: 0x000029CC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000911")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC101C", Offset = "0x1DC101C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_hexBinary()
		{
			throw null;
		}

		// Token: 0x04000367 RID: 871
		[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
		private static readonly Type atomicValueType;

		// Token: 0x04000368 RID: 872
		[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
		private static readonly Type listValueType;
	}
}
