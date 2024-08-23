using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200000F RID: 15
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public class MouseBindingSource : BindingSource
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000219B File Offset: 0x0000039B
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000219E File Offset: 0x0000039E
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public Mouse Control
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000066")]
			[global::Cpp2ILInjected.Address(RVA = "0x197DCD4", Offset = "0x197DCD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000067")]
			[global::Cpp2ILInjected.Address(RVA = "0x197DCDC", Offset = "0x197DCDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000021A1 File Offset: 0x000003A1
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x197DCE4", Offset = "0x197DCE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MouseBindingSource()
		{
			throw null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000021A4 File Offset: 0x000003A4
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x197DCEC", Offset = "0x197DCEC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MouseBindingSource(Mouse mouseControl)
		{
			throw null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000021A7 File Offset: 0x000003A7
		[global::Cpp2ILInjected.Token(Token = "0x600006A")]
		[global::Cpp2ILInjected.Address(RVA = "0x197DD14", Offset = "0x197DD14", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSource), Member = "ButtonIsPressed", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSource), Member = "GetValue", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static bool SafeGetMouseButton(int button)
		{
			throw null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000021AA File Offset: 0x000003AA
		[global::Cpp2ILInjected.Token(Token = "0x600006B")]
		[global::Cpp2ILInjected.Address(RVA = "0x197DDA0", Offset = "0x197DDA0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[] { typeof(BindingListenOptions) }, ReturnType = typeof(Mouse))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "SafeGetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool ButtonIsPressed(Mouse control)
		{
			throw null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000021AD File Offset: 0x000003AD
		[global::Cpp2ILInjected.Token(Token = "0x600006C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197DE28", Offset = "0x197DE28", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[] { typeof(BindingListenOptions) }, ReturnType = typeof(Mouse))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool NegativeScrollWheelIsActive(float threshold)
		{
			throw null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000021B0 File Offset: 0x000003B0
		[global::Cpp2ILInjected.Token(Token = "0x600006D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197DEC8", Offset = "0x197DEC8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[] { typeof(BindingListenOptions) }, ReturnType = typeof(Mouse))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool PositiveScrollWheelIsActive(float threshold)
		{
			throw null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000021B3 File Offset: 0x000003B3
		[global::Cpp2ILInjected.Token(Token = "0x600006E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197DF64", Offset = "0x197DF64", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSource), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "SafeGetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static float GetValue(Mouse mouseControl)
		{
			throw null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000021B6 File Offset: 0x000003B6
		[global::Cpp2ILInjected.Token(Token = "0x600006F")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E19C", Offset = "0x197E19C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "GetValue", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override float GetValue(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000021B9 File Offset: 0x000003B9
		[global::Cpp2ILInjected.Token(Token = "0x6000070")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E1F4", Offset = "0x197E1F4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsNotZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool GetState(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000021BC File Offset: 0x000003BC
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000071")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E278", Offset = "0x197E278", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000021BF File Offset: 0x000003BF
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public override string DeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000072")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E2E0", Offset = "0x197E2E0", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000021C2 File Offset: 0x000003C2
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		public override InputDeviceClass DeviceClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000073")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E320", Offset = "0x197E320", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000021C5 File Offset: 0x000003C5
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		public override InputDeviceStyle DeviceStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000074")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E328", Offset = "0x197E328", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000021C8 File Offset: 0x000003C8
		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E330", Offset = "0x197E330", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(BindingSource other)
		{
			throw null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000021CB File Offset: 0x000003CB
		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E3BC", Offset = "0x197E3BC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000021CE File Offset: 0x000003CE
		[global::Cpp2ILInjected.Token(Token = "0x6000077")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E448", Offset = "0x197E448", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000021D1 File Offset: 0x000003D1
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		public override BindingSourceType BindingSourceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000078")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E468", Offset = "0x197E468", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000021D4 File Offset: 0x000003D4
		[global::Cpp2ILInjected.Token(Token = "0x6000079")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E470", Offset = "0x197E470", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000021D7 File Offset: 0x000003D7
		[global::Cpp2ILInjected.Token(Token = "0x600007A")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E48C", Offset = "0x197E48C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			throw null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000021DA File Offset: 0x000003DA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600007B")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E4B8", Offset = "0x197E4B8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MouseBindingSource()
		{
			throw null;
		}

		// Token: 0x040000C3 RID: 195
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Mouse <Control>k__BackingField;

		// Token: 0x040000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		public static float ScaleX;

		// Token: 0x040000C5 RID: 197
		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		public static float ScaleY;

		// Token: 0x040000C6 RID: 198
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		public static float ScaleZ;

		// Token: 0x040000C7 RID: 199
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		public static float JitterThreshold;

		// Token: 0x040000C8 RID: 200
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		private static readonly int[] buttonTable;
	}
}
