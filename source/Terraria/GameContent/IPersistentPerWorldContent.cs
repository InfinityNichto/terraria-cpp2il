using System;
using System.IO;
using Cpp2ILInjected;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007D7")]
	public interface IPersistentPerWorldContent
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040D3")]
		void Save(BinaryWriter writer);

		[global::Cpp2ILInjected.Token(Token = "0x60040D4")]
		void Load(BinaryReader reader, int gameVersionSaveWasMadeOn);

		[global::Cpp2ILInjected.Token(Token = "0x60040D5")]
		void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn);

		[global::Cpp2ILInjected.Token(Token = "0x60040D6")]
		void Reset();
	}
}
