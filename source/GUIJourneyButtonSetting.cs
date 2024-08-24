﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200010E RID: 270
[global::Cpp2ILInjected.Token(Token = "0x2000184")]
public class GUIJourneyButtonSetting : GUIOpenUIButtonSetting
{
	// Token: 0x060009F6 RID: 2550 RVA: 0x00023927 File Offset: 0x00021B27
	[global::Cpp2ILInjected.Token(Token = "0x6000AFE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3990", Offset = "0x9A3990", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Init", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIOpenUIButtonSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	public GUIJourneyButtonSetting(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x0002392A File Offset: 0x00021B2A
	[global::Cpp2ILInjected.Token(Token = "0x6000AFF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3998", Offset = "0x9A3998", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIOpenUIButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "GetIconTexture", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(ref Rectangle)
	}, ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0002392D File Offset: 0x00021B2D
	[global::Cpp2ILInjected.Token(Token = "0x6000B00")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3A94", Offset = "0x9A3A94", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	protected override SettingsOverlayListOption_Layout GetLayout()
	{
		throw null;
	}

	// Token: 0x04000871 RID: 2161
	[global::Cpp2ILInjected.Token(Token = "0x4000B8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float iconScale;
}