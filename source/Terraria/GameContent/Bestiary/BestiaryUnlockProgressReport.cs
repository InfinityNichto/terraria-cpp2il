using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.States;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000613 RID: 1555
	[global::Cpp2ILInjected.Token(Token = "0x2000919")]
	public struct BestiaryUnlockProgressReport
	{
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003E3B RID: 15931 RVA: 0x0002D1E5 File Offset: 0x0002B3E5
		[global::Cpp2ILInjected.Token(Token = "0x17000813")]
		public float CompletionPercent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x810570", Offset = "0x810570", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_SpawnTownNPCs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "GetCompletionPercentText", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "GetProgressPercent", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "GetColorAtBlip", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006C3A RID: 27706
		[global::Cpp2ILInjected.Token(Token = "0x40082BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int EntriesTotal;

		// Token: 0x04006C3B RID: 27707
		[global::Cpp2ILInjected.Token(Token = "0x40082BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float CompletionAmountTotal;
	}
}
