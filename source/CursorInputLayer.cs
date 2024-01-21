using System.Collections.Generic;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CursorInputLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000761")]
	public delegate void CursorUpdater(Cursor cursor);

	[Cpp2IlInjected.Token(Token = "0x2000762")]
	public delegate void CursorPostUpdate(List<Cursor> cursors);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public CursorUpdater UpdateCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public CursorPostUpdate PostUpdateCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int _priority;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static bool Dirty;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int Priority
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x20C6710", Offset = "0x20C6710", VA = "0x20C6710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x20C6718", Offset = "0x20C6718", VA = "0x20C6718")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static List<CursorInputLayer> Layers
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x20C5D0C", Offset = "0x20C5D0C", VA = "0x20C5D0C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20C5C18", Offset = "0x20C5C18", VA = "0x20C5C18")]
	public CursorInputLayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20C5D68", Offset = "0x20C5D68", VA = "0x20C5D68", Slot = "1")]
	~CursorInputLayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20C5EA8", Offset = "0x20C5EA8", VA = "0x20C5EA8")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x20C62DC", Offset = "0x20C62DC", VA = "0x20C62DC")]
	public void Postupdate(List<Cursor> cursors)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x20C67A0", Offset = "0x20C67A0", VA = "0x20C67A0")]
	public static void Resort()
	{
	}
}
