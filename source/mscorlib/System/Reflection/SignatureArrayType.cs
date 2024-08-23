using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200042C RID: 1068
	[global::Cpp2ILInjected.Token(Token = "0x20004EB")]
	internal sealed class SignatureArrayType : SignatureHasElementType
	{
		// Token: 0x06002199 RID: 8601 RVA: 0x0001A2D3 File Offset: 0x000184D3
		[global::Cpp2ILInjected.Token(Token = "0x6002433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84388", Offset = "0x1B84388", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim)
		{
			throw null;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0001A2D6 File Offset: 0x000184D6
		[global::Cpp2ILInjected.Token(Token = "0x6002434")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843E8", Offset = "0x1B843E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsArrayImpl()
		{
			throw null;
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0001A2D9 File Offset: 0x000184D9
		[global::Cpp2ILInjected.Token(Token = "0x6002435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843F0", Offset = "0x1B843F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsByRefImpl()
		{
			throw null;
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0001A2DC File Offset: 0x000184DC
		[global::Cpp2ILInjected.Token(Token = "0x6002436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843F8", Offset = "0x1B843F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsPointerImpl()
		{
			throw null;
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0001A2DF File Offset: 0x000184DF
		[global::Cpp2ILInjected.Token(Token = "0x170004D3")]
		public sealed override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002437")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84400", Offset = "0x1B84400", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x0001A2E2 File Offset: 0x000184E2
		[global::Cpp2ILInjected.Token(Token = "0x170004D4")]
		public sealed override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002438")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84410", Offset = "0x1B84410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0001A2E5 File Offset: 0x000184E5
		[global::Cpp2ILInjected.Token(Token = "0x6002439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84418", Offset = "0x1B84418", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public sealed override int GetArrayRank()
		{
			throw null;
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x0001A2E8 File Offset: 0x000184E8
		[global::Cpp2ILInjected.Token(Token = "0x170004D5")]
		protected sealed override string Suffix
		{
			[global::Cpp2ILInjected.Token(Token = "0x600243A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84420", Offset = "0x1B84420", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040010FE RID: 4350
		[global::Cpp2ILInjected.Token(Token = "0x4001418")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int _rank;

		// Token: 0x040010FF RID: 4351
		[global::Cpp2ILInjected.Token(Token = "0x4001419")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private readonly bool _isMultiDim;
	}
}
