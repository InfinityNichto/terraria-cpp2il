using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200027A")]
public class GUIPS4MultiplayerChecks
{
	[global::Cpp2ILInjected.Token(Token = "0x6000E5F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FF6E4", Offset = "0x9FF6E4", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void DisplayGenericError(string error)
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6000E65")]
	[global::Cpp2ILInjected.Address(RVA = "0x9FFE78", Offset = "0x9FFE78", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPS4MultiplayerChecks()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001A37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool CheckingPS4Permisions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool parentalFailed;

	[global::Cpp2ILInjected.Token(Token = "0x4001A39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int userId;

	[global::Cpp2ILInjected.Token(Token = "0x4001A3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private GUIPS4MultiplayerChecks.StateCheck state;

	[global::Cpp2ILInjected.Token(Token = "0x4001A3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool stepPassed;

	[global::Cpp2ILInjected.Token(Token = "0x4001A3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
	private bool displayingPS4Error;

	[global::Cpp2ILInjected.Token(Token = "0x4001A3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
	private bool displayingGenericError;

	[global::Cpp2ILInjected.Token(Token = "0x4001A3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F")]
	private bool displayedPlusSignup;

	[global::Cpp2ILInjected.Token(Token = "0x4001A3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string genericError;

	[global::Cpp2ILInjected.Token(Token = "0x4001A40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool XBOError;

	[global::Cpp2ILInjected.Token(Token = "0x4001A41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	private bool stepFailed;

	[global::Cpp2ILInjected.Token(Token = "0x4001A42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private uint stepErrorCode;

	[global::Cpp2ILInjected.Token(Token = "0x4001A43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool EditorCheckingPermissions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private DateTime EditorCheckStart;

	[global::Cpp2ILInjected.Token(Token = "0x200027B")]
	public enum StateCheck
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001A46")]
		Availability,
		[global::Cpp2ILInjected.Token(Token = "0x4001A47")]
		ParentalCheck,
		[global::Cpp2ILInjected.Token(Token = "0x4001A48")]
		CheckPlus
	}
}
