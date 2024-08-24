using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000069 RID: 105
[global::Cpp2ILInjected.Token(Token = "0x2000098")]
public class GUIControllerMultiplayerHost : GUIControllerItem
{
	// Token: 0x06000304 RID: 772 RVA: 0x00022451 File Offset: 0x00020651
	[global::Cpp2ILInjected.Token(Token = "0x600039E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58E0", Offset = "0x9C58E0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00022454 File Offset: 0x00020654
	[global::Cpp2ILInjected.Token(Token = "0x600039F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58E8", Offset = "0x9C58E8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00022457 File Offset: 0x00020657
	[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58F0", Offset = "0x9C58F0", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0002245A File Offset: 0x0002065A
	[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5968", Offset = "0x9C5968", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "EnterServerPassword", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateServerPassword()
	{
		throw null;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0002245D File Offset: 0x0002065D
	[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5974", Offset = "0x9C5974", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "CloseServerPasswordEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateServerPassword()
	{
		throw null;
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00022460 File Offset: 0x00020660
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

	// Token: 0x0600030A RID: 778 RVA: 0x00022463 File Offset: 0x00020663
	[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5A64", Offset = "0x9C5A64", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerMultiplayerHost()
	{
		throw null;
	}

	// Token: 0x0400025A RID: 602
	[global::Cpp2ILInjected.Token(Token = "0x4000386")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool serverPasswordActive;

	// Token: 0x0400025B RID: 603
	[global::Cpp2ILInjected.Token(Token = "0x4000387")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int selectionIndex;
}
