using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E5 RID: 229
	[global::Cpp2ILInjected.Token(Token = "0x2000111")]
	internal class Datatype_unsignedLong : Datatype_nonNegativeInteger
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0000492B File Offset: 0x00002B2B
		[global::Cpp2ILInjected.Token(Token = "0x17000294")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000986")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3DD4", Offset = "0x1DC3DD4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0000492E File Offset: 0x00002B2E
		[global::Cpp2ILInjected.Token(Token = "0x17000295")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000987")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3E2C", Offset = "0x1DC3E2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00004931 File Offset: 0x00002B31
		[global::Cpp2ILInjected.Token(Token = "0x6000988")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3E34", Offset = "0x1DC3E34", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00004934 File Offset: 0x00002B34
		[global::Cpp2ILInjected.Token(Token = "0x17000296")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000989")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3EC0", Offset = "0x1DC3EC0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00004937 File Offset: 0x00002B37
		[global::Cpp2ILInjected.Token(Token = "0x17000297")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600098A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3F18", Offset = "0x1DC3F18", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000493A File Offset: 0x00002B3A
		[global::Cpp2ILInjected.Token(Token = "0x600098B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3F70", Offset = "0x1DC3F70", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToUInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref ulong)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0000493D File Offset: 0x00002B3D
		[global::Cpp2ILInjected.Token(Token = "0x600098C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC40E8", Offset = "0x1DC40E8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_unsignedInt), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_unsignedLong()
		{
			throw null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00004940 File Offset: 0x00002B40
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600098D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC413C", Offset = "0x1DC413C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Datatype_unsignedLong()
		{
			throw null;
		}

		// Token: 0x04000380 RID: 896
		[global::Cpp2ILInjected.Token(Token = "0x40004FA")]
		private static readonly Type atomicValueType;

		// Token: 0x04000381 RID: 897
		[global::Cpp2ILInjected.Token(Token = "0x40004FB")]
		private static readonly Type listValueType;

		// Token: 0x04000382 RID: 898
		[global::Cpp2ILInjected.Token(Token = "0x40004FC")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
