using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000099")]
public class GUIControllerMultiplayerJoin : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5A6C", Offset = "0x9C5A6C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5A74", Offset = "0x9C5A74", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5A7C", Offset = "0x9C5A7C", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5AF4", Offset = "0x9C5AF4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "EnterServerIP", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateServerIP()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5B00", Offset = "0x9C5B00", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "CloseServerIPEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateServerIP()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5B08", Offset = "0x9C5B08", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "EnterServerPort", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateServerPort()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5B14", Offset = "0x9C5B14", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "CloseServerPortEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateServerPort()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5B1C", Offset = "0x9C5B1C", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5BCC", Offset = "0x9C5BCC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerMultiplayerJoin()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000388")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool serverIPActive;

	[global::Cpp2ILInjected.Token(Token = "0x4000389")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool serverPortActive;

	[global::Cpp2ILInjected.Token(Token = "0x400038A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int selectionIndex;
}
