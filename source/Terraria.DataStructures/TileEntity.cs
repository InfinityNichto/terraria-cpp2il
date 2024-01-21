using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200047E")]
public abstract class TileEntity
{
	[Cpp2IlInjected.Token(Token = "0x400647B")]
	public static TileEntitiesManager manager;

	[Cpp2IlInjected.Token(Token = "0x400647C")]
	public const int MaxEntitiesPerChunk = 1000;

	[Cpp2IlInjected.Token(Token = "0x400647D")]
	public static object EntityCreationLock;

	[Cpp2IlInjected.Token(Token = "0x400647E")]
	public static Dictionary<int, TileEntity> ByID;

	[Cpp2IlInjected.Token(Token = "0x400647F")]
	public static Dictionary<int, TileEntity> ByPosition;

	[Cpp2IlInjected.Token(Token = "0x4006480")]
	public static int TileEntitiesNextID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006483")]
	public int ID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006484")]
	public Point16 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006485")]
	public byte type;

	[Cpp2IlInjected.Token(Token = "0x1700062C")]
	public int PositionKey
	{
		[Cpp2IlInjected.Token(Token = "0x6003271")]
		[Cpp2IlInjected.Address(RVA = "0x1230518", Offset = "0x1230518", VA = "0x1230518")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public static event Action _UpdateStart
	{
		[Cpp2IlInjected.Token(Token = "0x6003267")]
		[Cpp2IlInjected.Address(RVA = "0x122FCFC", Offset = "0x122FCFC", VA = "0x122FCFC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003268")]
		[Cpp2IlInjected.Address(RVA = "0x122FE04", Offset = "0x122FE04", VA = "0x122FE04")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public static event Action _UpdateEnd
	{
		[Cpp2IlInjected.Token(Token = "0x6003269")]
		[Cpp2IlInjected.Address(RVA = "0x122FF0C", Offset = "0x122FF0C", VA = "0x122FF0C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600326A")]
		[Cpp2IlInjected.Address(RVA = "0x1230014", Offset = "0x1230014", VA = "0x1230014")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003266")]
	[Cpp2IlInjected.Address(RVA = "0x122FC7C", Offset = "0x122FC7C", VA = "0x122FC7C")]
	public static int AssignNewID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600326B")]
	[Cpp2IlInjected.Address(RVA = "0x123011C", Offset = "0x123011C", VA = "0x123011C")]
	public static void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600326C")]
	[Cpp2IlInjected.Address(RVA = "0x12301CC", Offset = "0x12301CC", VA = "0x12301CC")]
	public static void UpdateStart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600326D")]
	[Cpp2IlInjected.Address(RVA = "0x1230284", Offset = "0x1230284", VA = "0x1230284")]
	public static void UpdateEnd()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600326E")]
	[Cpp2IlInjected.Address(RVA = "0x123033C", Offset = "0x123033C", VA = "0x123033C")]
	public static void InitializeAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600326F")]
	[Cpp2IlInjected.Address(RVA = "0x12303E0", Offset = "0x12303E0", VA = "0x12303E0")]
	public static int GetKey(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003270")]
	[Cpp2IlInjected.Address(RVA = "0x12303E8", Offset = "0x12303E8", VA = "0x12303E8")]
	public static void PlaceEntityNet(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003272")]
	[Cpp2IlInjected.Address(RVA = "0x1230594", Offset = "0x1230594", VA = "0x1230594", Slot = "4")]
	public virtual void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003273")]
	[Cpp2IlInjected.Address(RVA = "0x1230598", Offset = "0x1230598", VA = "0x1230598")]
	public static void Write(BinaryWriter writer, TileEntity ent, bool networkSend = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003274")]
	[Cpp2IlInjected.Address(RVA = "0x123065C", Offset = "0x123065C", VA = "0x123065C")]
	public static TileEntity Read(BinaryReader reader, bool networkSend = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003275")]
	[Cpp2IlInjected.Address(RVA = "0x123079C", Offset = "0x123079C", VA = "0x123079C")]
	public static TileEntity ReadPos32(BinaryReader reader, bool networkSend = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003276")]
	[Cpp2IlInjected.Address(RVA = "0x12305D8", Offset = "0x12305D8", VA = "0x12305D8")]
	private void WriteInner(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003277")]
	[Cpp2IlInjected.Address(RVA = "0x1230714", Offset = "0x1230714", VA = "0x1230714")]
	private void ReadInner(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003278")]
	[Cpp2IlInjected.Address(RVA = "0x1230854", Offset = "0x1230854", VA = "0x1230854")]
	private void ReadInnerPos32(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003279")]
	[Cpp2IlInjected.Address(RVA = "0x12308DC", Offset = "0x12308DC", VA = "0x12308DC", Slot = "5")]
	public virtual void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600327A")]
	[Cpp2IlInjected.Address(RVA = "0x12308E0", Offset = "0x12308E0", VA = "0x12308E0", Slot = "6")]
	public virtual void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600327B")]
	[Cpp2IlInjected.Address(RVA = "0x12308E4", Offset = "0x12308E4", VA = "0x12308E4", Slot = "7")]
	public virtual void OnPlayerUpdate(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600327C")]
	[Cpp2IlInjected.Address(RVA = "0x12308E8", Offset = "0x12308E8", VA = "0x12308E8")]
	public static bool IsOccupied(int id, out int interactingPlayer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600327D")]
	[Cpp2IlInjected.Address(RVA = "0x12309C4", Offset = "0x12309C4", VA = "0x12309C4", Slot = "8")]
	public virtual void OnInventoryDraw(Player player, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600327E")]
	[Cpp2IlInjected.Address(RVA = "0x12309C8", Offset = "0x12309C8", VA = "0x12309C8", Slot = "9")]
	public virtual string GetItemGamepadInstructions(int slot = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600327F")]
	[Cpp2IlInjected.Address(RVA = "0x1230A18", Offset = "0x1230A18", VA = "0x1230A18", Slot = "10")]
	public virtual bool TryGetItemGamepadOverrideInstructions(Item[] inv, int context, int slot, out string instruction)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003280")]
	[Cpp2IlInjected.Address(RVA = "0x1230A2C", Offset = "0x1230A2C", VA = "0x1230A2C", Slot = "11")]
	public virtual bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003281")]
	[Cpp2IlInjected.Address(RVA = "0x1230A34", Offset = "0x1230A34", VA = "0x1230A34", Slot = "12")]
	public virtual bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003282")]
	[Cpp2IlInjected.Address(RVA = "0x1230A3C", Offset = "0x1230A3C", VA = "0x1230A3C")]
	public static void BasicOpenCloseInteraction(Player player, int x, int y, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003283")]
	[Cpp2IlInjected.Address(RVA = "0x1230E60", Offset = "0x1230E60", VA = "0x1230E60")]
	public static void SetInteractionAnchor(Player player, int x, int y, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003284")]
	[Cpp2IlInjected.Address(RVA = "0x1231014", Offset = "0x1231014", VA = "0x1231014", Slot = "13")]
	public virtual void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003285")]
	[Cpp2IlInjected.Address(RVA = "0x1231018", Offset = "0x1231018", VA = "0x1231018", Slot = "14")]
	public virtual void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003286")]
	[Cpp2IlInjected.Address(RVA = "0x123101C", Offset = "0x123101C", VA = "0x123101C", Slot = "15")]
	public virtual bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003287")]
	[Cpp2IlInjected.Address(RVA = "0x1231024", Offset = "0x1231024", VA = "0x1231024", Slot = "16")]
	public virtual TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003288")]
	[Cpp2IlInjected.Address(RVA = "0x123102C", Offset = "0x123102C", VA = "0x123102C")]
	protected TileEntity()
	{
	}
}
