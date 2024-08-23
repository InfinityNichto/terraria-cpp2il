using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000705 RID: 1797
	[global::Cpp2ILInjected.Token(Token = "0x2000AF3")]
	public class VortexPillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x060045B3 RID: 17843 RVA: 0x0002E78D File Offset: 0x0002C98D
		[global::Cpp2ILInjected.Token(Token = "0x6005226")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AA44", Offset = "0x93AA44", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetCurrentShieldValue()
		{
			throw null;
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x0002E790 File Offset: 0x0002C990
		[global::Cpp2ILInjected.Token(Token = "0x6005227")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AAA0", Offset = "0x93AAA0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_ShieldStrengthTowerMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override float GetMaxShieldValue()
		{
			throw null;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x0002E793 File Offset: 0x0002C993
		[global::Cpp2ILInjected.Token(Token = "0x6005228")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AAF8", Offset = "0x93AAF8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneTowerVortex", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override bool IsPlayerInCombatArea()
		{
			throw null;
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x0002E796 File Offset: 0x0002C996
		[global::Cpp2ILInjected.Token(Token = "0x6005229")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AB50", Offset = "0x93AB50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public VortexPillarBigProgressBar()
		{
			throw null;
		}
	}
}
