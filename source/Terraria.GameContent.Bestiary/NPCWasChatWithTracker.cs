using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200061F")]
public class NPCWasChatWithTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C48")]
	private object _entryCreationLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C49")]
	private HashSet<string> _chattedWithPlayer;

	[Cpp2IlInjected.Token(Token = "0x6003EAC")]
	[Cpp2IlInjected.Address(RVA = "0x10F9F7C", Offset = "0x10F9F7C", VA = "0x10F9F7C")]
	public NPCWasChatWithTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EAD")]
	[Cpp2IlInjected.Address(RVA = "0x1101F90", Offset = "0x1101F90", VA = "0x1101F90")]
	public void RegisterChatStartWith(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EAE")]
	[Cpp2IlInjected.Address(RVA = "0x110213C", Offset = "0x110213C", VA = "0x110213C")]
	public void SetWasChatWithDirectly(string persistentId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EAF")]
	[Cpp2IlInjected.Address(RVA = "0x1102210", Offset = "0x1102210", VA = "0x1102210")]
	public bool GetWasChatWith(NPC npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB0")]
	[Cpp2IlInjected.Address(RVA = "0x1102280", Offset = "0x1102280", VA = "0x1102280")]
	public bool GetWasChatWith(string persistentId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB1")]
	[Cpp2IlInjected.Address(RVA = "0x10F9020", Offset = "0x10F9020", VA = "0x10F9020", Slot = "4")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB2")]
	[Cpp2IlInjected.Address(RVA = "0x10F9354", Offset = "0x10F9354", VA = "0x10F9354", Slot = "5")]
	public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB3")]
	[Cpp2IlInjected.Address(RVA = "0x10F952C", Offset = "0x10F952C", VA = "0x10F952C", Slot = "6")]
	public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB4")]
	[Cpp2IlInjected.Address(RVA = "0x10F9688", Offset = "0x10F9688", VA = "0x10F9688", Slot = "7")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB5")]
	[Cpp2IlInjected.Address(RVA = "0x10F9B1C", Offset = "0x10F9B1C", VA = "0x10F9B1C", Slot = "8")]
	public void OnPlayerJoining(int playerIndex)
	{
	}
}
