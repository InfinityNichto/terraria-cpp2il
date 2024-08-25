using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000014")]
public class CursorInputLayer
{
	[global::Cpp2ILInjected.Token(Token = "0x6000056")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FBDA0", Offset = "0x6FBDA0", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public CursorInputLayer()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000057")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FBEFC", Offset = "0x6FBEFC", Length = "0x13C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	protected override void Finalize()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000058")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC038", Offset = "0x6FC038", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void UpdateCursor(Cursor cursor)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000059")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC054", Offset = "0x6FC054", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Postupdate(List<Cursor> cursors)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
	public int Priority
	{
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FC070", Offset = "0x6FC070", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FC078", Offset = "0x6FC078", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600005C")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC0E8", Offset = "0x6FC0E8", Length = "0x15C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursors", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public static void Resort()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000020")]
	public static List<CursorInputLayer> Layers
	{
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBEB0", Offset = "0x6FBEB0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600005E")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC244", Offset = "0x6FC244", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static CursorInputLayer()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000046")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public CursorInputLayer.CursorUpdater UpdateCallback;

	[global::Cpp2ILInjected.Token(Token = "0x4000047")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public CursorInputLayer.CursorPostUpdate PostUpdateCallback;

	[global::Cpp2ILInjected.Token(Token = "0x4000048")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int _priority;

	[global::Cpp2ILInjected.Token(Token = "0x4000049")]
	public static bool Dirty;

	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	public delegate void CursorUpdater(Cursor cursor);

	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	public delegate void CursorPostUpdate(List<Cursor> cursors);

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	[Serializable]
	private sealed class <>c
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FC568", Offset = "0x6FC568", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FC5C4", Offset = "0x6FC5C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FC5CC", Offset = "0x6FC5CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		internal int <Resort>b__9_0(CursorInputLayer layer1, CursorInputLayer layer2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		public static readonly CursorInputLayer.<>c <>9;

		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		public static Comparison<CursorInputLayer> <>9__9_0;
	}
}
