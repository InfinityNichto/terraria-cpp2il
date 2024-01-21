using System.IO;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200055B")]
public interface IPersistentPerPlayerContent
{
	[Cpp2IlInjected.Token(Token = "0x6003A2E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Save(Player player, BinaryWriter writer);

	[Cpp2IlInjected.Token(Token = "0x6003A2F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn);

	[Cpp2IlInjected.Token(Token = "0x6003A30")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ApplyLoadedDataToOutOfPlayerFields(Player player);

	[Cpp2IlInjected.Token(Token = "0x6003A31")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ResetDataForNewPlayer(Player player);

	[Cpp2IlInjected.Token(Token = "0x6003A32")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Reset();
}
