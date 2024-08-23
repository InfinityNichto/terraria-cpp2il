using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E6 RID: 230
	[global::Cpp2ILInjected.Token(Token = "0x2000112")]
	internal class Datatype_unsignedInt : Datatype_unsignedLong
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00004943 File Offset: 0x00002B43
		[global::Cpp2ILInjected.Token(Token = "0x17000298")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600098E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC42B4", Offset = "0x1DC42B4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00004946 File Offset: 0x00002B46
		[global::Cpp2ILInjected.Token(Token = "0x17000299")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600098F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC430C", Offset = "0x1DC430C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00004949 File Offset: 0x00002B49
		[global::Cpp2ILInjected.Token(Token = "0x6000990")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4314", Offset = "0x1DC4314", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0000494C File Offset: 0x00002B4C
		[global::Cpp2ILInjected.Token(Token = "0x1700029A")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000991")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC43A0", Offset = "0x1DC43A0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0000494F File Offset: 0x00002B4F
		[global::Cpp2ILInjected.Token(Token = "0x1700029B")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000992")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC43F8", Offset = "0x1DC43F8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00004952 File Offset: 0x00002B52
		[global::Cpp2ILInjected.Token(Token = "0x6000993")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4450", Offset = "0x1DC4450", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToUInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref uint)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00004955 File Offset: 0x00002B55
		[global::Cpp2ILInjected.Token(Token = "0x6000994")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC4584", Offset = "0x1DC4584", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_unsignedShort), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_unsignedInt()
		{
			throw null;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00004958 File Offset: 0x00002B58
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000995")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC45D8", Offset = "0x1DC45D8", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Datatype_unsignedInt()
		{
			throw null;
		}

		// Token: 0x04000383 RID: 899
		[global::Cpp2ILInjected.Token(Token = "0x40004FD")]
		private static readonly Type atomicValueType;

		// Token: 0x04000384 RID: 900
		[global::Cpp2ILInjected.Token(Token = "0x40004FE")]
		private static readonly Type listValueType;

		// Token: 0x04000385 RID: 901
		[global::Cpp2ILInjected.Token(Token = "0x40004FF")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
