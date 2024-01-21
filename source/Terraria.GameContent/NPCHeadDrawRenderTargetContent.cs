using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000553")]
public class NPCHeadDrawRenderTargetContent : AnOutlinedDrawRenderTargetContent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40068F9")]
	private Texture2D _theTexture;

	[Cpp2IlInjected.Token(Token = "0x6003A10")]
	[Cpp2IlInjected.Address(RVA = "0x105A980", Offset = "0x105A980", VA = "0x105A980")]
	public void SetTexture(Texture2D texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A11")]
	[Cpp2IlInjected.Address(RVA = "0x105A9B4", Offset = "0x105A9B4", VA = "0x105A9B4", Slot = "8")]
	internal override void DrawTheContent(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A12")]
	[Cpp2IlInjected.Address(RVA = "0x105AB44", Offset = "0x105AB44", VA = "0x105AB44")]
	public NPCHeadDrawRenderTargetContent()
	{
	}
}
