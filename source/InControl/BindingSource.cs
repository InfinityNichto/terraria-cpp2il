using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000003 RID: 3
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	public abstract class BindingSource : IEquatable<BindingSource>
	{
		// Token: 0x06000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		public abstract float GetValue(InputDevice inputDevice);

		// Token: 0x06000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		public abstract bool GetState(InputDevice inputDevice);

		// Token: 0x06000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		public abstract bool Equals(BindingSource other);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public abstract string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000009")]
			get;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public abstract string DeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			get;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public abstract InputDeviceClass DeviceClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000B")]
			get;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public abstract InputDeviceStyle DeviceStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000C")]
			get;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000209F File Offset: 0x0000029F
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979B80", Offset = "0x1979B80", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BindingSource), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BindingSource),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions.<>c", Member = "<CreateWithDefaultBindings>b__8_0", MemberParameters = new object[]
		{
			typeof(PlayerAction),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(BindingSource a, BindingSource b)
		{
			throw null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020A2 File Offset: 0x000002A2
		[global::Cpp2ILInjected.Token(Token = "0x600000E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979C04", Offset = "0x1979C04", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BindingSource), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BindingSource),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(BindingSource a, BindingSource b)
		{
			throw null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020A5 File Offset: 0x000002A5
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979C1C", Offset = "0x1979C1C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020A8 File Offset: 0x000002A8
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979CA8", Offset = "0x1979CA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public abstract BindingSourceType BindingSourceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000011")]
			get;
		}

		// Token: 0x06000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		public abstract void Save(BinaryWriter writer);

		// Token: 0x06000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		public abstract void Load(BinaryReader reader, ushort dataFormatVersion);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020AB File Offset: 0x000002AB
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020AE File Offset: 0x000002AE
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		internal PlayerAction BoundTo
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000014")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979CB0", Offset = "0x1979CB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000015")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979CB8", Offset = "0x1979CB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020B1 File Offset: 0x000002B1
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		internal virtual bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000016")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979CC0", Offset = "0x1979CC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020B4 File Offset: 0x000002B4
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979CC8", Offset = "0x1979CC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected BindingSource()
		{
			throw null;
		}

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private PlayerAction <BoundTo>k__BackingField;
	}
}
