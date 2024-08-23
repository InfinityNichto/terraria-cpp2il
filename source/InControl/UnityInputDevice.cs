using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000052 RID: 82
	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public class UnityInputDevice : InputDevice
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00002CB1 File Offset: 0x00000EB1
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[global::Cpp2ILInjected.Token(Token = "0x17000144")]
		public int JoystickId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600043A")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4FE8", Offset = "0x19A4FE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600043B")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4FF0", Offset = "0x19A4FF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00002CB7 File Offset: 0x00000EB7
		[global::Cpp2ILInjected.Token(Token = "0x17000145")]
		public InputDeviceProfile Profile
		{
			[global::Cpp2ILInjected.Token(Token = "0x600043C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4FF8", Offset = "0x19A4FF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002CBA File Offset: 0x00000EBA
		[global::Cpp2ILInjected.Token(Token = "0x600043D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A5000", Offset = "0x19A5000", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UnityInputDevice(int joystickId, string joystickName)
		{
			throw null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002CBD File Offset: 0x00000EBD
		[global::Cpp2ILInjected.Token(Token = "0x600043E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A582C", Offset = "0x19A582C", Length = "0x714")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIControllerHardwareProfile", Member = "UpdateAndSaveCurrentProfile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "ClearControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "TargetIsAlias", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "AddControl", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(string)
		}, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "set_Sensitivity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "set_LowerDeadZone", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "set_UpperDeadZone", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "AddControl", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(string),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "AddAliasControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		public void RefreshProfile()
		{
			throw null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002CC0 File Offset: 0x00000EC0
		[global::Cpp2ILInjected.Token(Token = "0x600043F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A5010", Offset = "0x19A5010", Length = "0x81C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDevice), Member = "SetupAnalogQueries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDevice), Member = "SetupButtonQueries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "TargetIsAlias", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "AddControl", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(string)
		}, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "set_Sensitivity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "set_LowerDeadZone", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "set_UpperDeadZone", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "AddControl", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(string),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public UnityInputDevice(InputDeviceProfile deviceProfile, int joystickId, string joystickName)
		{
			throw null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002CC3 File Offset: 0x00000EC3
		[global::Cpp2ILInjected.Token(Token = "0x6000440")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A6208", Offset = "0x19A6208", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControl), Member = "get_IsOnZeroTick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = "ApplyToValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "UpdateWithState", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = "GetState", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002CC6 File Offset: 0x00000EC6
		[global::Cpp2ILInjected.Token(Token = "0x6000441")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A5F40", Offset = "0x19A5F40", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputDeviceProfile),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void SetupAnalogQueries()
		{
			throw null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002CC9 File Offset: 0x00000EC9
		[global::Cpp2ILInjected.Token(Token = "0x6000442")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A60A4", Offset = "0x19A60A4", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputDeviceProfile),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void SetupButtonQueries()
		{
			throw null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002CCC File Offset: 0x00000ECC
		[global::Cpp2ILInjected.Token(Token = "0x6000443")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A6498", Offset = "0x19A6498", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool ReadRawButtonState(int index)
		{
			throw null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002CCF File Offset: 0x00000ECF
		[global::Cpp2ILInjected.Token(Token = "0x6000444")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A6528", Offset = "0x19A6528", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override float ReadRawAnalogValue(int index)
		{
			throw null;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00002CD2 File Offset: 0x00000ED2
		[global::Cpp2ILInjected.Token(Token = "0x17000146")]
		public override bool IsSupportedOnThisPlatform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000445")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A65B8", Offset = "0x19A65B8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00002CD5 File Offset: 0x00000ED5
		[global::Cpp2ILInjected.Token(Token = "0x17000147")]
		public override bool IsKnown
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000446")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A65CC", Offset = "0x19A65CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00002CD8 File Offset: 0x00000ED8
		[global::Cpp2ILInjected.Token(Token = "0x17000148")]
		public override int NumUnknownButtons
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000447")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A65DC", Offset = "0x19A65DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00002CDB File Offset: 0x00000EDB
		[global::Cpp2ILInjected.Token(Token = "0x17000149")]
		public override int NumUnknownAnalogs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000448")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A65E4", Offset = "0x19A65E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000381 RID: 897
		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		private static string[,] analogQueries;

		// Token: 0x04000382 RID: 898
		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		private static string[,] buttonQueries;

		// Token: 0x04000383 RID: 899
		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		public const int MaxDevices = 10;

		// Token: 0x04000384 RID: 900
		[global::Cpp2ILInjected.Token(Token = "0x40003D0")]
		public const int MaxButtons = 20;

		// Token: 0x04000385 RID: 901
		[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
		public const int MaxAnalogs = 20;

		// Token: 0x04000386 RID: 902
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private int <JoystickId>k__BackingField;

		// Token: 0x04000387 RID: 903
		[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private readonly InputDeviceProfile profile;
	}
}
