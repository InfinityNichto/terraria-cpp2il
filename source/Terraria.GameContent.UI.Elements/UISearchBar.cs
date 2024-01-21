using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E5")]
public class UISearchBar : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400708F")]
	private readonly LocalizedText _textToShowWhenEmpty;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007090")]
	private UITextBox _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007091")]
	private string actualContents;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007092")]
	private float _textScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007093")]
	private bool isWritingText;

	[Cpp2IlInjected.Token(Token = "0x170007CC")]
	public bool HasContents
	{
		[Cpp2IlInjected.Token(Token = "0x6004522")]
		[Cpp2IlInjected.Address(RVA = "0x148C12C", Offset = "0x148C12C", VA = "0x148C12C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007CD")]
	public bool IsWritingText
	{
		[Cpp2IlInjected.Token(Token = "0x6004523")]
		[Cpp2IlInjected.Address(RVA = "0x14965EC", Offset = "0x14965EC", VA = "0x14965EC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400005A")]
	public event Action<string> OnContentsChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6004518")]
		[Cpp2IlInjected.Address(RVA = "0x148BD48", Offset = "0x148BD48", VA = "0x148BD48")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6004519")]
		[Cpp2IlInjected.Address(RVA = "0x149627C", Offset = "0x149627C", VA = "0x149627C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400005B")]
	public event Action OnStartTakingInput
	{
		[Cpp2IlInjected.Token(Token = "0x600451A")]
		[Cpp2IlInjected.Address(RVA = "0x148BDF8", Offset = "0x148BDF8", VA = "0x148BDF8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600451B")]
		[Cpp2IlInjected.Address(RVA = "0x149632C", Offset = "0x149632C", VA = "0x149632C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400005C")]
	public event Action OnEndTakingInput
	{
		[Cpp2IlInjected.Token(Token = "0x600451C")]
		[Cpp2IlInjected.Address(RVA = "0x148BEA8", Offset = "0x148BEA8", VA = "0x148BEA8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600451D")]
		[Cpp2IlInjected.Address(RVA = "0x14963DC", Offset = "0x14963DC", VA = "0x14963DC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400005D")]
	public event Action OnCanceledTakingInput
	{
		[Cpp2IlInjected.Token(Token = "0x600451E")]
		[Cpp2IlInjected.Address(RVA = "0x148C008", Offset = "0x148C008", VA = "0x148C008")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600451F")]
		[Cpp2IlInjected.Address(RVA = "0x149648C", Offset = "0x149648C", VA = "0x149648C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400005E")]
	public event Action OnNeedingVirtualKeyboard
	{
		[Cpp2IlInjected.Token(Token = "0x6004520")]
		[Cpp2IlInjected.Address(RVA = "0x148BF58", Offset = "0x148BF58", VA = "0x148BF58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6004521")]
		[Cpp2IlInjected.Address(RVA = "0x149653C", Offset = "0x149653C", VA = "0x149653C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004524")]
	[Cpp2IlInjected.Address(RVA = "0x148BB98", Offset = "0x148BB98", VA = "0x148BB98")]
	public UISearchBar(LocalizedText emptyContentText, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004525")]
	[Cpp2IlInjected.Address(RVA = "0x1489760", Offset = "0x1489760", VA = "0x1489760")]
	public void SetContents(string contents, bool forced = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004526")]
	[Cpp2IlInjected.Address(RVA = "0x14965F4", Offset = "0x14965F4", VA = "0x14965F4")]
	public void TrimDisplayIfOverElementDimensions(int padding)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004527")]
	[Cpp2IlInjected.Address(RVA = "0x1496928", Offset = "0x1496928", VA = "0x1496928", Slot = "15")]
	public override void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004528")]
	[Cpp2IlInjected.Address(RVA = "0x1496930", Offset = "0x1496930", VA = "0x1496930", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004529")]
	[Cpp2IlInjected.Address(RVA = "0x1496970", Offset = "0x1496970", VA = "0x1496970", Slot = "9")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600452A")]
	[Cpp2IlInjected.Address(RVA = "0x1496A74", Offset = "0x1496A74", VA = "0x1496A74")]
	private bool NeedsVirtualkeyboard()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600452B")]
	[Cpp2IlInjected.Address(RVA = "0x1496A7C", Offset = "0x1496A7C", VA = "0x1496A7C", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600452C")]
	[Cpp2IlInjected.Address(RVA = "0x148C234", Offset = "0x148C234", VA = "0x148C234")]
	public void ToggleTakingText()
	{
	}
}
