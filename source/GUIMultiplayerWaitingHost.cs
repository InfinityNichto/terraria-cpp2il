using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;

// Token: 0x020001D7 RID: 471
[global::Cpp2ILInjected.Token(Token = "0x2000272")]
public class GUIMultiplayerWaitingHost
{
	// Token: 0x06000CE9 RID: 3305 RVA: 0x00024200 File Offset: 0x00022400
	[global::Cpp2ILInjected.Token(Token = "0x6000E08")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F0E48", Offset = "0x9F0E48", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSessionManager), Member = "CancelPending", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00024203 File Offset: 0x00022403
	[global::Cpp2ILInjected.Token(Token = "0x6000E09")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F10D0", Offset = "0x9F10D0", Length = "0x1C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "SetRemoteIP", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "StartTcpClient", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void JoinServer()
	{
		throw null;
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00024206 File Offset: 0x00022406
	[global::Cpp2ILInjected.Token(Token = "0x6000E0A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F1294", Offset = "0x9F1294", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIMultiplayerWaitingHost()
	{
		throw null;
	}

	// Token: 0x040014AB RID: 5291
	[global::Cpp2ILInjected.Token(Token = "0x40019B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale0;

	// Token: 0x040014AC RID: 5292
	[global::Cpp2ILInjected.Token(Token = "0x40019B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scale1;

	// Token: 0x040014AD RID: 5293
	[global::Cpp2ILInjected.Token(Token = "0x40019B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float scale2;

	// Token: 0x040014AE RID: 5294
	[global::Cpp2ILInjected.Token(Token = "0x40019B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private DateTime updateTime;
}
