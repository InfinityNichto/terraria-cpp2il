using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000061 RID: 97
[global::Cpp2ILInjected.Token(Token = "0x200008E")]
public class GUIControllerFullScreenMap : GUIControllerItem
{
	// Token: 0x060002DE RID: 734 RVA: 0x000223EB File Offset: 0x000205EB
	[global::Cpp2ILInjected.Token(Token = "0x6000378")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3870", Offset = "0x9C3870", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002DF RID: 735 RVA: 0x000223EE File Offset: 0x000205EE
	[global::Cpp2ILInjected.Token(Token = "0x6000379")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3874", Offset = "0x9C3874", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x000223F1 File Offset: 0x000205F1
	[global::Cpp2ILInjected.Token(Token = "0x600037A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C387C", Offset = "0x9C387C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x000223F4 File Offset: 0x000205F4
	[global::Cpp2ILInjected.Token(Token = "0x600037B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3880", Offset = "0x9C3880", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x000223F7 File Offset: 0x000205F7
	[global::Cpp2ILInjected.Token(Token = "0x600037C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3904", Offset = "0x9C3904", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerFullScreenMap()
	{
		throw null;
	}
}
