using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E6")]
public class UISelectableTextPanel<T> : UITextPanel<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007099")]
	private readonly Asset<Texture2D> _BasePanelTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400709A")]
	private readonly Asset<Texture2D> _hoveredBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400709B")]
	private Func<UISelectableTextPanel<T>, bool> _isSelected;

	[Cpp2IlInjected.Token(Token = "0x170007CE")]
	public Func<UISelectableTextPanel<T>, bool> IsSelected
	{
		[Cpp2IlInjected.Token(Token = "0x600452D")]
		[Cpp2IlInjected.Address(RVA = "0x1642724", Offset = "0x1642724", VA = "0x1642724")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600452E")]
		[Cpp2IlInjected.Address(RVA = "0x164272C", Offset = "0x164272C", VA = "0x164272C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600452F")]
	[Cpp2IlInjected.Address(RVA = "0x1642734", Offset = "0x1642734", VA = "0x1642734")]
	public UISelectableTextPanel(T text, float textScale = 1f, bool large = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004530")]
	[Cpp2IlInjected.Address(RVA = "0x1642958", Offset = "0x1642958", VA = "0x1642958", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
