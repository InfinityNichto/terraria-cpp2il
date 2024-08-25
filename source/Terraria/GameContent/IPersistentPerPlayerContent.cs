using System;
using System.IO;
using Cpp2ILInjected;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007D8")]
	public interface IPersistentPerPlayerContent
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040D7")]
		void Save(Player player, BinaryWriter writer);

		[global::Cpp2ILInjected.Token(Token = "0x60040D8")]
		void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn);

		[global::Cpp2ILInjected.Token(Token = "0x60040D9")]
		void ApplyLoadedDataToOutOfPlayerFields(Player player);

		[global::Cpp2ILInjected.Token(Token = "0x60040DA")]
		void ResetDataForNewPlayer(Player player);

		[global::Cpp2ILInjected.Token(Token = "0x60040DB")]
		void Reset();
	}
}
