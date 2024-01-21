using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200047D")]
public class TileEntitiesManager
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006479")]
	private int _nextEntityID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400647A")]
	private Dictionary<int, TileEntity> _types;

	[Cpp2IlInjected.Token(Token = "0x600325E")]
	[Cpp2IlInjected.Address(RVA = "0x122F7A4", Offset = "0x122F7A4", VA = "0x122F7A4")]
	private int AssignNewID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600325F")]
	[Cpp2IlInjected.Address(RVA = "0x122F7B8", Offset = "0x122F7B8", VA = "0x122F7B8")]
	private bool InvalidEntityID(int id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003260")]
	[Cpp2IlInjected.Address(RVA = "0x122F7D8", Offset = "0x122F7D8", VA = "0x122F7D8")]
	public void RegisterAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003261")]
	[Cpp2IlInjected.Address(RVA = "0x122F97C", Offset = "0x122F97C", VA = "0x122F97C")]
	public void Register(TileEntity entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003262")]
	[Cpp2IlInjected.Address(RVA = "0x122FA08", Offset = "0x122FA08", VA = "0x122FA08")]
	public bool CheckValidTile(int id, int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003263")]
	[Cpp2IlInjected.Address(RVA = "0x122FAA4", Offset = "0x122FAA4", VA = "0x122FAA4")]
	public void NetPlaceEntity(int id, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003264")]
	[Cpp2IlInjected.Address(RVA = "0x122FB6C", Offset = "0x122FB6C", VA = "0x122FB6C")]
	public TileEntity GenerateInstance(int id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003265")]
	[Cpp2IlInjected.Address(RVA = "0x122FBF8", Offset = "0x122FBF8", VA = "0x122FBF8")]
	public TileEntitiesManager()
	{
	}
}
