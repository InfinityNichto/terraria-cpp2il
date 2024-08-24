using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000359 RID: 857
	[global::Cpp2ILInjected.Token(Token = "0x20004B0")]
	public class GenerationProgress
	{
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x00029ED3 File Offset: 0x000280D3
		// (set) Token: 0x06002C37 RID: 11319 RVA: 0x00029ED6 File Offset: 0x000280D6
		[global::Cpp2ILInjected.Token(Token = "0x17000604")]
		public string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F66BC", Offset = "0x12F66BC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldGenerateMenu), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002FE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6728", Offset = "0x12F6728", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 76)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x00029EDC File Offset: 0x000280DC
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x00029ED9 File Offset: 0x000280D9
		[global::Cpp2ILInjected.Token(Token = "0x17000605")]
		public double Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6828", Offset = "0x12F6828", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002FE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F67A0", Offset = "0x12F67A0", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GenerationProgress), Member = "Set", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Clamp", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T", "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x00029EDF File Offset: 0x000280DF
		[global::Cpp2ILInjected.Token(Token = "0x17000606")]
		public double TotalProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6830", Offset = "0x12F6830", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldGenerateMenu), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00029EE2 File Offset: 0x000280E2
		[global::Cpp2ILInjected.Token(Token = "0x6002FE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F685C", Offset = "0x12F685C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 123)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenerationProgress), Member = "set_Value", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		public void Set(double value)
		{
			throw null;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00029EE5 File Offset: 0x000280E5
		[global::Cpp2ILInjected.Token(Token = "0x6002FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F6860", Offset = "0x12F6860", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Start(double weight)
		{
			throw null;
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00029EE8 File Offset: 0x000280E8
		[global::Cpp2ILInjected.Token(Token = "0x6002FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F686C", Offset = "0x12F686C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void End()
		{
			throw null;
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00029EEB File Offset: 0x000280EB
		[global::Cpp2ILInjected.Token(Token = "0x6002FE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F6884", Offset = "0x12F6884", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CreateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenerator), Member = "GenerateWorld", MemberParameters = new object[] { typeof(GenerationProgress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GenerationProgress()
		{
			throw null;
		}

		// Token: 0x040030C4 RID: 12484
		[global::Cpp2ILInjected.Token(Token = "0x400399B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _message;

		// Token: 0x040030C5 RID: 12485
		[global::Cpp2ILInjected.Token(Token = "0x400399C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private double _value;

		// Token: 0x040030C6 RID: 12486
		[global::Cpp2ILInjected.Token(Token = "0x400399D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private double _totalProgress;

		// Token: 0x040030C7 RID: 12487
		[global::Cpp2ILInjected.Token(Token = "0x400399E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public double TotalWeight;

		// Token: 0x040030C8 RID: 12488
		[global::Cpp2ILInjected.Token(Token = "0x400399F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public double CurrentPassWeight;
	}
}
