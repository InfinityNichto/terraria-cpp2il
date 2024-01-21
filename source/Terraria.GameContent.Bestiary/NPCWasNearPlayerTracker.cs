using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200061E")]
public class NPCWasNearPlayerTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C44")]
	private object _entryCreationLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C45")]
	private HashSet<string> _wasNearPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C46")]
	private List<Rectangle> _playerHitboxesForBestiary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006C47")]
	private List<int> _wasSeenNearPlayerByNetId;

	[Cpp2IlInjected.Token(Token = "0x6003EA0")]
	[Cpp2IlInjected.Address(RVA = "0x11022E4", Offset = "0x11022E4", VA = "0x11022E4")]
	public void PrepareSamplesBasedOptimizations()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA1")]
	[Cpp2IlInjected.Address(RVA = "0x10F9E6C", Offset = "0x10F9E6C", VA = "0x10F9E6C")]
	public NPCWasNearPlayerTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA2")]
	[Cpp2IlInjected.Address(RVA = "0x11022E8", Offset = "0x11022E8", VA = "0x11022E8")]
	public void RegisterWasNearby(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA3")]
	[Cpp2IlInjected.Address(RVA = "0x1102494", Offset = "0x1102494", VA = "0x1102494")]
	public void SetWasSeenDirectly(string persistentId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA4")]
	[Cpp2IlInjected.Address(RVA = "0x1102568", Offset = "0x1102568", VA = "0x1102568")]
	public bool GetWasNearbyBefore(NPC npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA5")]
	[Cpp2IlInjected.Address(RVA = "0x10FA58C", Offset = "0x10FA58C", VA = "0x10FA58C")]
	public bool GetWasNearbyBefore(string persistentIdentifier)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA6")]
	[Cpp2IlInjected.Address(RVA = "0x10F8E7C", Offset = "0x10F8E7C", VA = "0x10F8E7C", Slot = "4")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA7")]
	[Cpp2IlInjected.Address(RVA = "0x10F92B4", Offset = "0x10F92B4", VA = "0x10F92B4", Slot = "5")]
	public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA8")]
	[Cpp2IlInjected.Address(RVA = "0x10F94E0", Offset = "0x10F94E0", VA = "0x10F94E0", Slot = "6")]
	public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EA9")]
	[Cpp2IlInjected.Address(RVA = "0x10F95FC", Offset = "0x10F95FC", VA = "0x10F95FC", Slot = "7")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EAA")]
	[Cpp2IlInjected.Address(RVA = "0x1102590", Offset = "0x1102590", VA = "0x1102590")]
	public void ScanWorldForFinds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EAB")]
	[Cpp2IlInjected.Address(RVA = "0x10F9928", Offset = "0x10F9928", VA = "0x10F9928", Slot = "8")]
	public void OnPlayerJoining(int playerIndex)
	{
	}
}
