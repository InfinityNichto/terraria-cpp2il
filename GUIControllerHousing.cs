using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GUIControllerHousing : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int MinRow
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x129FC8C", Offset = "0x129FC8C", VA = "0x129FC8C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int MaxColumns
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x129FD10", Offset = "0x129FD10", VA = "0x129FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x129FC64", Offset = "0x129FC64", VA = "0x129FC64")]
	public GUIControllerHousing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x129FC78", Offset = "0x129FC78", VA = "0x129FC78", Slot = "13")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x129FC80", Offset = "0x129FC80", VA = "0x129FC80", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x129FC84", Offset = "0x129FC84", VA = "0x129FC84", Slot = "14")]
	public virtual void NextItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x129FC88", Offset = "0x129FC88", VA = "0x129FC88", Slot = "15")]
	public virtual void PreviousItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x129FD88", Offset = "0x129FD88", VA = "0x129FD88", Slot = "16")]
	protected virtual void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x129FDE0", Offset = "0x129FDE0", VA = "0x129FDE0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x129FEDC", Offset = "0x129FEDC", VA = "0x129FEDC", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
