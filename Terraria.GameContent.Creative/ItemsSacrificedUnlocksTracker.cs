using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000685")]
public class ItemsSacrificedUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
	[Cpp2IlInjected.Token(Token = "0x4006DCA")]
	public const int POSITIVE_SACRIFICE_COUNT_CAP = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006DCB")]
	private Dictionary<string, int> _sacrificeCountByItemPersistentId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006DCC")]
	public Dictionary<int, int> SacrificesCountByItemIdCache;

	[Cpp2IlInjected.Token(Token = "0x17000799")]
	public int LastEditId
	{
		[Cpp2IlInjected.Token(Token = "0x60041D9")]
		[Cpp2IlInjected.Address(RVA = "0xD7652C", Offset = "0xD7652C", VA = "0xD7652C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60041DA")]
		[Cpp2IlInjected.Address(RVA = "0xD76534", Offset = "0xD76534", VA = "0xD76534")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60041DB")]
	[Cpp2IlInjected.Address(RVA = "0xD72314", Offset = "0xD72314", VA = "0xD72314")]
	public ItemsSacrificedUnlocksTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041DC")]
	[Cpp2IlInjected.Address(RVA = "0xD7653C", Offset = "0xD7653C", VA = "0xD7653C")]
	public int GetSacrificeCount(int itemId)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60041DD")]
	[Cpp2IlInjected.Address(RVA = "0xD76610", Offset = "0xD76610", VA = "0xD76610")]
	public void FillListOfItemsThatCanBeObtainedInfinitely(List<int> toObtainInfinitely)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041DE")]
	[Cpp2IlInjected.Address(RVA = "0xD76798", Offset = "0xD76798", VA = "0xD76798")]
	public bool TryGetSacrificeNumbers(int itemId, out int amountWeHave, out int amountNeededTotal)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60041DF")]
	[Cpp2IlInjected.Address(RVA = "0xD768D4", Offset = "0xD768D4", VA = "0xD768D4")]
	public void RegisterItemSacrifice(int itemId, int amount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041E0")]
	[Cpp2IlInjected.Address(RVA = "0xD76AC4", Offset = "0xD76AC4", VA = "0xD76AC4")]
	public void SetSacrificeCountDirectly(string persistentId, int sacrificeCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041E1")]
	[Cpp2IlInjected.Address(RVA = "0xD71E58", Offset = "0xD71E58", VA = "0xD71E58", Slot = "4")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041E2")]
	[Cpp2IlInjected.Address(RVA = "0xD72014", Offset = "0xD72014", VA = "0xD72014", Slot = "5")]
	public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041E3")]
	[Cpp2IlInjected.Address(RVA = "0xD76C18", Offset = "0xD76C18", VA = "0xD76C18", Slot = "6")]
	public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041E4")]
	[Cpp2IlInjected.Address(RVA = "0xD7221C", Offset = "0xD7221C", VA = "0xD7221C", Slot = "7")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041E5")]
	[Cpp2IlInjected.Address(RVA = "0xD722A0", Offset = "0xD722A0", VA = "0xD722A0", Slot = "8")]
	public void OnPlayerJoining(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041E6")]
	[Cpp2IlInjected.Address(RVA = "0xD76AB4", Offset = "0xD76AB4", VA = "0xD76AB4")]
	public void MarkContentsDirty()
	{
	}
}
