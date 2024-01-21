using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000289")]
public struct GamePadThumbSticks
{
	[Cpp2IlInjected.Token(Token = "0x4001D3C")]
	private const float leftThumbDeadZone = 0.24f;

	[Cpp2IlInjected.Token(Token = "0x4001D3D")]
	private const float rightThumbDeadZone = 0.265f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001D3E")]
	internal readonly Buttons _virtualButtons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001D3F")]
	private readonly Vector2 _left;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001D40")]
	private readonly Vector2 _right;

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public Vector2 Left
	{
		[Cpp2IlInjected.Token(Token = "0x6001451")]
		[Cpp2IlInjected.Address(RVA = "0x3A1890", Offset = "0x3A1890", VA = "0x3A1890")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public Vector2 Right
	{
		[Cpp2IlInjected.Token(Token = "0x6001452")]
		[Cpp2IlInjected.Address(RVA = "0x3A18A4", Offset = "0x3A18A4", VA = "0x3A18A4")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001453")]
	[Cpp2IlInjected.Address(RVA = "0x3A18B8", Offset = "0x3A18B8", VA = "0x3A18B8")]
	public GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001454")]
	[Cpp2IlInjected.Address(RVA = "0x3A18E4", Offset = "0x3A18E4", VA = "0x3A18E4")]
	internal GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001455")]
	[Cpp2IlInjected.Address(RVA = "0x3A1914", Offset = "0x3A1914", VA = "0x3A1914")]
	private Vector2 ApplyDeadZone(GamePadDeadZone deadZoneMode, float deadZone, Vector2 thumbstickPosition)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001456")]
	[Cpp2IlInjected.Address(RVA = "0x3A193C", Offset = "0x3A193C", VA = "0x3A193C")]
	private Vector2 ExcludeIndependentAxesDeadZone(Vector2 value, float deadZone)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001457")]
	[Cpp2IlInjected.Address(RVA = "0x3A1960", Offset = "0x3A1960", VA = "0x3A1960")]
	private float ExcludeAxisDeadZone(float value, float deadZone)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001458")]
	[Cpp2IlInjected.Address(RVA = "0x3A19B0", Offset = "0x3A19B0", VA = "0x3A19B0")]
	private Vector2 ExcludeCircularDeadZone(Vector2 value, float deadZone)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001459")]
	[Cpp2IlInjected.Address(RVA = "0x1552394", Offset = "0x1552394", VA = "0x1552394")]
	public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600145A")]
	[Cpp2IlInjected.Address(RVA = "0x1553390", Offset = "0x1553390", VA = "0x1553390")]
	public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600145B")]
	[Cpp2IlInjected.Address(RVA = "0x3A19D0", Offset = "0x3A19D0", VA = "0x3A19D0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600145C")]
	[Cpp2IlInjected.Address(RVA = "0x3A19D8", Offset = "0x3A19D8", VA = "0x3A19D8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600145D")]
	[Cpp2IlInjected.Address(RVA = "0x3A19E0", Offset = "0x3A19E0", VA = "0x3A19E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
