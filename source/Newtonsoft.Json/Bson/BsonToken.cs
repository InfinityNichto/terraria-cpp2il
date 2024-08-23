using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000DA RID: 218
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000123")]
	internal abstract class BsonToken
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000A26 RID: 2598
		[global::Cpp2ILInjected.Token(Token = "0x17000230")]
		public abstract BsonType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B63")]
			get;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00003DF1 File Offset: 0x00001FF1
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[global::Cpp2ILInjected.Token(Token = "0x17000231")]
		public BsonToken Parent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A1E8", Offset = "0x1D3A1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A1F0", Offset = "0x1D3A1F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00003DF7 File Offset: 0x00001FF7
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00003DFA File Offset: 0x00001FFA
		[global::Cpp2ILInjected.Token(Token = "0x17000232")]
		public int CalculatedSize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A1F8", Offset = "0x1D3A1F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A200", Offset = "0x1D3A200", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00003DFD File Offset: 0x00001FFD
		[global::Cpp2ILInjected.Token(Token = "0x6000B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A208", Offset = "0x1D3A208", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected BsonToken()
		{
			throw null;
		}

		// Token: 0x04000325 RID: 805
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400044C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BsonToken <Parent>k__BackingField;

		// Token: 0x04000326 RID: 806
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400044D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <CalculatedSize>k__BackingField;
	}
}
