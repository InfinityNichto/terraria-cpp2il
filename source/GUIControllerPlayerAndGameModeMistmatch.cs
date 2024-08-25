using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x200009F")]
public class GUIControllerPlayerAndGameModeMistmatch : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80F94", Offset = "0xA80F94", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80F9C", Offset = "0xA80F9C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80FA0", Offset = "0xA80FA0", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81024", Offset = "0xA81024", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8102C", Offset = "0xA8102C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerAndGameModeMismatch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerPlayerAndGameModeMistmatch()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40003B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerPlayerAndGameModeMistmatch.Controls selectedControl;

	[global::Cpp2ILInjected.Token(Token = "0x20000A0")]
	public enum Controls
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003B5")]
		Cancel
	}
}
