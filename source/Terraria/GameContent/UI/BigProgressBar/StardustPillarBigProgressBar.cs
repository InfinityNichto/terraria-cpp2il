using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000707 RID: 1799
	[global::Cpp2ILInjected.Token(Token = "0x2000AF5")]
	public class StardustPillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x060045BB RID: 17851 RVA: 0x0002E7A5 File Offset: 0x0002C9A5
		[global::Cpp2ILInjected.Token(Token = "0x600522E")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AC6C", Offset = "0x93AC6C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetCurrentShieldValue()
		{
			throw null;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x0002E7A8 File Offset: 0x0002C9A8
		[global::Cpp2ILInjected.Token(Token = "0x600522F")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ACC8", Offset = "0x93ACC8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_ShieldStrengthTowerMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetMaxShieldValue()
		{
			throw null;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x0002E7AB File Offset: 0x0002C9AB
		[global::Cpp2ILInjected.Token(Token = "0x6005230")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AD20", Offset = "0x93AD20", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneTowerStardust", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override bool IsPlayerInCombatArea()
		{
			throw null;
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x0002E7AE File Offset: 0x0002C9AE
		[global::Cpp2ILInjected.Token(Token = "0x6005231")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AD78", Offset = "0x93AD78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StardustPillarBigProgressBar()
		{
			throw null;
		}
	}
}
