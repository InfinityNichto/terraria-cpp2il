using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000704 RID: 1796
	[global::Cpp2ILInjected.Token(Token = "0x2000AF2")]
	public class SolarFlarePillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x060045AF RID: 17839 RVA: 0x0002E781 File Offset: 0x0002C981
		[global::Cpp2ILInjected.Token(Token = "0x6005222")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A930", Offset = "0x93A930", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetCurrentShieldValue()
		{
			throw null;
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x0002E784 File Offset: 0x0002C984
		[global::Cpp2ILInjected.Token(Token = "0x6005223")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A98C", Offset = "0x93A98C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_ShieldStrengthTowerMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetMaxShieldValue()
		{
			throw null;
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x0002E787 File Offset: 0x0002C987
		[global::Cpp2ILInjected.Token(Token = "0x6005224")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A9E4", Offset = "0x93A9E4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneTowerSolar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override bool IsPlayerInCombatArea()
		{
			throw null;
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x0002E78A File Offset: 0x0002C98A
		[global::Cpp2ILInjected.Token(Token = "0x6005225")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AA3C", Offset = "0x93AA3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SolarFlarePillarBigProgressBar()
		{
			throw null;
		}
	}
}
