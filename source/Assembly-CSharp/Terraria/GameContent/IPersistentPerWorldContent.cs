using System;
using System.IO;
using Cpp2ILInjected;

namespace Terraria.GameContent
{
	// Token: 0x02000557 RID: 1367
	[global::Cpp2ILInjected.Token(Token = "0x20007D7")]
	public interface IPersistentPerWorldContent
	{
		// Token: 0x060039EE RID: 14830
		[global::Cpp2ILInjected.Token(Token = "0x60040D3")]
		void Save(BinaryWriter writer);

		// Token: 0x060039EF RID: 14831
		[global::Cpp2ILInjected.Token(Token = "0x60040D4")]
		void Load(BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x060039F0 RID: 14832
		[global::Cpp2ILInjected.Token(Token = "0x60040D5")]
		void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x060039F1 RID: 14833
		[global::Cpp2ILInjected.Token(Token = "0x60040D6")]
		void Reset();
	}
}
