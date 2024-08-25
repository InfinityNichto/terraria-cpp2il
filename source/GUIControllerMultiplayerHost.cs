using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000098")]
public class GUIControllerMultiplayerHost : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x600039E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58E0", Offset = "0x9C58E0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600039F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58E8", Offset = "0x9C58E8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58F0", Offset = "0x9C58F0", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5968", Offset = "0x9C5968", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "EnterServerPassword", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateServerPassword()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5974", Offset = "0x9C5974", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "CloseServerPasswordEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateServerPassword()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C597C", Offset = "0x9C597C", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5A64", Offset = "0x9C5A64", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerMultiplayerHost()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000386")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool serverPasswordActive;

	[global::Cpp2ILInjected.Token(Token = "0x4000387")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int selectionIndex;
}
