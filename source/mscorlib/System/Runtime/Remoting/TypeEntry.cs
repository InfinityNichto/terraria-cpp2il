using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000352")]
	public class TypeEntry
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32AD0", Offset = "0x1B32AD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActivatedClientTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActivatedServiceTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TypeEntry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000345")]
		public string AssemblyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AD8", Offset = "0x1B32AD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AE0", Offset = "0x1B32AE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000346")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AE8", Offset = "0x1B32AE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AF0", Offset = "0x1B32AF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string assembly_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000E6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string type_name;
	}
}
