using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E0 RID: 224
	[global::Cpp2ILInjected.Token(Token = "0x200010C")]
	internal class Datatype_long : Datatype_integer
	{
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x000048BF File Offset: 0x00002ABF
		[global::Cpp2ILInjected.Token(Token = "0x17000282")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000962")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2AA8", Offset = "0x1DC2AA8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x000048C2 File Offset: 0x00002AC2
		[global::Cpp2ILInjected.Token(Token = "0x17000283")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000963")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2B00", Offset = "0x1DC2B00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000048C5 File Offset: 0x00002AC5
		[global::Cpp2ILInjected.Token(Token = "0x6000964")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2B08", Offset = "0x1DC2B08", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000048C8 File Offset: 0x00002AC8
		[global::Cpp2ILInjected.Token(Token = "0x17000284")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000965")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2B94", Offset = "0x1DC2B94", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x000048CB File Offset: 0x00002ACB
		[global::Cpp2ILInjected.Token(Token = "0x17000285")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000966")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2BEC", Offset = "0x1DC2BEC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000048CE File Offset: 0x00002ACE
		[global::Cpp2ILInjected.Token(Token = "0x6000967")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2C44", Offset = "0x1DC2C44", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref long)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000048D1 File Offset: 0x00002AD1
		[global::Cpp2ILInjected.Token(Token = "0x6000968")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2D78", Offset = "0x1DC2D78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		public Datatype_long()
		{
			throw null;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000048D4 File Offset: 0x00002AD4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000969")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2D7C", Offset = "0x1DC2D7C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Datatype_long()
		{
			throw null;
		}

		// Token: 0x04000373 RID: 883
		[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
		private static readonly Type atomicValueType;

		// Token: 0x04000374 RID: 884
		[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
		private static readonly Type listValueType;

		// Token: 0x04000375 RID: 885
		[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
