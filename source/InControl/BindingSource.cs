using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	public abstract class BindingSource : IEquatable<BindingSource>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		public abstract float GetValue(InputDevice inputDevice);

		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		public abstract bool GetState(InputDevice inputDevice);

		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		public abstract bool Equals(BindingSource other);

		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public abstract string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000009")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public abstract string DeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public abstract InputDeviceClass DeviceClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public abstract InputDeviceStyle DeviceStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000C")]
			get;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979C1C", Offset = "0x1979C1C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979CA8", Offset = "0x1979CA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public abstract BindingSourceType BindingSourceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000011")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		public abstract void Save(BinaryWriter writer);

		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		public abstract void Load(BinaryReader reader, ushort dataFormatVersion);

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

		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979CC8", Offset = "0x1979CC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected BindingSource()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private PlayerAction <BoundTo>k__BackingField;
	}
}
