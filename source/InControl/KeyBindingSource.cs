using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200000A RID: 10
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public class KeyBindingSource : BindingSource
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000020FC File Offset: 0x000002FC
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000020FF File Offset: 0x000002FF
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public KeyCombo Control
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000031")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A690", Offset = "0x197A690", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000032")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A6A0", Offset = "0x197A6A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002102 File Offset: 0x00000302
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A6B0", Offset = "0x197A6B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal KeyBindingSource()
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002105 File Offset: 0x00000305
		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A6B8", Offset = "0x197A6B8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public KeyBindingSource(KeyCombo keyCombo)
		{
			throw null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002108 File Offset: 0x00000308
		[global::Cpp2ILInjected.Token(Token = "0x6000035")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A6E8", Offset = "0x197A6E8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions.<>c", Member = "<CreateWithDefaultBindings>b__8_0", MemberParameters = new object[]
		{
			typeof(PlayerAction),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public KeyBindingSource(params Key[] keys)
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000210B File Offset: 0x0000030B
		[global::Cpp2ILInjected.Token(Token = "0x6000036")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A7D8", Offset = "0x197A7D8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float GetValue(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000210E File Offset: 0x0000030E
		[global::Cpp2ILInjected.Token(Token = "0x6000037")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A800", Offset = "0x197A800", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = "get_IsPressed", ReturnType = typeof(bool))]
		public override bool GetState(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002111 File Offset: 0x00000311
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000038")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A974", Offset = "0x197A974", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = "ToString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002114 File Offset: 0x00000314
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public override string DeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000039")]
			[global::Cpp2ILInjected.Address(RVA = "0x197AB20", Offset = "0x197AB20", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002117 File Offset: 0x00000317
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public override InputDeviceClass DeviceClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x197AB60", Offset = "0x197AB60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000211A File Offset: 0x0000031A
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public override InputDeviceStyle DeviceStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003B")]
			[global::Cpp2ILInjected.Address(RVA = "0x197AB68", Offset = "0x197AB68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000211D File Offset: 0x0000031D
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AB70", Offset = "0x197AB70", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(BindingSource other)
		{
			throw null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002120 File Offset: 0x00000320
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AC68", Offset = "0x197AC68", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002123 File Offset: 0x00000323
		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AD34", Offset = "0x197AD34", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002126 File Offset: 0x00000326
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public override BindingSourceType BindingSourceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003F")]
			[global::Cpp2ILInjected.Address(RVA = "0x197ADD8", Offset = "0x197ADD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002129 File Offset: 0x00000329
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x197ADE0", Offset = "0x197ADE0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000212C File Offset: 0x0000032C
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AF3C", Offset = "0x197AF3C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		public override void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x040000A5 RID: 165
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private KeyCombo <Control>k__BackingField;
	}
}
