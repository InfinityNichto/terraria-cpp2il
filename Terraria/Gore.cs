using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000331")]
public class Gore
{
	[Cpp2IlInjected.Token(Token = "0x4002CF7")]
	public static int goreTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002CF8")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002CF9")]
	public Vector2 velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002CFA")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002CFB")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002CFC")]
	public int alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002CFD")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002CFE")]
	public float light;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002CFF")]
	public bool active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4002D00")]
	public bool sticky;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002D01")]
	public int timeLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002D02")]
	public bool behindTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4002D03")]
	public byte frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002D04")]
	public SpriteFrame Frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002D05")]
	public int PlayerOnly;

	[Cpp2IlInjected.Token(Token = "0x17000537")]
	public float Width
	{
		[Cpp2IlInjected.Token(Token = "0x6002643")]
		[Cpp2IlInjected.Address(RVA = "0x1309028", Offset = "0x1309028", VA = "0x1309028")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000538")]
	public float Height
	{
		[Cpp2IlInjected.Token(Token = "0x6002644")]
		[Cpp2IlInjected.Address(RVA = "0x1309148", Offset = "0x1309148", VA = "0x1309148")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000539")]
	public Rectangle AABBRectangle
	{
		[Cpp2IlInjected.Token(Token = "0x6002645")]
		[Cpp2IlInjected.Address(RVA = "0x1309268", Offset = "0x1309268", VA = "0x1309268")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700053A")]
	[Obsolete]
	public byte frame
	{
		[Cpp2IlInjected.Token(Token = "0x6002646")]
		[Cpp2IlInjected.Address(RVA = "0x13093F0", Offset = "0x13093F0", VA = "0x13093F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6002647")]
		[Cpp2IlInjected.Address(RVA = "0x13093F8", Offset = "0x13093F8", VA = "0x13093F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700053B")]
	[Obsolete]
	public byte numFrames
	{
		[Cpp2IlInjected.Token(Token = "0x6002648")]
		[Cpp2IlInjected.Address(RVA = "0x1309400", Offset = "0x1309400", VA = "0x1309400")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6002649")]
		[Cpp2IlInjected.Address(RVA = "0x1309408", Offset = "0x1309408", VA = "0x1309408")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600264A")]
	[Cpp2IlInjected.Address(RVA = "0x1309468", Offset = "0x1309468", VA = "0x1309468")]
	private void UpdateAmbientFloorCloud()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600264B")]
	[Cpp2IlInjected.Address(RVA = "0x1309858", Offset = "0x1309858", VA = "0x1309858")]
	private void UpdateAmbientAirborneCloud()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600264C")]
	[Cpp2IlInjected.Address(RVA = "0x1309B80", Offset = "0x1309B80", VA = "0x1309B80")]
	private void UpdateFogMachineCloud()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600264D")]
	[Cpp2IlInjected.Address(RVA = "0x1309E90", Offset = "0x1309E90", VA = "0x1309E90")]
	private void UpdateLightningBunnySparks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600264E")]
	[Cpp2IlInjected.Address(RVA = "0x130A110", Offset = "0x130A110", VA = "0x130A110")]
	private float ChumFloatingChunk_GetWaterLine(int X, int Y)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600264F")]
	[Cpp2IlInjected.Address(RVA = "0x130A358", Offset = "0x130A358", VA = "0x130A358")]
	private bool DeactivateIfOutsideOfWorld()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002650")]
	[Cpp2IlInjected.Address(RVA = "0x130A498", Offset = "0x130A498", VA = "0x130A498")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002651")]
	[Cpp2IlInjected.Address(RVA = "0x1310970", Offset = "0x1310970", VA = "0x1310970")]
	private void Gore_UpdateLeaf()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002652")]
	[Cpp2IlInjected.Address(RVA = "0x1310118", Offset = "0x1310118", VA = "0x1310118")]
	private void Gore_UpdateSail()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002653")]
	[Cpp2IlInjected.Address(RVA = "0x1311964", Offset = "0x1311964", VA = "0x1311964")]
	public static Gore NewGorePerfect(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002654")]
	[Cpp2IlInjected.Address(RVA = "0x1310020", Offset = "0x1310020", VA = "0x1310020")]
	public static Gore NewGoreDirect(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002655")]
	[Cpp2IlInjected.Address(RVA = "0x130E7A0", Offset = "0x130E7A0", VA = "0x130E7A0")]
	public static int NewGore(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002656")]
	[Cpp2IlInjected.Address(RVA = "0x1311A24", Offset = "0x1311A24", VA = "0x1311A24")]
	public Color GetAlpha(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002657")]
	[Cpp2IlInjected.Address(RVA = "0x1311BD0", Offset = "0x1311BD0", VA = "0x1311BD0")]
	public Gore()
	{
	}
}
