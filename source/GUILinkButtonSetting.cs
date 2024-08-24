using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001EC RID: 492
[global::Cpp2ILInjected.Token(Token = "0x200028D")]
public class GUILinkButtonSetting : GUISettingEntry
{
	// Token: 0x06000E17 RID: 3607 RVA: 0x0002458A File Offset: 0x0002278A
	[global::Cpp2ILInjected.Token(Token = "0x6000F3B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA27464", Offset = "0xA27464", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Init", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUILinkButtonSetting(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x0002458D File Offset: 0x0002278D
	[global::Cpp2ILInjected.Token(Token = "0x6000F3C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA274B4", Offset = "0xA274B4", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILinkButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private string GetButtonCaption()
	{
		throw null;
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00024590 File Offset: 0x00022790
	[global::Cpp2ILInjected.Token(Token = "0x6000F3D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA27544", Offset = "0xA27544", Length = "0x280")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILinkButtonSetting), Member = "GetDisplayString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILinkButtonSetting), Member = "GetButtonCaption", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "IsFullyVisible", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILinkButtonSetting), Member = "GetLink", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "UpdateScroll", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00024593 File Offset: 0x00022793
	[global::Cpp2ILInjected.Token(Token = "0x6000F3E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA27B68", Offset = "0xA27B68", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x00024596 File Offset: 0x00022796
	[global::Cpp2ILInjected.Token(Token = "0x6000F3F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA277C4", Offset = "0xA277C4", Length = "0x218")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILinkButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private string GetDisplayString()
	{
		throw null;
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00024599 File Offset: 0x00022799
	[global::Cpp2ILInjected.Token(Token = "0x6000F40")]
	[global::Cpp2ILInjected.Address(RVA = "0xA279DC", Offset = "0xA279DC", Length = "0x18C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILinkButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private string GetLink()
	{
		throw null;
	}

	// Token: 0x0400164E RID: 5710
	[global::Cpp2ILInjected.Token(Token = "0x4001B70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float scale;
}
