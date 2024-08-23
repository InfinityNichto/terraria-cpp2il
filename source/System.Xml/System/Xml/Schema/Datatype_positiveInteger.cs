using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E9 RID: 233
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0000498B File Offset: 0x00002B8B
		[global::Cpp2ILInjected.Token(Token = "0x170002A4")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC5088", Offset = "0x1DC5088", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0000498E File Offset: 0x00002B8E
		[global::Cpp2ILInjected.Token(Token = "0x170002A5")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC50E0", Offset = "0x1DC50E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00004991 File Offset: 0x00002B91
		[global::Cpp2ILInjected.Token(Token = "0x60009A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC50E8", Offset = "0x1DC50E8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_positiveInteger()
		{
			throw null;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00004994 File Offset: 0x00002B94
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC513C", Offset = "0x1DC513C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static Datatype_positiveInteger()
		{
			throw null;
		}

		// Token: 0x0400038C RID: 908
		[global::Cpp2ILInjected.Token(Token = "0x4000506")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
