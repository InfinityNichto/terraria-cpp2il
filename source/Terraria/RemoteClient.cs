using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000323")]
public class RemoteClient
{
	[Cpp2IlInjected.Token(Token = "0x4002C5C")]
	private static List<Point> _pendingSectionFraming;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002C5D")]
	public int Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002C5E")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002C5F")]
	public bool LocalHost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4002C60")]
	public bool Connected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4002C61")]
	public bool IsActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4002C62")]
	public bool PendingTermination;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002C63")]
	public bool IsAnnouncementCompleted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002C64")]
	public int State;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002C65")]
	public int TimeOutTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002C66")]
	public string StatusText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002C67")]
	public string StatusText2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002C68")]
	public int StatusCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002C69")]
	public int StatusMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002C6A")]
	public bool[,] TileSections;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002C6B")]
	public float SpamProjectile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002C6C")]
	public float SpamAddBlock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002C6D")]
	public float SpamDeleteBlock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002C6E")]
	public float SpamWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002C6F")]
	public float SpamProjectileMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4002C70")]
	public float SpamAddBlockMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4002C71")]
	public float SpamDeleteBlockMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4002C72")]
	public float SpamWaterMax;

	[Cpp2IlInjected.Token(Token = "0x17000527")]
	public bool HasAnySection
	{
		[Cpp2IlInjected.Token(Token = "0x6002577")]
		[Cpp2IlInjected.Address(RVA = "0x14DAF60", Offset = "0x14DAF60", VA = "0x14DAF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002578")]
	[Cpp2IlInjected.Address(RVA = "0x14DB058", Offset = "0x14DB058", VA = "0x14DB058")]
	public void SpamUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002579")]
	[Cpp2IlInjected.Address(RVA = "0x14DB670", Offset = "0x14DB670", VA = "0x14DB670")]
	public void SpamClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600257A")]
	[Cpp2IlInjected.Address(RVA = "0x14DB680", Offset = "0x14DB680", VA = "0x14DB680")]
	public static void CheckSection(int playerIndex, Vector2 position, int fluff = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600257B")]
	[Cpp2IlInjected.Address(RVA = "0x14DBADC", Offset = "0x14DBADC", VA = "0x14DBADC")]
	public bool SectionRange(int size, int firstX, int firstY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600257C")]
	[Cpp2IlInjected.Address(RVA = "0x14DBC00", Offset = "0x14DBC00", VA = "0x14DBC00")]
	public void ResetSections()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600257D")]
	[Cpp2IlInjected.Address(RVA = "0x14DBCEC", Offset = "0x14DBCEC", VA = "0x14DBCEC")]
	public void Reset(bool setupActive = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600257E")]
	[Cpp2IlInjected.Address(RVA = "0x14DBEA0", Offset = "0x14DBEA0", VA = "0x14DBEA0")]
	public void ServerWriteCallBack(object state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600257F")]
	[Cpp2IlInjected.Address(RVA = "0x14DBF48", Offset = "0x14DBF48", VA = "0x14DBF48")]
	public RemoteClient()
	{
	}
}
