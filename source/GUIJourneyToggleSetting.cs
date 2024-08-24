using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000111 RID: 273
[global::Cpp2ILInjected.Token(Token = "0x2000188")]
public class GUIJourneyToggleSetting : GUIToggleSetting
{
	// Token: 0x06000A05 RID: 2565 RVA: 0x00023954 File Offset: 0x00021B54
	[global::Cpp2ILInjected.Token(Token = "0x6000B0F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A5E34", Offset = "0x9A5E34", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Init", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIToggleSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	public GUIJourneyToggleSetting(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00023957 File Offset: 0x00021B57
	[global::Cpp2ILInjected.Token(Token = "0x6000B10")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A5E3C", Offset = "0x9A5E3C", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIToggleSetting), Member = "Draw", ReturnType = typeof(void))]
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

	// Token: 0x06000A07 RID: 2567 RVA: 0x0002395A File Offset: 0x00021B5A
	[global::Cpp2ILInjected.Token(Token = "0x6000B11")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A5F38", Offset = "0x9A5F38", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	protected override SettingsOverlayToggle_Layout GetLayout()
	{
		throw null;
	}

	// Token: 0x04000876 RID: 2166
	[global::Cpp2ILInjected.Token(Token = "0x4000B96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float iconScale;
}
