using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000DE RID: 222
	[global::Cpp2ILInjected.Token(Token = "0x200010A")]
	internal class Datatype_nonPositiveInteger : Datatype_integer
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x000048A7 File Offset: 0x00002AA7
		[global::Cpp2ILInjected.Token(Token = "0x1700027E")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600095A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2780", Offset = "0x1DC2780", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000048AA File Offset: 0x00002AAA
		[global::Cpp2ILInjected.Token(Token = "0x1700027F")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600095B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC27D8", Offset = "0x1DC27D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000048AD File Offset: 0x00002AAD
		[global::Cpp2ILInjected.Token(Token = "0x600095C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC27E0", Offset = "0x1DC27E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		public Datatype_nonPositiveInteger()
		{
			throw null;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000048B0 File Offset: 0x00002AB0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600095D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC27E4", Offset = "0x1DC27E4", Length = "0x108")]
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
		static Datatype_nonPositiveInteger()
		{
			throw null;
		}

		// Token: 0x04000371 RID: 881
		[global::Cpp2ILInjected.Token(Token = "0x40004EB")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
