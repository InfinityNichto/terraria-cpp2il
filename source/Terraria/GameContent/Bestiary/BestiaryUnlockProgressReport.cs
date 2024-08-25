using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.States;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000919")]
	public struct BestiaryUnlockProgressReport
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40082BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int EntriesTotal;

		[global::Cpp2ILInjected.Token(Token = "0x40082BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float CompletionAmountTotal;
	}
}
