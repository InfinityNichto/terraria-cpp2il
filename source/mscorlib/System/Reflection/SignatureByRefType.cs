using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200042D RID: 1069
	[global::Cpp2ILInjected.Token(Token = "0x20004EC")]
	internal sealed class SignatureByRefType : SignatureHasElementType
	{
		// Token: 0x060021A1 RID: 8609 RVA: 0x0001A2EB File Offset: 0x000184EB
		[global::Cpp2ILInjected.Token(Token = "0x600243B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B844E8", Offset = "0x1B844E8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		internal SignatureByRefType(SignatureType elementType)
		{
			throw null;
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0001A2EE File Offset: 0x000184EE
		[global::Cpp2ILInjected.Token(Token = "0x600243C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8450C", Offset = "0x1B8450C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsArrayImpl()
		{
			throw null;
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0001A2F1 File Offset: 0x000184F1
		[global::Cpp2ILInjected.Token(Token = "0x600243D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84514", Offset = "0x1B84514", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsByRefImpl()
		{
			throw null;
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0001A2F4 File Offset: 0x000184F4
		[global::Cpp2ILInjected.Token(Token = "0x600243E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8451C", Offset = "0x1B8451C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsPointerImpl()
		{
			throw null;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x0001A2F7 File Offset: 0x000184F7
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x0001A2FA File Offset: 0x000184FA
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

		// Token: 0x060021A7 RID: 8615 RVA: 0x0001A2FD File Offset: 0x000184FD
		[global::Cpp2ILInjected.Token(Token = "0x6002441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84534", Offset = "0x1B84534", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override int GetArrayRank()
		{
			throw null;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x0001A300 File Offset: 0x00018500
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
