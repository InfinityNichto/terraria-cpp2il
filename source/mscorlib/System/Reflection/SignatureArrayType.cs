using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004EB")]
	internal sealed class SignatureArrayType : SignatureHasElementType
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84388", Offset = "0x1B84388", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002434")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843E8", Offset = "0x1B843E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsArrayImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843F0", Offset = "0x1B843F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsByRefImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843F8", Offset = "0x1B843F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsPointerImpl()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84418", Offset = "0x1B84418", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public sealed override int GetArrayRank()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001418")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int _rank;

		[global::Cpp2ILInjected.Token(Token = "0x4001419")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private readonly bool _isMultiDim;
	}
}
