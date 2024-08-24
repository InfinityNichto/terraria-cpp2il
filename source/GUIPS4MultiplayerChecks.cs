using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001DE RID: 478
[global::Cpp2ILInjected.Token(Token = "0x200027A")]
public class GUIPS4MultiplayerChecks
{
	// Token: 0x06000D40 RID: 3392 RVA: 0x00024305 File Offset: 0x00022505
	[global::Cpp2ILInjected.Token(Token = "0x6000E5F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FF6E4", Offset = "0x9FF6E4", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void DisplayGenericError(string error)
	{
		throw null;
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x00024308 File Offset: 0x00022508
	[global::Cpp2ILInjected.Token(Token = "0x6000E60")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FF6F4", Offset = "0x9FF6F4", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPS4MultiplayerChecks), Member = "Begin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void EditorCheckPermissions()
	{
		throw null;
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x0002430B File Offset: 0x0002250B
	[global::Cpp2ILInjected.Token(Token = "0x6000E61")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FF758", Offset = "0x9FF758", Length = "0x220")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPS4MultiplayerChecks), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void EditorCheckPermissionsUpdate()
	{
		throw null;
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x0002430E File Offset: 0x0002250E
	[global::Cpp2ILInjected.Token(Token = "0x6000E62")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FF9E0", Offset = "0x9FF9E0", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "SelectMultiplayer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPS4MultiplayerChecks), Member = "EditorCheckPermissions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Begin()
	{
		throw null;
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00024311 File Offset: 0x00022511
	[global::Cpp2ILInjected.Token(Token = "0x6000E63")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FF978", Offset = "0x9FF978", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPS4MultiplayerChecks), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Complete(bool passed)
	{
		throw null;
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x00024314 File Offset: 0x00022514
	[global::Cpp2ILInjected.Token(Token = "0x6000E64")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FFB08", Offset = "0x9FFB08", Length = "0x370")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPS4MultiplayerChecks), Member = "Complete", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
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
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPS4MultiplayerChecks), Member = "EditorCheckPermissionsUpdate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00024317 File Offset: 0x00022517
	[global::Cpp2ILInjected.Token(Token = "0x6000E65")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FFE78", Offset = "0x9FFE78", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPS4MultiplayerChecks()
	{
		throw null;
	}

	// Token: 0x04001522 RID: 5410
	[global::Cpp2ILInjected.Token(Token = "0x4001A37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool CheckingPS4Permisions;

	// Token: 0x04001523 RID: 5411
	[global::Cpp2ILInjected.Token(Token = "0x4001A38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool parentalFailed;

	// Token: 0x04001524 RID: 5412
	[global::Cpp2ILInjected.Token(Token = "0x4001A39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int userId;

	// Token: 0x04001525 RID: 5413
	[global::Cpp2ILInjected.Token(Token = "0x4001A3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private GUIPS4MultiplayerChecks.StateCheck state;

	// Token: 0x04001526 RID: 5414
	[global::Cpp2ILInjected.Token(Token = "0x4001A3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool stepPassed;

	// Token: 0x04001527 RID: 5415
	[global::Cpp2ILInjected.Token(Token = "0x4001A3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
	private bool displayingPS4Error;

	// Token: 0x04001528 RID: 5416
	[global::Cpp2ILInjected.Token(Token = "0x4001A3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
	private bool displayingGenericError;

	// Token: 0x04001529 RID: 5417
	[global::Cpp2ILInjected.Token(Token = "0x4001A3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F")]
	private bool displayedPlusSignup;

	// Token: 0x0400152A RID: 5418
	[global::Cpp2ILInjected.Token(Token = "0x4001A3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string genericError;

	// Token: 0x0400152B RID: 5419
	[global::Cpp2ILInjected.Token(Token = "0x4001A40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool XBOError;

	// Token: 0x0400152C RID: 5420
	[global::Cpp2ILInjected.Token(Token = "0x4001A41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	private bool stepFailed;

	// Token: 0x0400152D RID: 5421
	[global::Cpp2ILInjected.Token(Token = "0x4001A42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private uint stepErrorCode;

	// Token: 0x0400152E RID: 5422
	[global::Cpp2ILInjected.Token(Token = "0x4001A43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool EditorCheckingPermissions;

	// Token: 0x0400152F RID: 5423
	[global::Cpp2ILInjected.Token(Token = "0x4001A44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private DateTime EditorCheckStart;

	// Token: 0x020007FD RID: 2045
	[global::Cpp2ILInjected.Token(Token = "0x200027B")]
	public enum StateCheck
	{
		// Token: 0x04007CE0 RID: 31968
		[global::Cpp2ILInjected.Token(Token = "0x4001A46")]
		Availability,
		// Token: 0x04007CE1 RID: 31969
		[global::Cpp2ILInjected.Token(Token = "0x4001A47")]
		ParentalCheck,
		// Token: 0x04007CE2 RID: 31970
		[global::Cpp2ILInjected.Token(Token = "0x4001A48")]
		CheckPlus
	}
}
