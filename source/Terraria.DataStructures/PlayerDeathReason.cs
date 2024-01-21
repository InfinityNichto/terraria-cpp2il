using System.IO;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000444")]
public class PlayerDeathReason
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400631E")]
	private int _sourcePlayerIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400631F")]
	private int _sourceNPCIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006320")]
	private int _sourceProjectileLocalIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006321")]
	private int _sourceOtherIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006322")]
	private int _sourceProjectileType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006323")]
	private int _sourceItemType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006324")]
	private int _sourceItemPrefix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006325")]
	private string _sourceCustomReason;

	[Cpp2IlInjected.Token(Token = "0x17000621")]
	public int? SourceProjectileType
	{
		[Cpp2IlInjected.Token(Token = "0x600316E")]
		[Cpp2IlInjected.Address(RVA = "0x1015404", Offset = "0x1015404", VA = "0x1015404")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600316F")]
	[Cpp2IlInjected.Address(RVA = "0x1015490", Offset = "0x1015490", VA = "0x1015490")]
	public bool TryGetCausingEntity(out Entity entity)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003170")]
	[Cpp2IlInjected.Address(RVA = "0x1015710", Offset = "0x1015710", VA = "0x1015710")]
	public static PlayerDeathReason LegacyEmpty()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003171")]
	[Cpp2IlInjected.Address(RVA = "0x10157B0", Offset = "0x10157B0", VA = "0x10157B0")]
	public static PlayerDeathReason LegacyDefault()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003172")]
	[Cpp2IlInjected.Address(RVA = "0x1015834", Offset = "0x1015834", VA = "0x1015834")]
	public static PlayerDeathReason ByNPC(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003173")]
	[Cpp2IlInjected.Address(RVA = "0x10158B8", Offset = "0x10158B8", VA = "0x10158B8")]
	public static PlayerDeathReason ByCustomReason(string reasonInEnglish)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003174")]
	[Cpp2IlInjected.Address(RVA = "0x101593C", Offset = "0x101593C", VA = "0x101593C")]
	public static PlayerDeathReason ByPlayer(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003175")]
	[Cpp2IlInjected.Address(RVA = "0x1015A40", Offset = "0x1015A40", VA = "0x1015A40")]
	public static PlayerDeathReason ByOther(int type)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003176")]
	[Cpp2IlInjected.Address(RVA = "0x1015AC4", Offset = "0x1015AC4", VA = "0x1015AC4")]
	public static PlayerDeathReason ByProjectile(int playerIndex, int projectileIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003177")]
	[Cpp2IlInjected.Address(RVA = "0x1015C18", Offset = "0x1015C18", VA = "0x1015C18")]
	public NetworkText GetDeathText(string deadPlayerName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003178")]
	[Cpp2IlInjected.Address(RVA = "0x1015D18", Offset = "0x1015D18", VA = "0x1015D18")]
	public void WriteSelfTo(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003179")]
	[Cpp2IlInjected.Address(RVA = "0x1015FD0", Offset = "0x1015FD0", VA = "0x1015FD0")]
	public static PlayerDeathReason FromReader(BinaryReader reader)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600317A")]
	[Cpp2IlInjected.Address(RVA = "0x1015794", Offset = "0x1015794", VA = "0x1015794")]
	public PlayerDeathReason()
	{
	}
}
