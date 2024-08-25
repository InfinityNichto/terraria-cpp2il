using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004EC")]
	internal sealed class SignatureByRefType : SignatureHasElementType
	{
		[global::Cpp2ILInjected.Token(Token = "0x600243B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B844E8", Offset = "0x1B844E8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		internal SignatureByRefType(SignatureType elementType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600243C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8450C", Offset = "0x1B8450C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsArrayImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600243D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84514", Offset = "0x1B84514", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsByRefImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600243E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8451C", Offset = "0x1B8451C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsPointerImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D6")]
		public sealed override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600243F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84524", Offset = "0x1B84524", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D7")]
		public sealed override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002440")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8452C", Offset = "0x1B8452C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84534", Offset = "0x1B84534", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override int GetArrayRank()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D8")]
		protected sealed override string Suffix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002442")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84580", Offset = "0x1B84580", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}
	}
}
