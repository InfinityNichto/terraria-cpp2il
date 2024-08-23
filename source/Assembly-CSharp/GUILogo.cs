using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x020001C9 RID: 457
[global::Cpp2ILInjected.Token(Token = "0x2000261")]
public class GUILogo
{
	// Token: 0x06000C8F RID: 3215 RVA: 0x000240F2 File Offset: 0x000222F2
	[global::Cpp2ILInjected.Token(Token = "0x6000DAC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E30B8", Offset = "0x9E30B8", Length = "0xCCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(Vector2),
		typeof(Rectangle?),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x000240F5 File Offset: 0x000222F5
	[global::Cpp2ILInjected.Token(Token = "0x6000DAD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E3D84", Offset = "0x9E3D84", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUILogo()
	{
		throw null;
	}

	// Token: 0x0400144E RID: 5198
	[global::Cpp2ILInjected.Token(Token = "0x4001943")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int LogoA;

	// Token: 0x0400144F RID: 5199
	[global::Cpp2ILInjected.Token(Token = "0x4001944")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int LogoB;

	// Token: 0x04001450 RID: 5200
	[global::Cpp2ILInjected.Token(Token = "0x4001945")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private bool LogoT;
}
