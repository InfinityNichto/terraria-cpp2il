using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.GameContent.UI.Minimap;

[Cpp2IlInjected.Token(Token = "0x20006B5")]
public class MinimapFrameManager : SelectionHolder<MinimapFrame>
{
	[Cpp2IlInjected.Token(Token = "0x60043CC")]
	[Cpp2IlInjected.Address(RVA = "0x109CEF0", Offset = "0x109CEF0", VA = "0x109CEF0", Slot = "5")]
	protected override void Configuration_OnLoad(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043CD")]
	[Cpp2IlInjected.Address(RVA = "0x109CFA0", Offset = "0x109CFA0", VA = "0x109CFA0", Slot = "4")]
	protected override void Configuration_Save(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043CE")]
	[Cpp2IlInjected.Address(RVA = "0x109D008", Offset = "0x109D008", VA = "0x109D008", Slot = "6")]
	protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043CF")]
	[Cpp2IlInjected.Address(RVA = "0x109D7F8", Offset = "0x109D7F8", VA = "0x109D7F8")]
	private void CreateAndAdd(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition, AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043D0")]
	[Cpp2IlInjected.Address(RVA = "0x109DAE4", Offset = "0x109DAE4", VA = "0x109DAE4")]
	public void DrawTo(SpriteBatch spriteBatch, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043D1")]
	[Cpp2IlInjected.Address(RVA = "0x109DB18", Offset = "0x109DB18", VA = "0x109DB18")]
	public void DrawForeground(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043D2")]
	[Cpp2IlInjected.Address(RVA = "0x109DB20", Offset = "0x109DB20", VA = "0x109DB20")]
	public MinimapFrameManager()
	{
	}
}
