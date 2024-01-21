using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000297")]
public static class Mouse
{
	[Cpp2IlInjected.Token(Token = "0x2000818")]
	public enum OverrideState
	{
		[Cpp2IlInjected.Token(Token = "0x4007D89")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007D8A")]
		Position,
		[Cpp2IlInjected.Token(Token = "0x4007D8B")]
		Click,
		[Cpp2IlInjected.Token(Token = "0x4007D8C")]
		PositionAndClick
	}

	[Cpp2IlInjected.Token(Token = "0x4001E1F")]
	private static readonly MouseState _defaultState;

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	private static int scrollAccum
	{
		[Cpp2IlInjected.Token(Token = "0x60014C4")]
		[Cpp2IlInjected.Address(RVA = "0x15780C0", Offset = "0x15780C0", VA = "0x15780C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60014C5")]
		[Cpp2IlInjected.Address(RVA = "0x157813C", Offset = "0x157813C", VA = "0x157813C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000244")]
	private static float _uiX
	{
		[Cpp2IlInjected.Token(Token = "0x60014C6")]
		[Cpp2IlInjected.Address(RVA = "0x15781BC", Offset = "0x15781BC", VA = "0x15781BC")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014C7")]
		[Cpp2IlInjected.Address(RVA = "0x1578238", Offset = "0x1578238", VA = "0x1578238")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	private static float _uiY
	{
		[Cpp2IlInjected.Token(Token = "0x60014C8")]
		[Cpp2IlInjected.Address(RVA = "0x15782C4", Offset = "0x15782C4", VA = "0x15782C4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014C9")]
		[Cpp2IlInjected.Address(RVA = "0x1578340", Offset = "0x1578340", VA = "0x1578340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	private static float _X
	{
		[Cpp2IlInjected.Token(Token = "0x60014CA")]
		[Cpp2IlInjected.Address(RVA = "0x15783CC", Offset = "0x15783CC", VA = "0x15783CC")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014CB")]
		[Cpp2IlInjected.Address(RVA = "0x1578448", Offset = "0x1578448", VA = "0x1578448")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	private static float _Y
	{
		[Cpp2IlInjected.Token(Token = "0x60014CC")]
		[Cpp2IlInjected.Address(RVA = "0x15784D4", Offset = "0x15784D4", VA = "0x15784D4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014CD")]
		[Cpp2IlInjected.Address(RVA = "0x1578550", Offset = "0x1578550", VA = "0x1578550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	private static float _worldScreenOffsetY
	{
		[Cpp2IlInjected.Token(Token = "0x60014CE")]
		[Cpp2IlInjected.Address(RVA = "0x15785DC", Offset = "0x15785DC", VA = "0x15785DC")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014CF")]
		[Cpp2IlInjected.Address(RVA = "0x1578658", Offset = "0x1578658", VA = "0x1578658")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public static int _overloadScreenWidth
	{
		[Cpp2IlInjected.Token(Token = "0x60014D1")]
		[Cpp2IlInjected.Address(RVA = "0x1578808", Offset = "0x1578808", VA = "0x1578808")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60014D2")]
		[Cpp2IlInjected.Address(RVA = "0x1578884", Offset = "0x1578884", VA = "0x1578884")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public static int _overloadScreenHeight
	{
		[Cpp2IlInjected.Token(Token = "0x60014D3")]
		[Cpp2IlInjected.Address(RVA = "0x1578904", Offset = "0x1578904", VA = "0x1578904")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60014D4")]
		[Cpp2IlInjected.Address(RVA = "0x1578980", Offset = "0x1578980", VA = "0x1578980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public static int _overloadScreenOffsetX
	{
		[Cpp2IlInjected.Token(Token = "0x60014D5")]
		[Cpp2IlInjected.Address(RVA = "0x1578A00", Offset = "0x1578A00", VA = "0x1578A00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60014D6")]
		[Cpp2IlInjected.Address(RVA = "0x1578A7C", Offset = "0x1578A7C", VA = "0x1578A7C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public static int _overloadScreenOffsetY
	{
		[Cpp2IlInjected.Token(Token = "0x60014D7")]
		[Cpp2IlInjected.Address(RVA = "0x1578AFC", Offset = "0x1578AFC", VA = "0x1578AFC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60014D8")]
		[Cpp2IlInjected.Address(RVA = "0x1578B78", Offset = "0x1578B78", VA = "0x1578B78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public static OverrideState _virtualCursorOverride
	{
		[Cpp2IlInjected.Token(Token = "0x60014D9")]
		[Cpp2IlInjected.Address(RVA = "0x1578BF8", Offset = "0x1578BF8", VA = "0x1578BF8")]
		get
		{
			return default(OverrideState);
		}
		[Cpp2IlInjected.Token(Token = "0x60014DA")]
		[Cpp2IlInjected.Address(RVA = "0x1578C74", Offset = "0x1578C74", VA = "0x1578C74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public static ButtonState _virtualCursorOverrideState
	{
		[Cpp2IlInjected.Token(Token = "0x60014DB")]
		[Cpp2IlInjected.Address(RVA = "0x1578CF4", Offset = "0x1578CF4", VA = "0x1578CF4")]
		get
		{
			return default(ButtonState);
		}
		[Cpp2IlInjected.Token(Token = "0x60014DC")]
		[Cpp2IlInjected.Address(RVA = "0x1578D70", Offset = "0x1578D70", VA = "0x1578D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public static float _virtualCursorOverrideX
	{
		[Cpp2IlInjected.Token(Token = "0x60014DD")]
		[Cpp2IlInjected.Address(RVA = "0x1578DF0", Offset = "0x1578DF0", VA = "0x1578DF0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014DE")]
		[Cpp2IlInjected.Address(RVA = "0x1578E6C", Offset = "0x1578E6C", VA = "0x1578E6C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public static float _virtualCursorOverrideY
	{
		[Cpp2IlInjected.Token(Token = "0x60014DF")]
		[Cpp2IlInjected.Address(RVA = "0x1578EF8", Offset = "0x1578EF8", VA = "0x1578EF8")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014E0")]
		[Cpp2IlInjected.Address(RVA = "0x1578F74", Offset = "0x1578F74", VA = "0x1578F74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public static bool _overrideRMB
	{
		[Cpp2IlInjected.Token(Token = "0x60014E1")]
		[Cpp2IlInjected.Address(RVA = "0x1579000", Offset = "0x1579000", VA = "0x1579000")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60014E2")]
		[Cpp2IlInjected.Address(RVA = "0x157907C", Offset = "0x157907C", VA = "0x157907C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public static ButtonState _rmbOverrideState
	{
		[Cpp2IlInjected.Token(Token = "0x60014E3")]
		[Cpp2IlInjected.Address(RVA = "0x15790FC", Offset = "0x15790FC", VA = "0x15790FC")]
		get
		{
			return default(ButtonState);
		}
		[Cpp2IlInjected.Token(Token = "0x60014E4")]
		[Cpp2IlInjected.Address(RVA = "0x1579178", Offset = "0x1579178", VA = "0x1579178")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	private static float scrollAccumPartial
	{
		[Cpp2IlInjected.Token(Token = "0x60014E5")]
		[Cpp2IlInjected.Address(RVA = "0x15791F8", Offset = "0x15791F8", VA = "0x15791F8")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60014E6")]
		[Cpp2IlInjected.Address(RVA = "0x1579274", Offset = "0x1579274", VA = "0x1579274")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60014C2")]
	[Cpp2IlInjected.Address(RVA = "0x1578078", Offset = "0x1578078", VA = "0x1578078")]
	private static IntPtr PlatformGetWindowHandle()
	{
		return default(IntPtr);
	}

	[Cpp2IlInjected.Token(Token = "0x60014C3")]
	[Cpp2IlInjected.Address(RVA = "0x15780BC", Offset = "0x15780BC", VA = "0x15780BC")]
	private static void PlatformSetWindowHandle(IntPtr windowHandle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014D0")]
	[Cpp2IlInjected.Address(RVA = "0x15786E4", Offset = "0x15786E4", VA = "0x15786E4")]
	public static void SetWorldScreenOffset(float yValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014E7")]
	[Cpp2IlInjected.Address(RVA = "0x1579300", Offset = "0x1579300", VA = "0x1579300")]
	public static void SetRMBOverride(bool overrideRMB, ButtonState overrideState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014E8")]
	[Cpp2IlInjected.Address(RVA = "0x1579384", Offset = "0x1579384", VA = "0x1579384")]
	public static OverrideState GetOverrideState()
	{
		return default(OverrideState);
	}

	[Cpp2IlInjected.Token(Token = "0x60014E9")]
	[Cpp2IlInjected.Address(RVA = "0x15793F4", Offset = "0x15793F4", VA = "0x15793F4")]
	public static void SetVirtualCursorOverride(OverrideState overrideMouse, ButtonState overrideState, float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014EA")]
	[Cpp2IlInjected.Address(RVA = "0x1579520", Offset = "0x1579520", VA = "0x1579520")]
	public static Vector2 GetUICursorPosition()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60014EB")]
	[Cpp2IlInjected.Address(RVA = "0x15795AC", Offset = "0x15795AC", VA = "0x15795AC")]
	public static void UpdateUICursorPoint()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014EC")]
	[Cpp2IlInjected.Address(RVA = "0x15796B4", Offset = "0x15796B4", VA = "0x15796B4")]
	private static MouseState PlatformGetState(GameWindow window)
	{
		return default(MouseState);
	}

	[Cpp2IlInjected.Token(Token = "0x60014ED")]
	[Cpp2IlInjected.Address(RVA = "0x1579FC4", Offset = "0x1579FC4", VA = "0x1579FC4")]
	private static Cursor ActiveCursor()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60014EE")]
	[Cpp2IlInjected.Address(RVA = "0x157A07C", Offset = "0x157A07C", VA = "0x157A07C")]
	private static void PlatformSetPosition(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014EF")]
	[Cpp2IlInjected.Address(RVA = "0x157A080", Offset = "0x157A080", VA = "0x157A080")]
	public static void PlatformSetCursor(MouseCursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014F0")]
	[Cpp2IlInjected.Address(RVA = "0x157A084", Offset = "0x157A084", VA = "0x157A084")]
	public static MouseState GetState(GameWindow window)
	{
		return default(MouseState);
	}

	[Cpp2IlInjected.Token(Token = "0x60014F1")]
	[Cpp2IlInjected.Address(RVA = "0x157A0FC", Offset = "0x157A0FC", VA = "0x157A0FC")]
	public static MouseState GetState()
	{
		return default(MouseState);
	}

	[Cpp2IlInjected.Token(Token = "0x60014F2")]
	[Cpp2IlInjected.Address(RVA = "0x157A174", Offset = "0x157A174", VA = "0x157A174")]
	public static void SetPosition(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014F3")]
	[Cpp2IlInjected.Address(RVA = "0x157A1E4", Offset = "0x157A1E4", VA = "0x157A1E4")]
	public static void SetCursor(MouseCursor cursor)
	{
	}
}
