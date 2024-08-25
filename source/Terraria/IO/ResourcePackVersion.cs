using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;

namespace Terraria.IO
{
	[DebuggerDisplay("Version {Major}.{Minor}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000567")]
	public struct ResourcePackVersion : IComparable, IComparable<ResourcePackVersion>
	{
		[JsonProperty("major")]
		[global::Cpp2ILInjected.Token(Token = "0x17000677")]
		public int Major
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1340528", Offset = "0x1340528", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1340530", Offset = "0x1340530", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[JsonProperty("minor")]
		[global::Cpp2ILInjected.Token(Token = "0x17000678")]
		public int Minor
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1340538", Offset = "0x1340538", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1340540", Offset = "0x1340540", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340548", Offset = "0x1340548", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int CompareTo(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x134061C", Offset = "0x134061C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePackVersion), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(ResourcePackVersion),
			typeof(ResourcePackVersion)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePackVersion), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(ResourcePackVersion),
			typeof(ResourcePackVersion)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePackVersion), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(ResourcePackVersion),
			typeof(ResourcePackVersion)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePackVersion), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(ResourcePackVersion),
			typeof(ResourcePackVersion)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePackVersion), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		public int CompareTo(ResourcePackVersion other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340668", Offset = "0x1340668", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePackVersion), Member = "CompareTo", MemberParameters = new object[] { typeof(ResourcePackVersion) }, ReturnType = typeof(int))]
		public static bool operator ==(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340688", Offset = "0x1340688", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePackVersion), Member = "CompareTo", MemberParameters = new object[] { typeof(ResourcePackVersion) }, ReturnType = typeof(int))]
		public static bool operator !=(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13406A8", Offset = "0x13406A8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePackVersion), Member = "CompareTo", MemberParameters = new object[] { typeof(ResourcePackVersion) }, ReturnType = typeof(int))]
		public static bool operator <(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x13406C4", Offset = "0x13406C4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePackVersion), Member = "CompareTo", MemberParameters = new object[] { typeof(ResourcePackVersion) }, ReturnType = typeof(int))]
		public static bool operator >(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x13406E4", Offset = "0x13406E4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePackVersion), Member = "CompareTo", MemberParameters = new object[] { typeof(ResourcePackVersion) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340760", Offset = "0x1340760", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340788", Offset = "0x1340788", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetFormattedVersion()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int <Major>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int <Minor>k__BackingField;
	}
}
