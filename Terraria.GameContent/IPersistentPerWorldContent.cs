using System.IO;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200055A")]
public interface IPersistentPerWorldContent
{
	[Cpp2IlInjected.Token(Token = "0x6003A2A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Save(BinaryWriter writer);

	[Cpp2IlInjected.Token(Token = "0x6003A2B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Load(BinaryReader reader, int gameVersionSaveWasMadeOn);

	[Cpp2IlInjected.Token(Token = "0x6003A2C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn);

	[Cpp2IlInjected.Token(Token = "0x6003A2D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Reset();
}
