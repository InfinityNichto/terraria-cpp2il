using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200010D")]
public class GUIInputRegionManager
{
	[Cpp2IlInjected.Token(Token = "0x400085D")]
	public static GUIInputRegionManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400085E")]
	private bool _disableAllRegions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400085F")]
	private int _mouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000860")]
	private int _mouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000861")]
	private bool _checkingExclusiveRegions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000862")]
	private List<GUIInputRegionExclusive> _exclusiveRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000863")]
	private List<GUIInputRegionExclusive> _prendingExclusiveRegionRemoves;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000864")]
	private List<GUIInputRegion> _currentRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000865")]
	private List<GUIInputRegion> _availableRegion;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector2 MousePosition
	{
		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0xDDE680", Offset = "0xDDE680", VA = "0xDDE680")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xDDE534", Offset = "0xDDE534", VA = "0xDDE534")]
	public static GUIInputRegionManager Create()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0xDDE6B8", Offset = "0xDDE6B8", VA = "0xDDE6B8")]
	public void DisableAllPicking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xDDE6C4", Offset = "0xDDE6C4", VA = "0xDDE6C4")]
	public void RenablePicking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0xDDE6D0", Offset = "0xDDE6D0", VA = "0xDDE6D0")]
	public void SetMousePosition(int x, int y, bool inUISpace = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0xDDE7EC", Offset = "0xDDE7EC", VA = "0xDDE7EC")]
	public bool RegisterInputRegion(Rectangle rect)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0xDDEAC0", Offset = "0xDDEAC0", VA = "0xDDEAC0")]
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0xDDEB1C", Offset = "0xDDEB1C", VA = "0xDDEB1C")]
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale, Vector2 padding)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0xDDE854", Offset = "0xDDE854", VA = "0xDDE854")]
	public bool RegisterInputRegion(int xMin, int xMax, int yMin, int yMax)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0xDDEC30", Offset = "0xDDEC30", VA = "0xDDEC30")]
	public bool IsOverExclusiveRegion()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0xDDEB88", Offset = "0xDDEB88", VA = "0xDDEB88")]
	private void RemovePendingRegions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0xDDED90", Offset = "0xDDED90", VA = "0xDDED90")]
	public GUIInputRegionExclusive RegisterPickingInterceptor(GUIInputRegionExclusive.IsOverHandler handler)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0xDDED00", Offset = "0xDDED00", VA = "0xDDED00")]
	public void UnregisterPickingInterceptor(GUIInputRegionExclusive region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0xDDEE1C", Offset = "0xDDEE1C", VA = "0xDDEE1C")]
	public bool RegisterInputRegion(int x, int y, Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0xDDEE60", Offset = "0xDDEE60", VA = "0xDDEE60")]
	public bool IsOverRegion()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0xDDEF2C", Offset = "0xDDEF2C", VA = "0xDDEF2C")]
	public bool IsOverRegionExpanded()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0xDDF03C", Offset = "0xDDF03C", VA = "0xDDF03C")]
	public bool IsPositionOverUI(Vector2 uiPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xDDF120", Offset = "0xDDF120", VA = "0xDDF120")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0xDDE5A0", Offset = "0xDDE5A0", VA = "0xDDE5A0")]
	public GUIInputRegionManager()
	{
	}
}
