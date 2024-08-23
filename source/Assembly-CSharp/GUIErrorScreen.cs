using System;
using System.Threading;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Telepathy;
using Terraria;
using Terraria.Audio;

// Token: 0x020001C6 RID: 454
[global::Cpp2ILInjected.Token(Token = "0x200025C")]
public class GUIErrorScreen
{
	// Token: 0x06000C5D RID: 3165 RVA: 0x0002405C File Offset: 0x0002225C
	[global::Cpp2ILInjected.Token(Token = "0x6000D79")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DBA54", Offset = "0x9DBA54", Length = "0x248")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0002405F File Offset: 0x0002225F
	[global::Cpp2ILInjected.Token(Token = "0x6000D7A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DBC9C", Offset = "0x9DBC9C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIErrorScreen()
	{
		throw null;
	}

	// Token: 0x040013FD RID: 5117
	[global::Cpp2ILInjected.Token(Token = "0x40018EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale0;

	// Token: 0x040013FE RID: 5118
	[global::Cpp2ILInjected.Token(Token = "0x40018EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scale1;

	// Token: 0x040013FF RID: 5119
	[global::Cpp2ILInjected.Token(Token = "0x40018ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float scale2;
}
