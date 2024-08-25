using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
public class GUIPlayerCreateController_ItemColour : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x6000667")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16D90", Offset = "0xD16D90", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPlayerCreateController_ItemColour(GUIPlayerCreateController controller)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000668")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17F48", Offset = "0xD17F48", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000669")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17F50", Offset = "0xD17F50", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600066A")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17F58", Offset = "0xD17F58", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Tabs), Member = "Activate", ReturnType = typeof(void))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600066B")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17FCC", Offset = "0xD17FCC", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "GetRegion", MemberParameters = new object[] { typeof(Slider_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPlayerCreateController _controller;

	[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int selectionIndex;
}
