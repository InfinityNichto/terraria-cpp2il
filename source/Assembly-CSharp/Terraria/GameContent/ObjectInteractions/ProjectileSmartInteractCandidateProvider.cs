using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005AD RID: 1453
	[global::Cpp2ILInjected.Token(Token = "0x200084E")]
	public class ProjectileSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		// Token: 0x06003C05 RID: 15365 RVA: 0x0002CB85 File Offset: 0x0002AD85
		[global::Cpp2ILInjected.Token(Token = "0x6004332")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A0AB0", Offset = "0x7A0AB0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractProj", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ClearSelfAndPrepareForCheck()
		{
			throw null;
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x0002CB88 File Offset: 0x0002AD88
		[global::Cpp2ILInjected.Token(Token = "0x6004333")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A0B04", Offset = "0x7A0B04", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			throw null;
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x0002CB8B File Offset: 0x0002AD8B
		[global::Cpp2ILInjected.Token(Token = "0x6004334")]
		[global::Cpp2ILInjected.Address(RVA = "0x79E980", Offset = "0x79E980", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartInteractSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ProjectileSmartInteractCandidateProvider()
		{
			throw null;
		}

		// Token: 0x04006B50 RID: 27472
		[global::Cpp2ILInjected.Token(Token = "0x400815B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ProjectileSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x020009AC RID: 2476
		[global::Cpp2ILInjected.Token(Token = "0x200084F")]
		private class ReusableCandidate : ISmartInteractCandidate
		{
			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x06004E02 RID: 19970 RVA: 0x0002FC42 File Offset: 0x0002DE42
			// (set) Token: 0x06004E03 RID: 19971 RVA: 0x0002FC45 File Offset: 0x0002DE45
			[global::Cpp2ILInjected.Token(Token = "0x170007C9")]
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004335")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A0D80", Offset = "0x7A0D80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004336")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A0D88", Offset = "0x7A0D88", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004E04 RID: 19972 RVA: 0x0002FC48 File Offset: 0x0002DE48
			[global::Cpp2ILInjected.Token(Token = "0x6004337")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0D90", Offset = "0x7A0D90", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractProj", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractShowingGenuine", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void WinCandidacy()
			{
				throw null;
			}

			// Token: 0x06004E05 RID: 19973 RVA: 0x0002FC4B File Offset: 0x0002DE4B
			[global::Cpp2ILInjected.Token(Token = "0x6004338")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0D6C", Offset = "0x7A0D6C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reuse(int projectileIndex, float projectileDistanceFromCursor)
			{
				throw null;
			}

			// Token: 0x06004E06 RID: 19974 RVA: 0x0002FC4E File Offset: 0x0002DE4E
			[global::Cpp2ILInjected.Token(Token = "0x6004339")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0D78", Offset = "0x7A0D78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReusableCandidate()
			{
				throw null;
			}

			// Token: 0x04008CC0 RID: 36032
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400815C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private float <DistanceFromCursor>k__BackingField;

			// Token: 0x04008CC1 RID: 36033
			[global::Cpp2ILInjected.Token(Token = "0x400815D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _projectileIndexToTarget;
		}
	}
}
