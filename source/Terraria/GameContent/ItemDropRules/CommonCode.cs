using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000877")]
	public static class CommonCode
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A73D0", Offset = "0x7A73D0", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonCode), Member = "DropItemForEachInteractingPlayerOnThePlayer", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(UnifiedRandom),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonDrop), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonDropNotScalingWithLuck), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonDropWithRerolls), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MechBossSpawnersDropRule), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeBodyItemDropRule), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropOneByOne), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneFromOptionsNotScaledWithLuckDropRule), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneFromOptionsDropRule), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FromOptionsWithoutRepeatsDropRule), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetItemSource_Loot", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void DropItemFromNPC(NPC npc, int itemId, int stack, bool scattered = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A77E8", Offset = "0x7A77E8", Length = "0x530")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropLocalPerClientAndResetsNPCMoneyTo0), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetItemSource_Loot", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "ModifyItemDropFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static void DropItemLocalPerClientAndSetNPCMoneyTo0(NPC npc, int itemId, int stack, bool interactionRequired = true)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A7D18", Offset = "0x7A7D18", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropPerPlayerOnThePlayer), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetItemSource_Loot", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "ModifyItemDropFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void DropItemForEachInteractingPlayerOnThePlayer(NPC npc, int itemId, UnifiedRandom rng, int chanceNumerator, int chanceDenominator, int stack = 1, bool interactionRequired = true)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A75A0", Offset = "0x7A75A0", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonCode), Member = "DropItemLocalPerClientAndSetNPCMoneyTo0", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonCode), Member = "DropItemForEachInteractingPlayerOnThePlayer", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(UnifiedRandom),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void ModifyItemDropFromNPC(NPC npc, int itemIndex)
		{
			throw null;
		}
	}
}
