using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LootSimulation
{
	[global::Cpp2ILInjected.Token(Token = "0x2000859")]
	public class SimulatorInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004369")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A2878", Offset = "0x7A2878", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = "TryGettingLootFor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SimulatorInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600436A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A2FAC", Offset = "0x7A2FAC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.SimulationConditionSetters.<>c", Member = "<.cctor>b__16_15", MemberParameters = new object[] { typeof(SimulatorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.SimulationConditionSetters.<>c", Member = "<.cctor>b__16_17", MemberParameters = new object[] { typeof(SimulatorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ReturnToOriginalDaytime()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600436B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3014", Offset = "0x7A3014", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddItem(int itemId, int amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600436C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A306C", Offset = "0x7A306C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ReturnToOriginalPlayerPosition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008171")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Player player;

		[global::Cpp2ILInjected.Token(Token = "0x4008172")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private double _originalDayTimeCounter;

		[global::Cpp2ILInjected.Token(Token = "0x4008173")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _originalDayTimeFlag;

		[global::Cpp2ILInjected.Token(Token = "0x4008174")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private Vector2 _originalPlayerPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4008175")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public bool runningExpertMode;

		[global::Cpp2ILInjected.Token(Token = "0x4008176")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public LootSimulationItemCounter itemCounter;

		[global::Cpp2ILInjected.Token(Token = "0x4008177")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public NPC npcVictim;
	}
}
