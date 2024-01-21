using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x2000582")]
public class TETrainingDummy : TileEntity
{
	[Cpp2IlInjected.Token(Token = "0x4006B02")]
	private static Dictionary<int, Rectangle> playerBox;

	[Cpp2IlInjected.Token(Token = "0x4006B03")]
	private static bool playerBoxFilled;

	[Cpp2IlInjected.Token(Token = "0x4006B04")]
	private static byte _myEntityID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006B05")]
	public int npc;

	[Cpp2IlInjected.Token(Token = "0x6003B9E")]
	[Cpp2IlInjected.Address(RVA = "0x1289BFC", Offset = "0x1289BFC", VA = "0x1289BFC", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B9F")]
	[Cpp2IlInjected.Address(RVA = "0x1289CE8", Offset = "0x1289CE8", VA = "0x1289CE8", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA0")]
	[Cpp2IlInjected.Address(RVA = "0x1289D68", Offset = "0x1289D68", VA = "0x1289D68")]
	public static void NetPlaceEntity(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA1")]
	[Cpp2IlInjected.Address(RVA = "0x1289FD8", Offset = "0x1289FD8", VA = "0x1289FD8", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA2")]
	[Cpp2IlInjected.Address(RVA = "0x128A0BC", Offset = "0x128A0BC", VA = "0x128A0BC", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA3")]
	[Cpp2IlInjected.Address(RVA = "0x128A31C", Offset = "0x128A31C", VA = "0x128A31C")]
	public static void ClearBoxes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA4")]
	[Cpp2IlInjected.Address(RVA = "0x128A3B8", Offset = "0x128A3B8", VA = "0x128A3B8", Slot = "4")]
	public override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA5")]
	[Cpp2IlInjected.Address(RVA = "0x128A8B4", Offset = "0x128A8B4", VA = "0x128A8B4")]
	private static void FillPlayerHitboxes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA6")]
	[Cpp2IlInjected.Address(RVA = "0x128A13C", Offset = "0x128A13C", VA = "0x128A13C")]
	public static bool ValidTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA7")]
	[Cpp2IlInjected.Address(RVA = "0x128A038", Offset = "0x128A038", VA = "0x128A038")]
	public TETrainingDummy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA8")]
	[Cpp2IlInjected.Address(RVA = "0x1289DE8", Offset = "0x1289DE8", VA = "0x1289DE8")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BA9")]
	[Cpp2IlInjected.Address(RVA = "0x128AD08", Offset = "0x128AD08", VA = "0x128AD08")]
	public static int Hook_AfterPlacement(int x, int y, int type = 378, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BAA")]
	[Cpp2IlInjected.Address(RVA = "0x128AF94", Offset = "0x128AF94", VA = "0x128AF94")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BAB")]
	[Cpp2IlInjected.Address(RVA = "0x128B1B4", Offset = "0x128B1B4", VA = "0x128B1B4")]
	public static int Find(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BAC")]
	[Cpp2IlInjected.Address(RVA = "0x128B2D0", Offset = "0x128B2D0", VA = "0x128B2D0", Slot = "5")]
	public override void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BAD")]
	[Cpp2IlInjected.Address(RVA = "0x128B2EC", Offset = "0x128B2EC", VA = "0x128B2EC", Slot = "6")]
	public override void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BAE")]
	[Cpp2IlInjected.Address(RVA = "0x128AAEC", Offset = "0x128AAEC", VA = "0x128AAEC")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BAF")]
	[Cpp2IlInjected.Address(RVA = "0x128A754", Offset = "0x128A754", VA = "0x128A754")]
	public void Deactivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB0")]
	[Cpp2IlInjected.Address(RVA = "0x128B318", Offset = "0x128B318", VA = "0x128B318", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
