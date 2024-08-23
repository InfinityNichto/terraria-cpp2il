using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E7 RID: 231
	[global::Cpp2ILInjected.Token(Token = "0x2000113")]
	internal class Datatype_unsignedShort : Datatype_unsignedInt
	{
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0000495B File Offset: 0x00002B5B
		[global::Cpp2ILInjected.Token(Token = "0x1700029C")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000996")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC4750", Offset = "0x1DC4750", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0000495E File Offset: 0x00002B5E
		[global::Cpp2ILInjected.Token(Token = "0x1700029D")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000997")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC47A8", Offset = "0x1DC47A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00004961 File Offset: 0x00002B61
		[global::Cpp2ILInjected.Token(Token = "0x6000998")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC47B0", Offset = "0x1DC47B0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00004964 File Offset: 0x00002B64
		[global::Cpp2ILInjected.Token(Token = "0x1700029E")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000999")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC483C", Offset = "0x1DC483C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00004967 File Offset: 0x00002B67
		[global::Cpp2ILInjected.Token(Token = "0x1700029F")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600099A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC4894", Offset = "0x1DC4894", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0000496A File Offset: 0x00002B6A
		[global::Cpp2ILInjected.Token(Token = "0x600099B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC48EC", Offset = "0x1DC48EC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToUInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref ushort)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0000496D File Offset: 0x00002B6D
		[global::Cpp2ILInjected.Token(Token = "0x600099C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4A20", Offset = "0x1DC4A20", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_unsignedByte), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_unsignedInt), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_unsignedShort()
		{
			throw null;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00004970 File Offset: 0x00002B70
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600099D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4A74", Offset = "0x1DC4A74", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Datatype_unsignedShort()
		{
			throw null;
		}

		// Token: 0x04000386 RID: 902
		[global::Cpp2ILInjected.Token(Token = "0x4000500")]
		private static readonly Type atomicValueType;

		// Token: 0x04000387 RID: 903
		[global::Cpp2ILInjected.Token(Token = "0x4000501")]
		private static readonly Type listValueType;

		// Token: 0x04000388 RID: 904
		[global::Cpp2ILInjected.Token(Token = "0x4000502")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
