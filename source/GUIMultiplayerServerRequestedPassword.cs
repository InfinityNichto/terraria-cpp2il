using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;

// Token: 0x020001D6 RID: 470
[global::Cpp2ILInjected.Token(Token = "0x2000271")]
public class GUIMultiplayerServerRequestedPassword
{
	// Token: 0x06000CE7 RID: 3303 RVA: 0x000241FA File Offset: 0x000223FA
	[global::Cpp2ILInjected.Token(Token = "0x6000E06")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F096C", Offset = "0x9F096C", Length = "0x484")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(NetworkText),
		typeof(int),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_HidePassword", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x000241FD File Offset: 0x000223FD
	[global::Cpp2ILInjected.Token(Token = "0x6000E07")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F0DF0", Offset = "0x9F0DF0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIMultiplayerServerRequestedPassword()
	{
		throw null;
	}

	// Token: 0x040014A9 RID: 5289
	[global::Cpp2ILInjected.Token(Token = "0x40019B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool editingServerPassword;

	// Token: 0x040014AA RID: 5290
	[global::Cpp2ILInjected.Token(Token = "0x40019B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string editGetIP;
}
