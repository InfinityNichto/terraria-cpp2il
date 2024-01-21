using System.IO;
using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200061C")]
public class BestiaryUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C3E")]
	public NPCKillsTracker Kills;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C3F")]
	public NPCWasNearPlayerTracker Sights;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C40")]
	public NPCWasChatWithTracker Chats;

	[Cpp2IlInjected.Token(Token = "0x6003E8F")]
	[Cpp2IlInjected.Address(RVA = "0x10F8C54", Offset = "0x10F8C54", VA = "0x10F8C54", Slot = "4")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E90")]
	[Cpp2IlInjected.Address(RVA = "0x10F91C4", Offset = "0x10F91C4", VA = "0x10F91C4", Slot = "5")]
	public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E91")]
	[Cpp2IlInjected.Address(RVA = "0x10F93F4", Offset = "0x10F93F4", VA = "0x10F93F4", Slot = "6")]
	public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E92")]
	[Cpp2IlInjected.Address(RVA = "0x10F9578", Offset = "0x10F9578", VA = "0x10F9578", Slot = "7")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E93")]
	[Cpp2IlInjected.Address(RVA = "0x10F96E4", Offset = "0x10F96E4", VA = "0x10F96E4", Slot = "8")]
	public void OnPlayerJoining(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E94")]
	[Cpp2IlInjected.Address(RVA = "0x10F9D10", Offset = "0x10F9D10", VA = "0x10F9D10")]
	public void FillBasedOnVersionBefore210()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E95")]
	[Cpp2IlInjected.Address(RVA = "0x10F9D14", Offset = "0x10F9D14", VA = "0x10F9D14")]
	public BestiaryUnlocksTracker()
	{
	}
}
