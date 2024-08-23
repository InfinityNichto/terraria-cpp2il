using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000015 RID: 21
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	public class UnknownDeviceBindingSource : BindingSource
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000234B File Offset: 0x0000054B
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000234E File Offset: 0x0000054E
		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public UnknownDeviceControl Control
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x19839F8", Offset = "0x19839F8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983A08", Offset = "0x1983A08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002351 File Offset: 0x00000551
		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1981018", Offset = "0x1981018", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UnknownDeviceBindingSource()
		{
			throw null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002354 File Offset: 0x00000554
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983A14", Offset = "0x1983A14", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UnknownDeviceBindingSource(UnknownDeviceControl control)
		{
			throw null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002357 File Offset: 0x00000557
		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983A44", Offset = "0x1983A44", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceControl), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		public override float GetValue(InputDevice device)
		{
			throw null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000235A File Offset: 0x0000055A
		[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983B18", Offset = "0x1983B18", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsNotZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool GetState(InputDevice device)
		{
			throw null;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000235D File Offset: 0x0000055D
		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983BAC", Offset = "0x1983BAC", Length = "0x1D8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002360 File Offset: 0x00000560
		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public override string DeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983D84", Offset = "0x1983D84", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002363 File Offset: 0x00000563
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public override InputDeviceClass DeviceClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983E44", Offset = "0x1983E44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002366 File Offset: 0x00000566
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public override InputDeviceStyle DeviceStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1983E4C", Offset = "0x1983E4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002369 File Offset: 0x00000569
		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983E54", Offset = "0x1983E54", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(BindingSource other)
		{
			throw null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000236C File Offset: 0x0000056C
		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983FA0", Offset = "0x1983FA0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000236F File Offset: 0x0000056F
		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x198408C", Offset = "0x198408C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002372 File Offset: 0x00000572
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public override BindingSourceType BindingSourceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000103")]
			[global::Cpp2ILInjected.Address(RVA = "0x1984110", Offset = "0x1984110", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002375 File Offset: 0x00000575
		[global::Cpp2ILInjected.Token(Token = "0x17000047")]
		internal override bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000104")]
			[global::Cpp2ILInjected.Address(RVA = "0x1984118", Offset = "0x1984118", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002378 File Offset: 0x00000578
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x198421C", Offset = "0x198421C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceControl), Member = "Load", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			throw null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000237B File Offset: 0x0000057B
		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984304", Offset = "0x1984304", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x04000103 RID: 259
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000103")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private UnknownDeviceControl <Control>k__BackingField;
	}
}
