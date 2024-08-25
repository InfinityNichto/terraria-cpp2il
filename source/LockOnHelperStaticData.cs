using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameInput;

[global::Cpp2ILInjected.Token(Token = "0x20002D4")]
public class LockOnHelperStaticData
{
	[global::Cpp2ILInjected.Token(Token = "0x17000195")]
	public static LockOnHelperStaticData Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4C19C", Offset = "0xA4C19C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get_UseMode", ReturnType = typeof(LockOnHelper.LockOnMode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set_UseMode", MemberParameters = new object[] { typeof(LockOnHelper.LockOnMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__canLockOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__canLockOn", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__targets", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__targets", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__pickedTarget", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__pickedTarget", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__lifeTimeCounter", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__lifeTimeCounter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__lifeTimeArrowDisplay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__lifeTimeArrowDisplay", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__threeDSTarget", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__threeDSTarget", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__targetClosestTarget", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__targetClosestTarget", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get_ForceUsability", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set_ForceUsability", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get_LockOnAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set_LockOnAvailable", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__lastFrame", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__lastFrame", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get__drawProgress", ReturnType = typeof(float[,,]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "set__drawProgress", MemberParameters = new object[] { typeof(float[,,]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleUseModes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get_AimedTarget", ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get_PredictedPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetUP", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetDOWN", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Toggle", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get_Enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "FindMostViableTarget", MemberParameters = new object[]
		{
			typeof(LockOnHelper.LockOnMode),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "HandlePressing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetFocus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetThreeDS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "GetClosestTarget", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 121)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010B3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4C1E8", Offset = "0xA4C1E8", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public LockOnHelperStaticData()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001FA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public LockOnHelper.LockOnMode UseMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public bool _enabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
	public bool _canLockOn;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public List<int> _targets;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int _pickedTarget;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int _lifeTimeCounter;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _lifeTimeArrowDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int _threeDSTarget;

	[global::Cpp2ILInjected.Token(Token = "0x4001FA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int _targetClosestTarget;

	[global::Cpp2ILInjected.Token(Token = "0x4001FAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public bool ForceUsability;

	[global::Cpp2ILInjected.Token(Token = "0x4001FAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
	public bool LockOnAvailable;

	[global::Cpp2ILInjected.Token(Token = "0x4001FAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int _lastFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4001FAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float[,] _drawProgress;
}
