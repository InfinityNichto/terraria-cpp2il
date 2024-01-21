using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000572")]
public class TownRoomManager
{
	[Cpp2IlInjected.Token(Token = "0x4006ABE")]
	public static object EntityCreationLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006ABF")]
	private List<Tuple<int, Point>> _roomLocationPairs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006AC0")]
	private bool[] _hasRoom;

	[Cpp2IlInjected.Token(Token = "0x6003AD9")]
	[Cpp2IlInjected.Address(RVA = "0x128EFF8", Offset = "0x128EFF8", VA = "0x128EFF8")]
	public void AddOccupantsToList(int x, int y, List<int> occupantsList)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ADA")]
	[Cpp2IlInjected.Address(RVA = "0x128F040", Offset = "0x128F040", VA = "0x128F040")]
	public void AddOccupantsToList(Point tilePosition, List<int> occupants)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ADB")]
	[Cpp2IlInjected.Address(RVA = "0x128F1C4", Offset = "0x128F1C4", VA = "0x128F1C4")]
	public bool HasRoomQuick(int npcID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003ADC")]
	[Cpp2IlInjected.Address(RVA = "0x128F1D4", Offset = "0x128F1D4", VA = "0x128F1D4")]
	public bool HasRoom(int npcID, out Point roomPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003ADD")]
	[Cpp2IlInjected.Address(RVA = "0x128F358", Offset = "0x128F358", VA = "0x128F358")]
	public void SetRoom(int npcID, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ADE")]
	[Cpp2IlInjected.Address(RVA = "0x128F3B8", Offset = "0x128F3B8", VA = "0x128F3B8")]
	public void SetRoom(int npcID, Point pt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ADF")]
	[Cpp2IlInjected.Address(RVA = "0x128F580", Offset = "0x128F580", VA = "0x128F580")]
	public void KickOut(NPC n)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE0")]
	[Cpp2IlInjected.Address(RVA = "0x128F5B0", Offset = "0x128F5B0", VA = "0x128F5B0")]
	public void KickOut(int npcType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE1")]
	[Cpp2IlInjected.Address(RVA = "0x128F72C", Offset = "0x128F72C", VA = "0x128F72C")]
	public void DisplayRooms()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE2")]
	[Cpp2IlInjected.Address(RVA = "0x128F8F4", Offset = "0x128F8F4", VA = "0x128F8F4")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE3")]
	[Cpp2IlInjected.Address(RVA = "0x128FB0C", Offset = "0x128FB0C", VA = "0x128FB0C")]
	public void Load(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE4")]
	[Cpp2IlInjected.Address(RVA = "0x128FC3C", Offset = "0x128FC3C", VA = "0x128FC3C")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE5")]
	[Cpp2IlInjected.Address(RVA = "0x128FCCC", Offset = "0x128FCCC", VA = "0x128FCCC")]
	public byte GetHouseholdStatus(NPC n)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE6")]
	[Cpp2IlInjected.Address(RVA = "0x128FCF8", Offset = "0x128FCF8", VA = "0x128FCF8")]
	public bool CanNPCsLiveWithEachOther(int npc1ByType, NPC npc2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE7")]
	[Cpp2IlInjected.Address(RVA = "0x128FDC8", Offset = "0x128FDC8", VA = "0x128FDC8")]
	public bool CanNPCsLiveWithEachOther(NPC npc1, NPC npc2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE8")]
	[Cpp2IlInjected.Address(RVA = "0x128FDDC", Offset = "0x128FDDC", VA = "0x128FDDC")]
	public bool CanNPCsLiveWithEachOther_ShopHelper(NPC npc1, NPC npc2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AE9")]
	[Cpp2IlInjected.Address(RVA = "0x128FDF0", Offset = "0x128FDF0", VA = "0x128FDF0")]
	public TownRoomManager()
	{
	}
}
