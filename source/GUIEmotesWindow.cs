using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x20000DC")]
public class GUIEmotesWindow
{
	[Cpp2IlInjected.Token(Token = "0x20007B9")]
	public enum Category
	{
		[Cpp2IlInjected.Token(Token = "0x40079FB")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40079FC")]
		RPS,
		[Cpp2IlInjected.Token(Token = "0x40079FD")]
		Items,
		[Cpp2IlInjected.Token(Token = "0x40079FE")]
		BiomesAndEvents,
		[Cpp2IlInjected.Token(Token = "0x40079FF")]
		TownNPCs,
		[Cpp2IlInjected.Token(Token = "0x4007A00")]
		Critters,
		[Cpp2IlInjected.Token(Token = "0x4007A01")]
		Bosses
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public List<int> _emoteEntries;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private static Asset<Texture2D> _emoteTexture;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private static Asset<Texture2D> _emoteTextureBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private int _frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private Category CurrentSelection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private int emoteOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public bool DisplayingEmotes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private float EmotesCloseScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private float emotesGeneralScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private float emotesRPSScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private float emotesItemsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private float emotesBiomesAndEventsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private float emotesTownNPCsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private float emotesCrittersScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private float emotesBossesScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public float emoteScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private float emoteScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private int emoteScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private Vector2 emoteDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private float TitleScale;

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x12D0AA4", Offset = "0x12D0AA4", VA = "0x12D0AA4")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x12D0CDC", Offset = "0x12D0CDC", VA = "0x12D0CDC")]
	public void SetDisplayingEmotes(bool value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x12D0F74", Offset = "0x12D0F74", VA = "0x12D0F74")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x12D0E68", Offset = "0x12D0E68", VA = "0x12D0E68")]
	public void SetCategory(Category cat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x12D10EC", Offset = "0x12D10EC", VA = "0x12D10EC")]
	private void GetEmotesGeneral(List<int> emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x12D130C", Offset = "0x12D130C", VA = "0x12D130C")]
	private void GetEmotesRPS(List<int> emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x12D13BC", Offset = "0x12D13BC", VA = "0x12D13BC")]
	private void GetEmotesItems(List<int> emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x12D157C", Offset = "0x12D157C", VA = "0x12D157C")]
	private void GetEmotesBiomesAndEvents(List<int> emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x12D173C", Offset = "0x12D173C", VA = "0x12D173C")]
	private void GetEmotesTownNPCs(List<int> emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x12D196C", Offset = "0x12D196C", VA = "0x12D196C")]
	private void GetEmotesCritters(List<int> emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x12D1B7C", Offset = "0x12D1B7C", VA = "0x12D1B7C")]
	private void GetEmotesBosses(List<int> emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x12D23C4", Offset = "0x12D23C4", VA = "0x12D23C4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x12D2748", Offset = "0x12D2748", VA = "0x12D2748")]
	private void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x12D28D4", Offset = "0x12D28D4", VA = "0x12D28D4")]
	private void DrawEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x12D2ADC", Offset = "0x12D2ADC", VA = "0x12D2ADC")]
	private void DrawCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x12D36D8", Offset = "0x12D36D8", VA = "0x12D36D8")]
	public float EmoteScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0x12D37A8", Offset = "0x12D37A8", VA = "0x12D37A8")]
	public void EmoteOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x12D3BF0", Offset = "0x12D3BF0", VA = "0x12D3BF0")]
	public void EmoteDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x12D4824", Offset = "0x12D4824", VA = "0x12D4824")]
	private Rectangle GetFrame(int emoteIndex)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x12D494C", Offset = "0x12D494C", VA = "0x12D494C")]
	public GUIEmotesWindow()
	{
	}
}
