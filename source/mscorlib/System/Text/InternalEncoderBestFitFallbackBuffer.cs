using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E6 RID: 486
	[global::Cpp2ILInjected.Token(Token = "0x200026B")]
	internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x00017AB3 File Offset: 0x00015CB3
		[global::Cpp2ILInjected.Token(Token = "0x17000214")]
		private static object InternalSyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB458C", Offset = "0x1CB458C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(InternalEncoderBestFitFallback) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00017AB6 File Offset: 0x00015CB6
		[global::Cpp2ILInjected.Token(Token = "0x60014DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB43B4", Offset = "0x1CB43B4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalEncoderBestFitFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
		{
			throw null;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00017AB9 File Offset: 0x00015CB9
		[global::Cpp2ILInjected.Token(Token = "0x60014DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4628", Offset = "0x1CB4628", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = "TryBestFit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		public override bool Fallback(char charUnknown, int index)
		{
			throw null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00017ABC File Offset: 0x00015CBC
		[global::Cpp2ILInjected.Token(Token = "0x60014E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB46EC", Offset = "0x1CB46EC", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			throw null;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00017ABF File Offset: 0x00015CBF
		[global::Cpp2ILInjected.Token(Token = "0x60014E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB48C4", Offset = "0x1CB48C4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override char GetNextChar()
		{
			throw null;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00017AC2 File Offset: 0x00015CC2
		[global::Cpp2ILInjected.Token(Token = "0x60014E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4904", Offset = "0x1CB4904", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool MovePrevious()
		{
			throw null;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x00017AC5 File Offset: 0x00015CC5
		[global::Cpp2ILInjected.Token(Token = "0x17000215")]
		public override int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB4930", Offset = "0x1CB4930", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00017AC8 File Offset: 0x00015CC8
		[global::Cpp2ILInjected.Token(Token = "0x60014E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB493C", Offset = "0x1CB493C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00017ACB File Offset: 0x00015CCB
		[global::Cpp2ILInjected.Token(Token = "0x60014E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4658", Offset = "0x1CB4658", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private char TryBestFit(char cUnknown)
		{
			throw null;
		}

		// Token: 0x04000894 RID: 2196
		[global::Cpp2ILInjected.Token(Token = "0x4000B00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private char _cBestFit;

		// Token: 0x04000895 RID: 2197
		[global::Cpp2ILInjected.Token(Token = "0x4000B01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private InternalEncoderBestFitFallback _oFallback;

		// Token: 0x04000896 RID: 2198
		[global::Cpp2ILInjected.Token(Token = "0x4000B02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _iCount;

		// Token: 0x04000897 RID: 2199
		[global::Cpp2ILInjected.Token(Token = "0x4000B03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int _iSize;

		// Token: 0x04000898 RID: 2200
		[global::Cpp2ILInjected.Token(Token = "0x4000B04")]
		private static object s_InternalSyncObject;
	}
}
