using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	internal class CharEntityEncoderFallback : EncoderFallback
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003077 File Offset: 0x00001277
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D670", Offset = "0x1D5D670", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = ".ctor", ReturnType = typeof(void))]
		internal CharEntityEncoderFallback()
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000307A File Offset: 0x0000127A
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D678", Offset = "0x1D5D678", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharEntityEncoderFallbackBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(CharEntityEncoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000307D File Offset: 0x0000127D
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5D750", Offset = "0x1D5D750", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00003080 File Offset: 0x00001280
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		internal int StartOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000020")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5D758", Offset = "0x1D5D758", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003083 File Offset: 0x00001283
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D760", Offset = "0x1D5D760", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Reset(int[] textContentMarks, int endMarkPos)
		{
			throw null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003086 File Offset: 0x00001286
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D76C", Offset = "0x1D5D76C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool CanReplaceAt(int index)
		{
			throw null;
		}

		// Token: 0x0400001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CharEntityEncoderFallbackBuffer fallbackBuffer;

		// Token: 0x0400001C RID: 28
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int[] textContentMarks;

		// Token: 0x0400001D RID: 29
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int endMarkPos;

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int curMarkPos;

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int startOffset;
	}
}
