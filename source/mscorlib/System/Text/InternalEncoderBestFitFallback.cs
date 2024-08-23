using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E5 RID: 485
	[global::Cpp2ILInjected.Token(Token = "0x200026A")]
	[global::System.Serializable]
	internal class InternalEncoderBestFitFallback : EncoderFallback
	{
		// Token: 0x0600131E RID: 4894 RVA: 0x00017AA4 File Offset: 0x00015CA4
		[global::Cpp2ILInjected.Token(Token = "0x60014D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB432C", Offset = "0x1CB432C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal InternalEncoderBestFitFallback(Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00017AA7 File Offset: 0x00015CA7
		[global::Cpp2ILInjected.Token(Token = "0x60014D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB435C", Offset = "0x1CB435C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(InternalEncoderBestFitFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00017AAA File Offset: 0x00015CAA
		[global::Cpp2ILInjected.Token(Token = "0x17000213")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB44BC", Offset = "0x1CB44BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00017AAD File Offset: 0x00015CAD
		[global::Cpp2ILInjected.Token(Token = "0x60014DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB44C4", Offset = "0x1CB44C4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00017AB0 File Offset: 0x00015CB0
		[global::Cpp2ILInjected.Token(Token = "0x60014DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4578", Offset = "0x1CB4578", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000892 RID: 2194
		[global::Cpp2ILInjected.Token(Token = "0x4000AFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Encoding _encoding;

		// Token: 0x04000893 RID: 2195
		[global::Cpp2ILInjected.Token(Token = "0x4000AFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal char[] _arrayBestFit;
	}
}
