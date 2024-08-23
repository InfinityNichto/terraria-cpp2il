using System;
using System.IO;
using Cpp2ILInjected;

namespace Terraria.GameContent
{
	// Token: 0x02000558 RID: 1368
	[global::Cpp2ILInjected.Token(Token = "0x20007D8")]
	public interface IPersistentPerPlayerContent
	{
		// Token: 0x060039F2 RID: 14834
		[global::Cpp2ILInjected.Token(Token = "0x60040D7")]
		void Save(Player player, BinaryWriter writer);

		// Token: 0x060039F3 RID: 14835
		[global::Cpp2ILInjected.Token(Token = "0x60040D8")]
		void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x060039F4 RID: 14836
		[global::Cpp2ILInjected.Token(Token = "0x60040D9")]
		void ApplyLoadedDataToOutOfPlayerFields(Player player);

		// Token: 0x060039F5 RID: 14837
		[global::Cpp2ILInjected.Token(Token = "0x60040DA")]
		void ResetDataForNewPlayer(Player player);

		// Token: 0x060039F6 RID: 14838
		[global::Cpp2ILInjected.Token(Token = "0x60040DB")]
		void Reset();
	}
}
