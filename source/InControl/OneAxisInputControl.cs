using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000025 RID: 37
	[global::Cpp2ILInjected.Token(Token = "0x2000026")]
	public class OneAxisInputControl : IInputControl
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000024AA File Offset: 0x000006AA
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000024AD File Offset: 0x000006AD
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public ulong UpdateTick
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000174")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987004", Offset = "0x1987004", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000175")]
			[global::Cpp2ILInjected.Address(RVA = "0x198700C", Offset = "0x198700C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000024B0 File Offset: 0x000006B0
		[global::Cpp2ILInjected.Token(Token = "0x6000176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987014", Offset = "0x1987014", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithRawValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "CommitWithState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "UpdateWithState", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void PrepareForUpdate(ulong updateTick)
		{
			throw null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000024B3 File Offset: 0x000006B3
		[global::Cpp2ILInjected.Token(Token = "0x6000177")]
		[global::Cpp2ILInjected.Address(RVA = "0x19870D4", Offset = "0x19870D4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SubmitButtonState", MemberParameters = new object[]
		{
			typeof(TouchControl.ButtonTarget),
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "PrepareForUpdate", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		public bool UpdateWithState(bool state, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000024B6 File Offset: 0x000006B6
		[global::Cpp2ILInjected.Token(Token = "0x6000178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1980AD4", Offset = "0x1980AD4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "UpdateBindings", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerOneAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "CommitWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "CommitWithSides", MemberParameters = new object[]
		{
			typeof(InputControl),
			typeof(InputControl),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwoAxisInputControl), Member = "UpdateWithAxes", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "UpdateLeftStickWithValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "UpdateRightStickWithValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessLeftStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessRightStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessDPad", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SubmitButtonValue", MemberParameters = new object[]
		{
			typeof(TouchControl.ButtonTarget),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "PrepareForUpdate", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Abs", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "ApplyDeadZone", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlState), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool UpdateWithValue(float value, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000024B9 File Offset: 0x000006B9
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987134", Offset = "0x1987134", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "UpdateLeftStickWithRawValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "UpdateRightStickWithRawValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "PrepareForUpdate", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Abs", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlState), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool UpdateWithRawValue(float value, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000024BC File Offset: 0x000006BC
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19871F8", Offset = "0x19871F8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessLeftStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessRightStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessDPad", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlState), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		internal void SetValue(float value, ulong updateTick)
		{
			throw null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000024BF File Offset: 0x000006BF
		[global::Cpp2ILInjected.Token(Token = "0x600017B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1982478", Offset = "0x1982478", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearInputState()
		{
			throw null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000024C2 File Offset: 0x000006C2
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1980BD0", Offset = "0x1980BD0", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "UpdateBindings", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerOneAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "CommitWithState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "CommitWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "CommitWithSides", MemberParameters = new object[]
		{
			typeof(InputControl),
			typeof(InputControl),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwoAxisInputControl), Member = "UpdateWithAxes", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "CommitLeftStick", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "CommitRightStick", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessLeftStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessRightStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessDPad", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "Commit", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "CommitButton", MemberParameters = new object[] { typeof(TouchControl.ButtonTarget) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlState), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(InputControlState),
			typeof(InputControlState)
		}, ReturnType = typeof(bool))]
		public void Commit()
		{
			throw null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000024C5 File Offset: 0x000006C5
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987248", Offset = "0x1987248", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "Commit", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "PrepareForUpdate", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "Commit", ReturnType = typeof(void))]
		public void CommitWithState(bool state, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000024C8 File Offset: 0x000006C8
		[global::Cpp2ILInjected.Token(Token = "0x600017E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19833F8", Offset = "0x19833F8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "Commit", ReturnType = typeof(void))]
		public void CommitWithValue(float value, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000024CB File Offset: 0x000006CB
		[global::Cpp2ILInjected.Token(Token = "0x600017F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19872A4", Offset = "0x19872A4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "ValueFromSides", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "Commit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void CommitWithSides(InputControl negativeSide, InputControl positiveSide, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000024CE File Offset: 0x000006CE
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public bool State
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000180")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979E38", Offset = "0x1979E38", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Controller.ControllerDevice", Member = "GetAxisRaw2", MemberParameters = new object[] { "Controller.Axis" }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Controller.ControllerDevice", Member = "GetKeyRaw", MemberParameters = new object[] { "Controller.Buttons" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Controller.ControllerDevice", Member = "GetKeyRaw2", MemberParameters = new object[] { "Controller.Buttons" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000024D1 File Offset: 0x000006D1
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public bool LastState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000181")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987430", Offset = "0x1987430", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000024D4 File Offset: 0x000006D4
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		public float Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000182")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979DD8", Offset = "0x1979DD8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000024D7 File Offset: 0x000006D7
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		public float LastValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000183")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980CA0", Offset = "0x1980CA0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000024DA File Offset: 0x000006DA
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		public float RawValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000184")]
			[global::Cpp2ILInjected.Address(RVA = "0x19873F4", Offset = "0x19873F4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000024DD File Offset: 0x000006DD
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		internal float NextRawValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987458", Offset = "0x1987458", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000024E0 File Offset: 0x000006E0
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		internal bool HasInput
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000186")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987474", Offset = "0x1987474", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "Commit", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsNotZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000024E3 File Offset: 0x000006E3
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		public bool HasChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000187")]
			[global::Cpp2ILInjected.Address(RVA = "0x19874FC", Offset = "0x19874FC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlState), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(InputControlState),
				typeof(InputControlState)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000024E6 File Offset: 0x000006E6
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public bool IsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000188")]
			[global::Cpp2ILInjected.Address(RVA = "0x198752C", Offset = "0x198752C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "UpdateInputState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BasicExample.BasicExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000024E9 File Offset: 0x000006E9
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		public bool WasPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000189")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987554", Offset = "0x1987554", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "JoinButtonWasPressedOnListener", MemberParameters = new object[] { "MultiplayerWithBindingsExample.PlayerActions" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.PlayerManager", Member = "JoinButtonWasPressedOnDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceMovement.ButtonManager", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000024EC File Offset: 0x000006EC
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public bool WasReleased
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987584", Offset = "0x1987584", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000024EF File Offset: 0x000006EF
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public bool WasRepeated
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018B")]
			[global::Cpp2ILInjected.Address(RVA = "0x19875B0", Offset = "0x19875B0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceMovement.ButtonManager", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000024F2 File Offset: 0x000006F2
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000024F5 File Offset: 0x000006F5
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public float Sensitivity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19875D8", Offset = "0x19875D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600018D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19875E0", Offset = "0x19875E0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Initialize", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(InputDeviceInfo),
				typeof(InputDeviceProfile)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "RefreshProfile", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(InputDeviceProfile),
				typeof(int),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000024F8 File Offset: 0x000006F8
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000024FB File Offset: 0x000006FB
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public float LowerDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018E")]
			[global::Cpp2ILInjected.Address(RVA = "0x19875FC", Offset = "0x19875FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600018F")]
			[global::Cpp2ILInjected.Address(RVA = "0x19873BC", Offset = "0x19873BC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Initialize", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(InputDeviceInfo),
				typeof(InputDeviceProfile)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "RefreshProfile", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(InputDeviceProfile),
				typeof(int),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000024FE File Offset: 0x000006FE
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002501 File Offset: 0x00000701
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public float UpperDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000190")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987604", Offset = "0x1987604", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000191")]
			[global::Cpp2ILInjected.Address(RVA = "0x19873D8", Offset = "0x19873D8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Initialize", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(InputDeviceInfo),
				typeof(InputDeviceProfile)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "RefreshProfile", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(InputDeviceProfile),
				typeof(int),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00002504 File Offset: 0x00000704
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002507 File Offset: 0x00000707
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public float StateThreshold
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000192")]
			[global::Cpp2ILInjected.Address(RVA = "0x198760C", Offset = "0x198760C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000193")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987614", Offset = "0x1987614", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000250A File Offset: 0x0000070A
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public bool IsNullControl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000194")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987630", Offset = "0x1987630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000250D File Offset: 0x0000070D
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002510 File Offset: 0x00000710
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000195")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987638", Offset = "0x1987638", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000196")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987640", Offset = "0x1987640", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002513 File Offset: 0x00000713
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public bool EnabledInHierarchy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000197")]
			[global::Cpp2ILInjected.Address(RVA = "0x1987410", Offset = "0x1987410", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002516 File Offset: 0x00000716
		[global::Cpp2ILInjected.Token(Token = "0x6000198")]
		[global::Cpp2ILInjected.Address(RVA = "0x198764C", Offset = "0x198764C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "GetColorFromActionButtons", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.Player", Member = "GetColorFromInput", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.Player", Member = "GetColorFromInput", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public static implicit operator bool(OneAxisInputControl instance)
		{
			throw null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002519 File Offset: 0x00000719
		[global::Cpp2ILInjected.Token(Token = "0x6000199")]
		[global::Cpp2ILInjected.Address(RVA = "0x19833DC", Offset = "0x19833DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Controller.ControllerDevice", Member = "GetAxisRaw", MemberParameters = new object[] { "Controller.Axis" }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Controller.ControllerDevice", Member = "GetAxisRaw2", MemberParameters = new object[] { "Controller.Axis" }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "HandleInputUpdate", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BasicExample.BasicExample", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public static implicit operator float(OneAxisInputControl instance)
		{
			throw null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000251C File Offset: 0x0000071C
		[global::Cpp2ILInjected.Token(Token = "0x600019A")]
		[global::Cpp2ILInjected.Address(RVA = "0x197EE38", Offset = "0x197EE38", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public OneAxisInputControl()
		{
			throw null;
		}

		// Token: 0x040001CE RID: 462
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ulong <UpdateTick>k__BackingField;

		// Token: 0x040001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private float sensitivity;

		// Token: 0x040001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private float lowerDeadZone;

		// Token: 0x040001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float upperDeadZone;

		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float stateThreshold;

		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected bool isNullControl;

		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float FirstRepeatDelay;

		// Token: 0x040001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float RepeatDelay;

		// Token: 0x040001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public bool Raw;

		// Token: 0x040001D7 RID: 471
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		private bool enabled;

		// Token: 0x040001D8 RID: 472
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x36")]
		protected bool ownerEnabled;

		// Token: 0x040001D9 RID: 473
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ulong pendingTick;

		// Token: 0x040001DA RID: 474
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool pendingCommit;

		// Token: 0x040001DB RID: 475
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float nextRepeatTime;

		// Token: 0x040001DC RID: 476
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool wasRepeated;

		// Token: 0x040001DD RID: 477
		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool clearInputState;

		// Token: 0x040001DE RID: 478
		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private InputControlState lastState;

		// Token: 0x040001DF RID: 479
		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private InputControlState nextState;

		// Token: 0x040001E0 RID: 480
		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private InputControlState thisState;
	}
}
