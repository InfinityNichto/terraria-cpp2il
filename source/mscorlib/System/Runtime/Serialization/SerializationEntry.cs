using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003C9")]
	public readonly struct SerializationEntry
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001ECB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50AB4", Offset = "0x1B50AB4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal SerializationEntry(string entryName, object entryValue, global::System.Type entryType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700040A")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ECC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50AC0", Offset = "0x1B50AC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700040B")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ECD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50AC8", Offset = "0x1B50AC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;

		[global::Cpp2ILInjected.Token(Token = "0x4000F77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly object _value;

		[global::Cpp2ILInjected.Token(Token = "0x4000F78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Type _type;
	}
}
