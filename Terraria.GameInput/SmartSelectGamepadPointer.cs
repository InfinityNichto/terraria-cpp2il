using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x20004B9")]
public class SmartSelectGamepadPointer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006613")]
	private Vector2 _size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006614")]
	private Vector2 _center;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006615")]
	private Vector2 _distUniform;

	[Cpp2IlInjected.Token(Token = "0x60034C7")]
	[Cpp2IlInjected.Address(RVA = "0x1307228", Offset = "0x1307228", VA = "0x1307228")]
	public bool ShouldBeUsed()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60034C8")]
	[Cpp2IlInjected.Address(RVA = "0x1307314", Offset = "0x1307314", VA = "0x1307314")]
	public void SmartSelectLookup_GetTargetTile(Player player, out int tX, out int tY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034C9")]
	[Cpp2IlInjected.Address(RVA = "0x130789C", Offset = "0x130789C", VA = "0x130789C")]
	public void UpdateSize(Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034CA")]
	[Cpp2IlInjected.Address(RVA = "0x13078A8", Offset = "0x13078A8", VA = "0x13078A8")]
	public void UpdateCenter(Vector2 center)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034CB")]
	[Cpp2IlInjected.Address(RVA = "0x13075D0", Offset = "0x13075D0", VA = "0x13075D0")]
	public Vector2 GetPointerPosition()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60034CC")]
	[Cpp2IlInjected.Address(RVA = "0x13078B4", Offset = "0x13078B4", VA = "0x13078B4")]
	public SmartSelectGamepadPointer()
	{
	}
}
