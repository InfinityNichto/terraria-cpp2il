using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.UI.ResourceSets
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A87")]
	public struct PlayerStatsSnapshot
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004FA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FFF88", Offset = "0x8FFF88", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "PrepareFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "PrepareFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public PlayerStatsSnapshot(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008889")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int Life;

		[global::Cpp2ILInjected.Token(Token = "0x400888A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int LifeMax;

		[global::Cpp2ILInjected.Token(Token = "0x400888B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int LifeFruitCount;

		[global::Cpp2ILInjected.Token(Token = "0x400888C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float LifePerSegment;

		[global::Cpp2ILInjected.Token(Token = "0x400888D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int Mana;

		[global::Cpp2ILInjected.Token(Token = "0x400888E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int ManaMax;

		[global::Cpp2ILInjected.Token(Token = "0x400888F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float ManaPerSegment;
	}
}
