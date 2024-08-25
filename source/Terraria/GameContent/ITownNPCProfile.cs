using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007FB")]
	public interface ITownNPCProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004190")]
		int RollVariation();

		[global::Cpp2ILInjected.Token(Token = "0x6004191")]
		string GetNameForVariant(NPC npc);

		[global::Cpp2ILInjected.Token(Token = "0x6004192")]
		Asset<Texture2D> GetTextureNPCShouldUse(NPC npc);

		[global::Cpp2ILInjected.Token(Token = "0x6004193")]
		int GetHeadTextureIndex(NPC npc);
	}
}
