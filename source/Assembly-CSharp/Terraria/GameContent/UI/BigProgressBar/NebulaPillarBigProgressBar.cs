using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000706 RID: 1798
	[global::Cpp2ILInjected.Token(Token = "0x2000AF4")]
	public class NebulaPillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x060045B7 RID: 17847 RVA: 0x0002E799 File Offset: 0x0002C999
		[global::Cpp2ILInjected.Token(Token = "0x600522A")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AB58", Offset = "0x93AB58", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetCurrentShieldValue()
		{
			throw null;
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x0002E79C File Offset: 0x0002C99C
		[global::Cpp2ILInjected.Token(Token = "0x600522B")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ABB4", Offset = "0x93ABB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_ShieldStrengthTowerMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetMaxShieldValue()
		{
			throw null;
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x0002E79F File Offset: 0x0002C99F
		[global::Cpp2ILInjected.Token(Token = "0x600522C")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AC0C", Offset = "0x93AC0C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneTowerNebula", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override bool IsPlayerInCombatArea()
		{
			throw null;
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0002E7A2 File Offset: 0x0002C9A2
		[global::Cpp2ILInjected.Token(Token = "0x600522D")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AC64", Offset = "0x93AC64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NebulaPillarBigProgressBar()
		{
			throw null;
		}
	}
}
