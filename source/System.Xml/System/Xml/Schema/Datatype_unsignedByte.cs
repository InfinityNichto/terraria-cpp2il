using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E8 RID: 232
	[global::Cpp2ILInjected.Token(Token = "0x2000114")]
	internal class Datatype_unsignedByte : Datatype_unsignedShort
	{
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00004973 File Offset: 0x00002B73
		[global::Cpp2ILInjected.Token(Token = "0x170002A0")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600099E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC4BEC", Offset = "0x1DC4BEC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00004976 File Offset: 0x00002B76
		[global::Cpp2ILInjected.Token(Token = "0x170002A1")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600099F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC4C44", Offset = "0x1DC4C44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00004979 File Offset: 0x00002B79
		[global::Cpp2ILInjected.Token(Token = "0x60009A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4C4C", Offset = "0x1DC4C4C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0000497C File Offset: 0x00002B7C
		[global::Cpp2ILInjected.Token(Token = "0x170002A2")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC4CD8", Offset = "0x1DC4CD8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0000497F File Offset: 0x00002B7F
		[global::Cpp2ILInjected.Token(Token = "0x170002A3")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC4D30", Offset = "0x1DC4D30", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00004982 File Offset: 0x00002B82
		[global::Cpp2ILInjected.Token(Token = "0x60009A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4D88", Offset = "0x1DC4D88", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref byte)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00004985 File Offset: 0x00002B85
		[global::Cpp2ILInjected.Token(Token = "0x60009A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4EBC", Offset = "0x1DC4EBC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_unsignedShort), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_unsignedByte()
		{
			throw null;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00004988 File Offset: 0x00002B88
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4F10", Offset = "0x1DC4F10", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Datatype_unsignedByte()
		{
			throw null;
		}

		// Token: 0x04000389 RID: 905
		[global::Cpp2ILInjected.Token(Token = "0x4000503")]
		private static readonly Type atomicValueType;

		// Token: 0x0400038A RID: 906
		[global::Cpp2ILInjected.Token(Token = "0x4000504")]
		private static readonly Type listValueType;

		// Token: 0x0400038B RID: 907
		[global::Cpp2ILInjected.Token(Token = "0x4000505")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
