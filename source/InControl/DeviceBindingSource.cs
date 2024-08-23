using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000007 RID: 7
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public class DeviceBindingSource : BindingSource
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020B7 File Offset: 0x000002B7
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020BA File Offset: 0x000002BA
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public InputControlType Control
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979CD0", Offset = "0x1979CD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979CD8", Offset = "0x1979CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020BD File Offset: 0x000002BD
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979CE0", Offset = "0x1979CE0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal DeviceBindingSource()
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020C0 File Offset: 0x000002C0
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979CFC", Offset = "0x1979CFC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DeviceBindingSource(InputControlType control)
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020C3 File Offset: 0x000002C3
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979D24", Offset = "0x1979D24", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		public override float GetValue(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020C6 File Offset: 0x000002C6
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979DF4", Offset = "0x1979DF4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		public override bool GetState(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000020C9 File Offset: 0x000002C9
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000020")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979E60", Offset = "0x1979E60", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000020CC File Offset: 0x000002CC
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public override string DeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000021")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979FA0", Offset = "0x1979FA0", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000020CF File Offset: 0x000002CF
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public override InputDeviceClass DeviceClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A060", Offset = "0x197A060", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000020D2 File Offset: 0x000002D2
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public override InputDeviceStyle DeviceStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000023")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A0A0", Offset = "0x197A0A0", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020D5 File Offset: 0x000002D5
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A0E0", Offset = "0x197A0E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(BindingSource other)
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020D8 File Offset: 0x000002D8
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A16C", Offset = "0x197A16C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020DB File Offset: 0x000002DB
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A1F8", Offset = "0x197A1F8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000020DE File Offset: 0x000002DE
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public override BindingSourceType BindingSourceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000027")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A218", Offset = "0x197A218", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020E1 File Offset: 0x000002E1
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A220", Offset = "0x197A220", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020E4 File Offset: 0x000002E4
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A23C", Offset = "0x197A23C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			throw null;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000020E7 File Offset: 0x000002E7
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		internal override bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600002A")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A268", Offset = "0x197A268", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "TargetIsStandard", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400001D RID: 29
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private InputControlType <Control>k__BackingField;
	}
}
