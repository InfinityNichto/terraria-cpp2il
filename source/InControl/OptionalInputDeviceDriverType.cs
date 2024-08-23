using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl.NativeDeviceProfiles;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005A RID: 90
	[global::Cpp2ILInjected.Token(Token = "0x2000065")]
	[Serializable]
	public struct OptionalInputDeviceDriverType
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x00002D71 File Offset: 0x00000F71
		[global::Cpp2ILInjected.Token(Token = "0x6000480")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5E74", Offset = "0x19B5E74", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			throw null;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00002D74 File Offset: 0x00000F74
		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		public bool HasValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000481")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5E84", Offset = "0x19B5E84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00002D77 File Offset: 0x00000F77
		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		public bool HasNoValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000482")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5E8C", Offset = "0x19B5E8C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00002D7A File Offset: 0x00000F7A
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00002D7D File Offset: 0x00000F7D
		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public InputDeviceDriverType Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000483")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5E9C", Offset = "0x19B5E9C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceMatcher), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInputDeviceDriverType), Member = "op_Explicit", MemberParameters = new object[] { typeof(OptionalInputDeviceDriverType) }, ReturnType = typeof(InputDeviceDriverType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalTypeHasNoValueException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000484")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5EF8", Offset = "0x19B5EF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002D80 File Offset: 0x00000F80
		[global::Cpp2ILInjected.Token(Token = "0x6000485")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5F08", Offset = "0x19B5F08", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002D83 File Offset: 0x00000F83
		[global::Cpp2ILInjected.Token(Token = "0x6000486")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5F14", Offset = "0x19B5F14", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public InputDeviceDriverType GetValueOrDefault(InputDeviceDriverType defaultValue)
		{
			throw null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002D86 File Offset: 0x00000F86
		[global::Cpp2ILInjected.Token(Token = "0x6000487")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5F2C", Offset = "0x19B5F2C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public InputDeviceDriverType GetValueOrZero()
		{
			throw null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002D89 File Offset: 0x00000F89
		[global::Cpp2ILInjected.Token(Token = "0x6000488")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5F44", Offset = "0x19B5F44", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(InputDeviceDriverType value)
		{
			throw null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002D8C File Offset: 0x00000F8C
		[global::Cpp2ILInjected.Token(Token = "0x6000489")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5F54", Offset = "0x19B5F54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002D8F File Offset: 0x00000F8F
		[global::Cpp2ILInjected.Token(Token = "0x600048A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5FDC", Offset = "0x19B5FDC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(OptionalInputDeviceDriverType other)
		{
			throw null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002D92 File Offset: 0x00000F92
		[global::Cpp2ILInjected.Token(Token = "0x600048B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6000", Offset = "0x19B6000", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(InputDeviceDriverType other)
		{
			throw null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002D95 File Offset: 0x00000F95
		[global::Cpp2ILInjected.Token(Token = "0x600048C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6020", Offset = "0x19B6020", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			throw null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002D98 File Offset: 0x00000F98
		[global::Cpp2ILInjected.Token(Token = "0x600048D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6038", Offset = "0x19B6038", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			throw null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002D9B File Offset: 0x00000F9B
		[global::Cpp2ILInjected.Token(Token = "0x600048E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B605C", Offset = "0x19B605C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
		{
			throw null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002D9E File Offset: 0x00000F9E
		[global::Cpp2ILInjected.Token(Token = "0x600048F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6070", Offset = "0x19B6070", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
		{
			throw null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002DA1 File Offset: 0x00000FA1
		[global::Cpp2ILInjected.Token(Token = "0x6000490")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B608C", Offset = "0x19B608C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[global::Cpp2ILInjected.Token(Token = "0x6000491")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6098", Offset = "0x19B6098", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002DA7 File Offset: 0x00000FA7
		[global::Cpp2ILInjected.Token(Token = "0x6000492")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B60D0", Offset = "0x19B60D0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002DAA File Offset: 0x00000FAA
		[global::Cpp2ILInjected.Token(Token = "0x6000493")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B615C", Offset = "0x19B615C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XInputWindowsNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static implicit operator OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			throw null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002DAD File Offset: 0x00000FAD
		[global::Cpp2ILInjected.Token(Token = "0x6000494")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B616C", Offset = "0x19B616C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalInputDeviceDriverType), Member = "get_Value", ReturnType = typeof(InputDeviceDriverType))]
		public static explicit operator InputDeviceDriverType(OptionalInputDeviceDriverType optional)
		{
			throw null;
		}

		// Token: 0x04000397 RID: 919
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool hasValue;

		// Token: 0x04000398 RID: 920
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		private InputDeviceDriverType value;
	}
}
