using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000060 RID: 96
[global::Cpp2ILInjected.Token(Token = "0x200008D")]
public class GUIControllerDebug : GUIControllerItem
{
	// Token: 0x060002D9 RID: 729 RVA: 0x000223DC File Offset: 0x000205DC
	[global::Cpp2ILInjected.Token(Token = "0x6000373")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3788", Offset = "0x9C3788", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x000223DF File Offset: 0x000205DF
	[global::Cpp2ILInjected.Token(Token = "0x6000374")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C378C", Offset = "0x9C378C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x000223E2 File Offset: 0x000205E2
	[global::Cpp2ILInjected.Token(Token = "0x6000375")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3794", Offset = "0x9C3794", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x000223E5 File Offset: 0x000205E5
	[global::Cpp2ILInjected.Token(Token = "0x6000376")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C37F4", Offset = "0x9C37F4", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x000223E8 File Offset: 0x000205E8
	[global::Cpp2ILInjected.Token(Token = "0x6000377")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3868", Offset = "0x9C3868", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerDebug()
	{
		throw null;
	}

	// Token: 0x0400023F RID: 575
	[global::Cpp2ILInjected.Token(Token = "0x4000362")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int _selected;
}
