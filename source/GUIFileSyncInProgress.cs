using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;

// Token: 0x020001C7 RID: 455
[global::Cpp2ILInjected.Token(Token = "0x200025D")]
public class GUIFileSyncInProgress
{
	// Token: 0x06000C5F RID: 3167 RVA: 0x00024062 File Offset: 0x00022262
	[global::Cpp2ILInjected.Token(Token = "0x6000D7B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DBCA4", Offset = "0x9DBCA4", Length = "0x244")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Color?),
		typeof(Color?),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00024065 File Offset: 0x00022265
	[global::Cpp2ILInjected.Token(Token = "0x6000D7C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DBEE8", Offset = "0x9DBEE8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIFileSyncInProgress()
	{
		throw null;
	}

	// Token: 0x04001400 RID: 5120
	[global::Cpp2ILInjected.Token(Token = "0x40018EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float statusScale;
}
