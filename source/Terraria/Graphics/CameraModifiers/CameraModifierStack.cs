﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Graphics.CameraModifiers
{
	[global::Cpp2ILInjected.Token(Token = "0x200076F")]
	public class CameraModifierStack
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003E67")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B653C", Offset = "0x14B653C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops_MakeSpikesForward", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCAimedTarget)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops_MakeSpikesBothSides", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCAimedTarget)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CameraModifierStack), Member = "RemoveIdenticalModifiers", MemberParameters = new object[] { typeof(ICameraModifier) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(ICameraModifier modifier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E68")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B65F0", Offset = "0x14B65F0", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CameraModifierStack), Member = "Add", MemberParameters = new object[] { typeof(ICameraModifier) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void RemoveIdenticalModifiers(ICameraModifier modifier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E69")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6780", Offset = "0x14B6780", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CameraInfo), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CameraModifierStack), Member = "ClearFinishedModifiers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ApplyTo(ref Vector2 cameraPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B69C8", Offset = "0x14B69C8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CameraModifierStack), Member = "ApplyTo", MemberParameters = new object[] { typeof(ref Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ClearFinishedModifiers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6AEC", Offset = "0x14B6AEC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CameraModifierStack()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007D20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<ICameraModifier> _modifiers;
	}
}
