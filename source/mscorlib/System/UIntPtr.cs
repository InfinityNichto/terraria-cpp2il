using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.CLSCompliant(false)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20001A0")]
	[global::System.Serializable]
	public readonly struct UIntPtr : global::System.Runtime.Serialization.ISerializable, global::System.IEquatable<global::System.UIntPtr>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000FE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B918", Offset = "0x1C8B918", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UIntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(global::System.UIntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UIntPtr(ulong value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B980", Offset = "0x1C8B980", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIntPtr(uint value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B98C", Offset = "0x1C8B98C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BA04", Offset = "0x1C8BA04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BA0C", Offset = "0x1C8BA0C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BA7C", Offset = "0x1C8BA7C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BB1C", Offset = "0x1C8BB1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "AcquirePointer", MemberParameters = new object[] { typeof(ref byte*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public unsafe static bool operator ==(global::System.UIntPtr value1, global::System.UIntPtr value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BB28", Offset = "0x1C8BB28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static bool operator !=(global::System.UIntPtr value1, global::System.UIntPtr value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BB34", Offset = "0x1C8BB34", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		public static explicit operator global::System.UIntPtr(ulong value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BB54", Offset = "0x1C8BB54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static explicit operator global::System.UIntPtr(uint value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700016F")]
		public static int Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8B978", Offset = "0x1C8B978", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BB5C", Offset = "0x1C8BB5C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool System.IEquatable<System.UIntPtr>.Equals(global::System.UIntPtr other)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000FF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BB6C", Offset = "0x1C8BB6C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static UIntPtr()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000890")]
		public static readonly global::System.UIntPtr Zero;

		[global::Cpp2ILInjected.Token(Token = "0x4000891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe readonly void* _pointer;
	}
}
