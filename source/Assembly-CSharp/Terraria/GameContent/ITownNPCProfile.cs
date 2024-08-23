using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x0200056D RID: 1389
	[global::Cpp2ILInjected.Token(Token = "0x20007FB")]
	public interface ITownNPCProfile
	{
		// Token: 0x06003A98 RID: 15000
		[global::Cpp2ILInjected.Token(Token = "0x6004190")]
		int RollVariation();

		// Token: 0x06003A99 RID: 15001
		[global::Cpp2ILInjected.Token(Token = "0x6004191")]
		string GetNameForVariant(NPC npc);

		// Token: 0x06003A9A RID: 15002
		[global::Cpp2ILInjected.Token(Token = "0x6004192")]
		Asset<Texture2D> GetTextureNPCShouldUse(NPC npc);

		// Token: 0x06003A9B RID: 15003
		[global::Cpp2ILInjected.Token(Token = "0x6004193")]
		int GetHeadTextureIndex(NPC npc);
	}
}
