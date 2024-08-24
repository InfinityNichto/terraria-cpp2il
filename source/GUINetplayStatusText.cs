using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x020000F2 RID: 242
[global::Cpp2ILInjected.Token(Token = "0x200015C")]
public class GUINetplayStatusText
{
	// Token: 0x0600088A RID: 2186 RVA: 0x000234E3 File Offset: 0x000216E3
	[global::Cpp2ILInjected.Token(Token = "0x600098A")]
	[global::Cpp2ILInjected.Address(RVA = "0x960C7C", Offset = "0x960C7C", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "DrawWithShadow", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Draw(string statusText)
	{
		throw null;
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x000234E6 File Offset: 0x000216E6
	[global::Cpp2ILInjected.Token(Token = "0x600098B")]
	[global::Cpp2ILInjected.Address(RVA = "0x960D04", Offset = "0x960D04", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public string ShowTestString()
	{
		throw null;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x000234E9 File Offset: 0x000216E9
	[global::Cpp2ILInjected.Token(Token = "0x600098C")]
	[global::Cpp2ILInjected.Address(RVA = "0x960D44", Offset = "0x960D44", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUINetplayStatusText()
	{
		throw null;
	}
}
