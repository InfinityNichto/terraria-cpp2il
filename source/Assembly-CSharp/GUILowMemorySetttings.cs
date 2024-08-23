using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using UnityEngine;

// Token: 0x020001CC RID: 460
[global::Cpp2ILInjected.Token(Token = "0x2000265")]
public class GUILowMemorySetttings
{
	// Token: 0x06000C99 RID: 3225 RVA: 0x00024110 File Offset: 0x00022310
	[global::Cpp2ILInjected.Token(Token = "0x6000DB6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E4754", Offset = "0x9E4754", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_systemMemorySize", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_Enabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void CheckMemorySettings(Action continueAction)
	{
		throw null;
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00024113 File Offset: 0x00022313
	[global::Cpp2ILInjected.Token(Token = "0x6000DB7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E4818", Offset = "0x9E4818", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00024116 File Offset: 0x00022316
	[global::Cpp2ILInjected.Token(Token = "0x6000DB8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E4AA0", Offset = "0x9E4AA0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUILowMemorySetttings()
	{
		throw null;
	}

	// Token: 0x0400145E RID: 5214
	[global::Cpp2ILInjected.Token(Token = "0x4001957")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool WarningDisplayed;

	// Token: 0x0400145F RID: 5215
	[global::Cpp2ILInjected.Token(Token = "0x4001958")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Action ContinueCallback;

	// Token: 0x04001460 RID: 5216
	[global::Cpp2ILInjected.Token(Token = "0x4001959")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float scale0;

	// Token: 0x04001461 RID: 5217
	[global::Cpp2ILInjected.Token(Token = "0x400195A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float scale1;

	// Token: 0x04001462 RID: 5218
	[global::Cpp2ILInjected.Token(Token = "0x400195B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float scale2;
}
