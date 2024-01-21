using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200061D")]
public class NPCKillsTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C41")]
	private object _entryCreationLock;

	[Cpp2IlInjected.Token(Token = "0x4006C42")]
	public const int POSITIVE_KILL_COUNT_CAP = 999999999;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C43")]
	private Dictionary<string, int> _killCountsByNpcId;

	[Cpp2IlInjected.Token(Token = "0x6003E96")]
	[Cpp2IlInjected.Address(RVA = "0x10F9DC4", Offset = "0x10F9DC4", VA = "0x10F9DC4")]
	public NPCKillsTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E97")]
	[Cpp2IlInjected.Address(RVA = "0x10FE344", Offset = "0x10FE344", VA = "0x10FE344")]
	public void RegisterKill(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E98")]
	[Cpp2IlInjected.Address(RVA = "0x10FE31C", Offset = "0x10FE31C", VA = "0x10FE31C")]
	public int GetKillCount(NPC npc)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E99")]
	[Cpp2IlInjected.Address(RVA = "0x10FE560", Offset = "0x10FE560", VA = "0x10FE560")]
	public void SetKillCountDirectly(string persistentId, int killCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E9A")]
	[Cpp2IlInjected.Address(RVA = "0x10FA374", Offset = "0x10FA374", VA = "0x10FA374")]
	public int GetKillCount(string persistentId)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E9B")]
	[Cpp2IlInjected.Address(RVA = "0x10F8C88", Offset = "0x10F8C88", VA = "0x10F8C88", Slot = "4")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E9C")]
	[Cpp2IlInjected.Address(RVA = "0x10F91F8", Offset = "0x10F91F8", VA = "0x10F91F8", Slot = "5")]
	public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E9D")]
	[Cpp2IlInjected.Address(RVA = "0x10F9480", Offset = "0x10F9480", VA = "0x10F9480", Slot = "6")]
	public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E9E")]
	[Cpp2IlInjected.Address(RVA = "0x10F95A0", Offset = "0x10F95A0", VA = "0x10F95A0", Slot = "7")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E9F")]
	[Cpp2IlInjected.Address(RVA = "0x10F9718", Offset = "0x10F9718", VA = "0x10F9718", Slot = "8")]
	public void OnPlayerJoining(int playerIndex)
	{
	}
}
