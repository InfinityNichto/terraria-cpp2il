using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.GameContent.UI;
using Terraria.Localization;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x0200055C RID: 1372
	[global::Cpp2ILInjected.Token(Token = "0x20007E1")]
	public static class LucyAxeMessage
	{
		// Token: 0x06003A05 RID: 14853 RVA: 0x0002C5B2 File Offset: 0x0002A7B2
		[global::Cpp2ILInjected.Token(Token = "0x60040F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x774FC4", Offset = "0x774FC4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "GetTextForVariation", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string GetCategoryName(LucyAxeMessage.MessageSource source)
		{
			throw null;
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x0002C5B5 File Offset: 0x0002A7B5
		[global::Cpp2ILInjected.Token(Token = "0x60040F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x77506C", Offset = "0x77506C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.ItemTransferEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "add_OnItemTransferred", MemberParameters = new object[] { typeof(ItemSlot.ItemTransferEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.Hooks), Member = "add_OnEnterWorld", MemberParameters = new object[] { typeof(Action<Player>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x0002C5B8 File Offset: 0x0002A7B8
		[global::Cpp2ILInjected.Token(Token = "0x60040F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x77515C", Offset = "0x77515C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void Hooks_OnEnterWorld(Player player)
		{
			throw null;
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x0002C5BB File Offset: 0x0002A7BB
		[global::Cpp2ILInjected.Token(Token = "0x60040F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x775288", Offset = "0x775288", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void UpdateMessageCooldowns()
		{
			throw null;
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x0002C5BE File Offset: 0x0002A7BE
		[global::Cpp2ILInjected.Token(Token = "0x60040F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x775344", Offset = "0x775344", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Top", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "Create", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void TryPlayingIdleMessage()
		{
			throw null;
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x0002C5C1 File Offset: 0x0002A7C1
		[global::Cpp2ILInjected.Token(Token = "0x60040F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x775650", Offset = "0x775650", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "PutMessageTypeOnCooldown", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Top", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "Create", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void ItemSlot_OnItemTransferred(ItemSlot.ItemTransferInfo info)
		{
			throw null;
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x0002C5C4 File Offset: 0x0002A7C4
		[global::Cpp2ILInjected.Token(Token = "0x60040FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7751EC", Offset = "0x7751EC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "Create", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "PutMessageTypeOnCooldown", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void GiveIdleMessageCooldown()
		{
			throw null;
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x0002C5C7 File Offset: 0x0002A7C7
		[global::Cpp2ILInjected.Token(Token = "0x60040FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7757F4", Offset = "0x7757F4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "ItemSlot_OnItemTransferred", MemberParameters = new object[] { typeof(ItemSlot.ItemTransferInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "GiveIdleMessageCooldown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "TryCreatingMessageWithCooldown", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void PutMessageTypeOnCooldown(LucyAxeMessage.MessageSource source, int timeInFrames)
		{
			throw null;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x0002C5CA File Offset: 0x0002A7CA
		[global::Cpp2ILInjected.Token(Token = "0x60040FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7757D0", Offset = "0x7757D0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool CountsAsStorage(int itemSlotContext)
		{
			throw null;
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x0002C5CD File Offset: 0x0002A7CD
		[global::Cpp2ILInjected.Token(Token = "0x60040FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x775864", Offset = "0x775864", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseMiningTools_ActuallyUseMiningTool", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "PutMessageTypeOnCooldown", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "Create", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void TryCreatingMessageWithCooldown(LucyAxeMessage.MessageSource messageSource, Vector2 position, Vector2 velocity, int cooldownTimeInTicks)
		{
			throw null;
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x0002C5D0 File Offset: 0x0002A7D0
		[global::Cpp2ILInjected.Token(Token = "0x60040FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x775494", Offset = "0x775494", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DropSelectedItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseMiningTools_ActuallyUseMiningTool", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "TryPlayingIdleMessage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "ItemSlot_OnItemTransferred", MemberParameters = new object[] { typeof(ItemSlot.ItemTransferInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "TryCreatingMessageWithCooldown", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "GiveIdleMessageCooldown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "SpawnPopupText", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "SpawnEmoteBubble", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void Create(LucyAxeMessage.MessageSource source, Vector2 position, Vector2 velocity)
		{
			throw null;
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x0002C5D3 File Offset: 0x0002A7D3
		[global::Cpp2ILInjected.Token(Token = "0x60040FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x775B24", Offset = "0x775B24", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "Create", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteBubble), Member = "MakeLocalPlayerEmote", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SpawnEmoteBubble()
		{
			throw null;
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x0002C5D6 File Offset: 0x0002A7D6
		[global::Cpp2ILInjected.Token(Token = "0x6004100")]
		[global::Cpp2ILInjected.Address(RVA = "0x775B78", Offset = "0x775B78", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "SpawnPopupText", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CreateFromNet(LucyAxeMessage.MessageSource source, byte variation, Vector2 position, Vector2 velocity)
		{
			throw null;
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x0002C5D9 File Offset: 0x0002A7D9
		[global::Cpp2ILInjected.Token(Token = "0x6004101")]
		[global::Cpp2ILInjected.Address(RVA = "0x775AB0", Offset = "0x775AB0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "Create", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "CreateFromNet", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(byte),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void PlaySound(LucyAxeMessage.MessageSource source, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		[global::Cpp2ILInjected.Token(Token = "0x6004102")]
		[global::Cpp2ILInjected.Address(RVA = "0x775978", Offset = "0x775978", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "Create", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "CreateFromNet", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(byte),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "GetTextForVariation", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(AdvancedPopupRequest),
			typeof(Vector2)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void SpawnPopupText(LucyAxeMessage.MessageSource source, int variationUnwrapped, Vector2 position, Vector2 velocity)
		{
			throw null;
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x0002C5DF File Offset: 0x0002A7DF
		[global::Cpp2ILInjected.Token(Token = "0x6004103")]
		[global::Cpp2ILInjected.Address(RVA = "0x775C18", Offset = "0x775C18", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "SpawnPopupText", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LucyAxeMessage), Member = "GetCategoryName", MemberParameters = new object[] { typeof(LucyAxeMessage.MessageSource) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "IndexedFromCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string GetTextForVariation(LucyAxeMessage.MessageSource source, int variationUnwrapped)
		{
			throw null;
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x0002C5E2 File Offset: 0x0002A7E2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004104")]
		[global::Cpp2ILInjected.Address(RVA = "0x775CC8", Offset = "0x775CC8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static LucyAxeMessage()
		{
			throw null;
		}

		// Token: 0x04006925 RID: 26917
		[global::Cpp2ILInjected.Token(Token = "0x4007EB0")]
		private static byte _variation;

		// Token: 0x04006926 RID: 26918
		[global::Cpp2ILInjected.Token(Token = "0x4007EB1")]
		private static int[] _messageCooldownsByType;

		// Token: 0x02000990 RID: 2448
		[global::Cpp2ILInjected.Token(Token = "0x20007E2")]
		public enum MessageSource
		{
			// Token: 0x04008C41 RID: 35905
			[global::Cpp2ILInjected.Token(Token = "0x4007EB3")]
			Idle,
			// Token: 0x04008C42 RID: 35906
			[global::Cpp2ILInjected.Token(Token = "0x4007EB4")]
			Storage,
			// Token: 0x04008C43 RID: 35907
			[global::Cpp2ILInjected.Token(Token = "0x4007EB5")]
			ThrownAway,
			// Token: 0x04008C44 RID: 35908
			[global::Cpp2ILInjected.Token(Token = "0x4007EB6")]
			PickedUp,
			// Token: 0x04008C45 RID: 35909
			[global::Cpp2ILInjected.Token(Token = "0x4007EB7")]
			ChoppedTree,
			// Token: 0x04008C46 RID: 35910
			[global::Cpp2ILInjected.Token(Token = "0x4007EB8")]
			ChoppedGemTree,
			// Token: 0x04008C47 RID: 35911
			[global::Cpp2ILInjected.Token(Token = "0x4007EB9")]
			ChoppedCactus,
			// Token: 0x04008C48 RID: 35912
			[global::Cpp2ILInjected.Token(Token = "0x4007EBA")]
			Count
		}
	}
}
