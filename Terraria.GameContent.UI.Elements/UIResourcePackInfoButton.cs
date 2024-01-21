using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E3")]
public class UIResourcePackInfoButton<T> : UITextPanel<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007084")]
	private readonly Asset<Texture2D> _BasePanelTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007085")]
	private readonly Asset<Texture2D> _hoveredBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007086")]
	private ResourcePack _resourcePack;

	[Cpp2IlInjected.Token(Token = "0x170007C9")]
	public ResourcePack ResourcePack
	{
		[Cpp2IlInjected.Token(Token = "0x6004508")]
		[Cpp2IlInjected.Address(RVA = "0x1642288", Offset = "0x1642288", VA = "0x1642288")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004509")]
		[Cpp2IlInjected.Address(RVA = "0x1642290", Offset = "0x1642290", VA = "0x1642290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600450A")]
	[Cpp2IlInjected.Address(RVA = "0x1642298", Offset = "0x1642298", VA = "0x1642298")]
	public UIResourcePackInfoButton(T text, float textScale = 1f, bool large = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600450B")]
	[Cpp2IlInjected.Address(RVA = "0x16424BC", Offset = "0x16424BC", VA = "0x16424BC", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
