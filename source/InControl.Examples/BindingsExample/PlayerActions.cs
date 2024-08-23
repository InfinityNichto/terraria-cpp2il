using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using UnityEngine;

namespace BindingsExample
{
	// Token: 0x0200000E RID: 14
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public class PlayerActions : PlayerActionSet
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000212E File Offset: 0x0000032E
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x199084C", Offset = "0x199084C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActions), Member = "CreateWithDefaultBindings", ReturnType = typeof(PlayerActions))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "CreatePlayerAction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(PlayerAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "CreateTwoAxisPlayerAction", MemberParameters = new object[]
		{
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction)
		}, ReturnType = typeof(PlayerTwoAxisAction))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public PlayerActions()
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002131 File Offset: 0x00000331
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F8C0", Offset = "0x198F8C0", Length = "0x4C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BindingsExample), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, Int32Enum>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public static PlayerActions CreateWithDefaultBindings()
		{
			throw null;
		}

		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public readonly PlayerAction Fire;

		// Token: 0x0400002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public readonly PlayerAction Jump;

		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public readonly PlayerAction Left;

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public readonly PlayerAction Right;

		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public readonly PlayerAction Up;

		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public readonly PlayerAction Down;

		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public readonly PlayerTwoAxisAction Move;

		// Token: 0x0200001C RID: 28
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200000F")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600005B RID: 91 RVA: 0x0000215E File Offset: 0x0000035E
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600004D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19909A8", Offset = "0x19909A8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600005C RID: 92 RVA: 0x00002161 File Offset: 0x00000361
			[global::Cpp2ILInjected.Token(Token = "0x600004E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990A04", Offset = "0x1990A04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00002164 File Offset: 0x00000364
			[global::Cpp2ILInjected.Token(Token = "0x600004F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990A0C", Offset = "0x1990A0C", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyBindingSource), Member = ".ctor", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BindingSource), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(BindingSource),
				typeof(BindingSource)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "StopListeningForBinding", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal bool <CreateWithDefaultBindings>b__8_0(PlayerAction action, BindingSource binding)
			{
				throw null;
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00002167 File Offset: 0x00000367
			[global::Cpp2ILInjected.Token(Token = "0x6000050")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990AC8", Offset = "0x1990AC8", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <CreateWithDefaultBindings>b__8_1(PlayerAction action, BindingSource binding)
			{
				throw null;
			}

			// Token: 0x0600005F RID: 95 RVA: 0x0000216A File Offset: 0x0000036A
			[global::Cpp2ILInjected.Token(Token = "0x6000051")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990B98", Offset = "0x1990B98", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <CreateWithDefaultBindings>b__8_2(PlayerAction action, BindingSource binding, BindingSourceRejectionType reason)
			{
				throw null;
			}

			// Token: 0x04000045 RID: 69
			[global::Cpp2ILInjected.Token(Token = "0x4000033")]
			public static readonly PlayerActions.<>c <>9;

			// Token: 0x04000046 RID: 70
			[global::Cpp2ILInjected.Token(Token = "0x4000034")]
			public static Func<PlayerAction, BindingSource, bool> <>9__8_0;

			// Token: 0x04000047 RID: 71
			[global::Cpp2ILInjected.Token(Token = "0x4000035")]
			public static Action<PlayerAction, BindingSource> <>9__8_1;

			// Token: 0x04000048 RID: 72
			[global::Cpp2ILInjected.Token(Token = "0x4000036")]
			public static Action<PlayerAction, BindingSource, BindingSourceRejectionType> <>9__8_2;
		}
	}
}
