using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E2")]
public class UIProgressBar : UIElement
{
	[Cpp2IlInjected.Token(Token = "0x2000ABB")]
	private class UIInnerProgressBar : UIElement
	{
		[Cpp2IlInjected.Token(Token = "0x60052C4")]
		[Cpp2IlInjected.Address(RVA = "0x14957B4", Offset = "0x14957B4", VA = "0x14957B4", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052C5")]
		[Cpp2IlInjected.Address(RVA = "0x14956DC", Offset = "0x14956DC", VA = "0x14956DC")]
		public UIInnerProgressBar()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007081")]
	private UIInnerProgressBar _progressBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007082")]
	private float _visualProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007083")]
	private float _targetProgress;

	[Cpp2IlInjected.Token(Token = "0x6004505")]
	[Cpp2IlInjected.Address(RVA = "0x1495610", Offset = "0x1495610", VA = "0x1495610")]
	public UIProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004506")]
	[Cpp2IlInjected.Address(RVA = "0x1495758", Offset = "0x1495758", VA = "0x1495758")]
	public void SetProgress(float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004507")]
	[Cpp2IlInjected.Address(RVA = "0x1495774", Offset = "0x1495774", VA = "0x1495774", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
