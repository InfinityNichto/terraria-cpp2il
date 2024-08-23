using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005AE RID: 1454
	[global::Cpp2ILInjected.Token(Token = "0x2000850")]
	public class PotionOfReturnSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		// Token: 0x06003C08 RID: 15368 RVA: 0x0002CB8E File Offset: 0x0002AD8E
		[global::Cpp2ILInjected.Token(Token = "0x600433A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A0DF8", Offset = "0x7A0DF8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractPotionOfReturn", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ClearSelfAndPrepareForCheck()
		{
			throw null;
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x0002CB91 File Offset: 0x0002AD91
		[global::Cpp2ILInjected.Token(Token = "0x600433B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A0E4C", Offset = "0x7A0E4C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PotionOfReturnHelper), Member = "TryGetGateHitbox", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref Rectangle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ClosestPointInRect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			throw null;
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x0002CB94 File Offset: 0x0002AD94
		[global::Cpp2ILInjected.Token(Token = "0x600433C")]
		[global::Cpp2ILInjected.Address(RVA = "0x79E920", Offset = "0x79E920", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartInteractSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PotionOfReturnSmartInteractCandidateProvider()
		{
			throw null;
		}

		// Token: 0x04006B51 RID: 27473
		[global::Cpp2ILInjected.Token(Token = "0x400815E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private PotionOfReturnSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x020009AD RID: 2477
		[global::Cpp2ILInjected.Token(Token = "0x2000851")]
		private class ReusableCandidate : ISmartInteractCandidate
		{
			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x06004E07 RID: 19975 RVA: 0x0002FC51 File Offset: 0x0002DE51
			// (set) Token: 0x06004E08 RID: 19976 RVA: 0x0002FC54 File Offset: 0x0002DE54
			[global::Cpp2ILInjected.Token(Token = "0x170007CA")]
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600433D")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A1138", Offset = "0x7A1138", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600433E")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A1140", Offset = "0x7A1140", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004E09 RID: 19977 RVA: 0x0002FC57 File Offset: 0x0002DE57
			[global::Cpp2ILInjected.Token(Token = "0x600433F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A1148", Offset = "0x7A1148", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractPotionOfReturn", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractShowingGenuine", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void WinCandidacy()
			{
				throw null;
			}

			// Token: 0x06004E0A RID: 19978 RVA: 0x0002FC5A File Offset: 0x0002DE5A
			[global::Cpp2ILInjected.Token(Token = "0x6004340")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A1128", Offset = "0x7A1128", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reuse(float distanceFromCursor)
			{
				throw null;
			}

			// Token: 0x06004E0B RID: 19979 RVA: 0x0002FC5D File Offset: 0x0002DE5D
			[global::Cpp2ILInjected.Token(Token = "0x6004341")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A1130", Offset = "0x7A1130", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReusableCandidate()
			{
				throw null;
			}

			// Token: 0x04008CC2 RID: 36034
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400815F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private float <DistanceFromCursor>k__BackingField;
		}
	}
}
