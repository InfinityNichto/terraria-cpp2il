﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	public class Animator : Behaviour
	{
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66B1C", Offset = "0x1F66B1C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetTrigger(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66BA4", Offset = "0x1F66BA4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ResetTrigger(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public extern AnimatorControllerParameter[] parameters
		{
			[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600000C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F66C2C", Offset = "0x1F66C2C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AnimatorExtensions", Member = "HasParameter", MemberParameters = new object[]
			{
				typeof(Animator),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AnimatorExtensions", Member = "HasParameter", MemberParameters = new object[]
			{
				typeof(Animator),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AnimatorExtensions", Member = "GetParameters", MemberParameters = new object[]
			{
				typeof(Animator),
				"System.Int32[]",
				"System.Boolean[]"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public extern int parameterCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F66C68", Offset = "0x1F66C68", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AnimatorExtensions", Member = "HasParameter", MemberParameters = new object[]
			{
				typeof(Animator),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AnimatorExtensions", Member = "HasParameter", MemberParameters = new object[]
			{
				typeof(Animator),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AnimatorExtensions", Member = "GetParameters", MemberParameters = new object[]
			{
				typeof(Animator),
				"System.Int32[]",
				"System.Boolean[]"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public extern bool hasBoundPlayables
		{
			[NativeMethod("HasBoundPlayables")]
			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F66CA4", Offset = "0x1F66CA4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66948", Offset = "0x1F66948", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int StringToHash(string name);

		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66B60", Offset = "0x1F66B60", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetTriggerString(string name);

		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66BE8", Offset = "0x1F66BE8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void ResetTriggerString(string name);
	}
}
