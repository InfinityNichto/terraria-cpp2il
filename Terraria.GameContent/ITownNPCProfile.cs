using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000570")]
public interface ITownNPCProfile
{
	[Cpp2IlInjected.Token(Token = "0x6003AD4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int RollVariation();

	[Cpp2IlInjected.Token(Token = "0x6003AD5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GetNameForVariant(NPC npc);

	[Cpp2IlInjected.Token(Token = "0x6003AD6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Asset<Texture2D> GetTextureNPCShouldUse(NPC npc);

	[Cpp2IlInjected.Token(Token = "0x6003AD7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GetHeadTextureIndex(NPC npc);
}
