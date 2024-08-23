using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000039 RID: 57
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	public class NativeInputDevice : InputDevice
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000029C6 File Offset: 0x00000BC6
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000029C9 File Offset: 0x00000BC9
		[global::Cpp2ILInjected.Token(Token = "0x1700010A")]
		public uint Handle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600032D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998CF4", Offset = "0x1998CF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600032E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998CFC", Offset = "0x1998CFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000029CF File Offset: 0x00000BCF
		[global::Cpp2ILInjected.Token(Token = "0x1700010B")]
		public InputDeviceInfo Info
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600032F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998D04", Offset = "0x1998D04", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000330")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998D18", Offset = "0x1998D18", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000029D2 File Offset: 0x00000BD2
		[global::Cpp2ILInjected.Token(Token = "0x6000331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998D2C", Offset = "0x1998D2C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "DetectDevice", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(InputDeviceInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal NativeInputDevice()
		{
			throw null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000029D5 File Offset: 0x00000BD5
		[global::Cpp2ILInjected.Token(Token = "0x6000332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998D84", Offset = "0x1998D84", Length = "0x464")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(InputDeviceInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "DetectDevice", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(InputDeviceInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "ClearInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "ClearControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = "get_Name", ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo, InputDeviceProfile deviceProfile)
		{
			throw null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000029D8 File Offset: 0x00000BD8
		[global::Cpp2ILInjected.Token(Token = "0x6000333")]
		[global::Cpp2ILInjected.Address(RVA = "0x19991E8", Offset = "0x19991E8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDevice), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(InputDeviceInfo),
			typeof(InputDeviceProfile)
		}, ReturnType = typeof(void))]
		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000029DB File Offset: 0x00000BDB
		[global::Cpp2ILInjected.Token(Token = "0x6000334")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999218", Offset = "0x1999218", Length = "0x2CC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000029DE File Offset: 0x00000BDE
		[global::Cpp2ILInjected.Token(Token = "0x6000335")]
		[global::Cpp2ILInjected.Address(RVA = "0x19994E4", Offset = "0x19994E4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool ReadRawButtonState(int index)
		{
			throw null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000029E1 File Offset: 0x00000BE1
		[global::Cpp2ILInjected.Token(Token = "0x6000336")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999514", Offset = "0x1999514", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float ReadRawAnalogValue(int index)
		{
			throw null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000029E4 File Offset: 0x00000BE4
		[global::Cpp2ILInjected.Token(Token = "0x6000337")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999544", Offset = "0x1999544", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static byte FloatToByte(float value)
		{
			throw null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000029E7 File Offset: 0x00000BE7
		[global::Cpp2ILInjected.Token(Token = "0x6000338")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999574", Offset = "0x1999574", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Vibrate(float leftMotor, float rightMotor)
		{
			throw null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000029EA File Offset: 0x00000BEA
		[global::Cpp2ILInjected.Token(Token = "0x6000339")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999578", Offset = "0x1999578", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void SetLightColor(float red, float green, float blue)
		{
			throw null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000029ED File Offset: 0x00000BED
		[global::Cpp2ILInjected.Token(Token = "0x600033A")]
		[global::Cpp2ILInjected.Address(RVA = "0x199957C", Offset = "0x199957C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
			throw null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000029F0 File Offset: 0x00000BF0
		[global::Cpp2ILInjected.Token(Token = "0x600033B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999580", Offset = "0x1999580", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameVendorID", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		public bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000029F3 File Offset: 0x00000BF3
		[global::Cpp2ILInjected.Token(Token = "0x600033C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19995C8", Offset = "0x19995C8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameProductID", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		public bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000029F6 File Offset: 0x00000BF6
		[global::Cpp2ILInjected.Token(Token = "0x600033D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999610", Offset = "0x1999610", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameVersionNumber", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		public bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000029F9 File Offset: 0x00000BF9
		[global::Cpp2ILInjected.Token(Token = "0x600033E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999658", Offset = "0x1999658", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameLocation", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		public bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000029FC File Offset: 0x00000BFC
		[global::Cpp2ILInjected.Token(Token = "0x600033F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19996A0", Offset = "0x19996A0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameSerialNumber", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		public bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000029FF File Offset: 0x00000BFF
		[global::Cpp2ILInjected.Token(Token = "0x1700010C")]
		public override bool IsSupportedOnThisPlatform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000340")]
			[global::Cpp2ILInjected.Address(RVA = "0x19996E8", Offset = "0x19996E8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00002A02 File Offset: 0x00000C02
		[global::Cpp2ILInjected.Token(Token = "0x1700010D")]
		public override bool IsKnown
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000341")]
			[global::Cpp2ILInjected.Address(RVA = "0x19996FC", Offset = "0x19996FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00002A05 File Offset: 0x00000C05
		[global::Cpp2ILInjected.Token(Token = "0x1700010E")]
		public override int NumUnknownButtons
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000342")]
			[global::Cpp2ILInjected.Address(RVA = "0x199970C", Offset = "0x199970C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00002A08 File Offset: 0x00000C08
		[global::Cpp2ILInjected.Token(Token = "0x1700010F")]
		public override int NumUnknownAnalogs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000343")]
			[global::Cpp2ILInjected.Address(RVA = "0x1999714", Offset = "0x1999714", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002C2 RID: 706
		[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
		private const int maxUnknownButtons = 20;

		// Token: 0x040002C3 RID: 707
		[global::Cpp2ILInjected.Token(Token = "0x40002D1")]
		private const int maxUnknownAnalogs = 20;

		// Token: 0x040002C4 RID: 708
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private uint <Handle>k__BackingField;

		// Token: 0x040002C5 RID: 709
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private InputDeviceInfo <Info>k__BackingField;

		// Token: 0x040002C6 RID: 710
		[global::Cpp2ILInjected.Token(Token = "0x40002D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private short[] buttons;

		// Token: 0x040002C7 RID: 711
		[global::Cpp2ILInjected.Token(Token = "0x40002D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private short[] analogs;

		// Token: 0x040002C8 RID: 712
		[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		private InputDeviceProfile profile;

		// Token: 0x040002C9 RID: 713
		[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		private int skipUpdateFrames;

		// Token: 0x040002CA RID: 714
		[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CC")]
		private int numUnknownButtons;

		// Token: 0x040002CB RID: 715
		[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		private int numUnknownAnalogs;
	}
}
