using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000260")]
	internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000203")]
		private static object InternalSyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB1F44", Offset = "0x1CB1F44", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(InternalDecoderBestFitFallback) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600148E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1D88", Offset = "0x1CB1D88", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalDecoderBestFitFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600148F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB1FE0", Offset = "0x1CB1FE0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = "TryBestFit", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(char))]
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001490")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2108", Offset = "0x1CB2108", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override char GetNextChar()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000204")]
		public override int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001491")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB2148", Offset = "0x1CB2148", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2154", Offset = "0x1CB2154", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2164", Offset = "0x1CB2164", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2018", Offset = "0x1CB2018", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private char TryBestFit(byte[] bytesCheck)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private char _cBestFit;

		[global::Cpp2ILInjected.Token(Token = "0x4000AEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _iCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000AEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _iSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000AEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private InternalDecoderBestFitFallback _oFallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000AED")]
		private static object s_InternalSyncObject;
	}
}
