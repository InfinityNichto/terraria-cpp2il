using System.IO;
using Cpp2IlInjected;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000684")]
public class CreativeUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006DC9")]
	public ItemsSacrificedUnlocksTracker ItemSacrifices;

	[Cpp2IlInjected.Token(Token = "0x60041D3")]
	[Cpp2IlInjected.Address(RVA = "0xD71E50", Offset = "0xD71E50", VA = "0xD71E50", Slot = "4")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041D4")]
	[Cpp2IlInjected.Address(RVA = "0xD7200C", Offset = "0xD7200C", VA = "0xD7200C", Slot = "5")]
	public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041D5")]
	[Cpp2IlInjected.Address(RVA = "0xD72210", Offset = "0xD72210", VA = "0xD72210", Slot = "6")]
	public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041D6")]
	[Cpp2IlInjected.Address(RVA = "0xD72214", Offset = "0xD72214", VA = "0xD72214", Slot = "7")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041D7")]
	[Cpp2IlInjected.Address(RVA = "0xD7229C", Offset = "0xD7229C", VA = "0xD7229C", Slot = "8")]
	public void OnPlayerJoining(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041D8")]
	[Cpp2IlInjected.Address(RVA = "0xD722A4", Offset = "0xD722A4", VA = "0xD722A4")]
	public CreativeUnlocksTracker()
	{
	}
}
