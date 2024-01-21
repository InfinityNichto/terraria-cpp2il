using System;
using System.Collections;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Unity.Collections;

[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class GUIMap
{
	[Cpp2IlInjected.Token(Token = "0x20007BF")]
	public enum MinimapFrameStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4007A25")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4007A26")]
		Golden,
		[Cpp2IlInjected.Token(Token = "0x4007A27")]
		Remix,
		[Cpp2IlInjected.Token(Token = "0x4007A28")]
		Sticks,
		[Cpp2IlInjected.Token(Token = "0x4007A29")]
		StoneGold,
		[Cpp2IlInjected.Token(Token = "0x4007A2A")]
		TwigLeaf,
		[Cpp2IlInjected.Token(Token = "0x4007A2B")]
		Leaf,
		[Cpp2IlInjected.Token(Token = "0x4007A2C")]
		Retro,
		[Cpp2IlInjected.Token(Token = "0x4007A2D")]
		Valkyrie
	}

	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private const int MapTextureDimensions = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private bool grabbedMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private int activeX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private int activeY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private Texture2D[] mapTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private bool[] mapDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private NativeArray<ushort>[] mapTextureData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private unsafe ushort*[] mapTextureDataPtr;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	public bool miniMapEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40006AF")]
	private bool minimapPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private bool mapPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private bool mapPressedLast;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private bool mapZoomInPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private bool mapZoomOutPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private bool mapZoomResetPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	public Texture2D miniMapOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	public Texture2D miniMapClosed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private float ZoomInButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private float ZoomOutButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private float ZoomDefaultButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private float ToggleButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private float MapButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private bool use565Map;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private MinimapFrameStyle _activeFrameStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	public string BackingMiniTextureId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	public string BackingLargeTextureId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	private bool draggingSlider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private float ZoomValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private float TinyScrollScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private float TinyXOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private float TinyYOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private float TinyW;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private float TinyH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private GUIControllerFullScreenMap _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private DateTime _lastPingMouseDownTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private Vector2 _lastPingMousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private int LastFrame;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public MinimapFrameStyle ActiveFrameStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xDF814C", Offset = "0xDF814C", VA = "0xDF814C")]
		get
		{
			return default(MinimapFrameStyle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xDF8154", Offset = "0xDF8154", VA = "0xDF8154")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private int WorldScreenWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0xE05F4C", Offset = "0xE05F4C", VA = "0xE05F4C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private int WorldScreenHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0xE06078", Offset = "0xE06078", VA = "0xE06078")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0xDF8414", Offset = "0xDF8414", VA = "0xDF8414")]
	private void ClearMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0xDF85AC", Offset = "0xDF85AC", VA = "0xDF85AC")]
	private void ApplyMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0xDF8660", Offset = "0xDF8660", VA = "0xDF8660")]
	private void InitialiseTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0xDF82C4", Offset = "0xDF82C4", VA = "0xDF82C4")]
	public void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0xDF8988", Offset = "0xDF8988", VA = "0xDF8988")]
	public void LoadDefaultZoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087A")]
	[Cpp2IlInjected.Address(RVA = "0xDF8A24", Offset = "0xDF8A24", VA = "0xDF8A24")]
	public bool IsCursorOverFullScreenMapControls(Cursor cursor)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0xDF8CD8", Offset = "0xDF8CD8", VA = "0xDF8CD8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38D330", Offset = "0x38D330")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38D330", Offset = "0x38D330")]
	public void DrawToMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0xDF9888", Offset = "0xDF9888", VA = "0xDF9888")]
	private void ApplySection(int xStart, int xEnd, int yStart, int yEnd)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087D")]
	[Cpp2IlInjected.Address(RVA = "0xDF9E38", Offset = "0xDF9E38", VA = "0xDF9E38")]
	[Cpp2IlInjected.Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x38D3E4", Offset = "0x38D3E4")]
	public IEnumerator DrawToMap_Section_Sliced(int secX, int secY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600087E")]
	[Cpp2IlInjected.Address(RVA = "0xDF9EB8", Offset = "0xDF9EB8", VA = "0xDF9EB8")]
	public void DrawToMap_Section(int secX, int secY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0xDFA654", Offset = "0xDFA654", VA = "0xDFA654")]
	public void ResetMapPing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0xDFA6D8", Offset = "0xDFA6D8", VA = "0xDFA6D8")]
	public void DrawMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0xE061A4", Offset = "0xE061A4", VA = "0xE061A4")]
	private void DrawMapFullscreenBackground(Vector2 screenPosition, int screenWidth, int screenHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000884")]
	[Cpp2IlInjected.Address(RVA = "0xE06EB8", Offset = "0xE06EB8", VA = "0xE06EB8")]
	public GUIMap()
	{
	}
}
