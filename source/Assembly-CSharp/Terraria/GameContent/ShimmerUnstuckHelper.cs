using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Drawing;

namespace Terraria.GameContent
{
	// Token: 0x02000561 RID: 1377
	[global::Cpp2ILInjected.Token(Token = "0x20007E9")]
	public struct ShimmerUnstuckHelper
	{
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x0002C62A File Offset: 0x0002A82A
		[global::Cpp2ILInjected.Token(Token = "0x170007C0")]
		public bool ShouldUnstuck
		{
			[global::Cpp2ILInjected.Token(Token = "0x600411C")]
			[global::Cpp2ILInjected.Address(RVA = "0x778110", Offset = "0x778110", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x0002C62D File Offset: 0x0002A82D
		[global::Cpp2ILInjected.Token(Token = "0x600411D")]
		[global::Cpp2ILInjected.Address(RVA = "0x778130", Offset = "0x778130", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "BroadcastOrRequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update(Player player)
		{
			throw null;
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x0002C630 File Offset: 0x0002A830
		[global::Cpp2ILInjected.Token(Token = "0x600411E")]
		[global::Cpp2ILInjected.Address(RVA = "0x77821C", Offset = "0x77821C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ShimmerUnstuck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void StartUnstuck()
		{
			throw null;
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x0002C633 File Offset: 0x0002A833
		[global::Cpp2ILInjected.Token(Token = "0x600411F")]
		[global::Cpp2ILInjected.Address(RVA = "0x778230", Offset = "0x778230", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateDead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x04006937 RID: 26935
		[global::Cpp2ILInjected.Token(Token = "0x4007ED8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int TimeLeftUnstuck;

		// Token: 0x04006938 RID: 26936
		[global::Cpp2ILInjected.Token(Token = "0x4007ED9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool IndefiniteProtectionActive;
	}
}
