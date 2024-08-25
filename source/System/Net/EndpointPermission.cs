using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000243")]
	[Serializable]
	public class EndpointPermission
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48394", Offset = "0x1F48394", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "Intersect", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(EndpointPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(TransportType),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal EndpointPermission(string hostname, int port, TransportType transport)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000303")]
		public string Hostname
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F48424", Offset = "0x1F48424", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000304")]
		public int Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4842C", Offset = "0x1F4842C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000305")]
		public TransportType Transport
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F48434", Offset = "0x1F48434", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4843C", Offset = "0x1F4843C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F484F8", Offset = "0x1F484F8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48518", Offset = "0x1F48518", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48660", Offset = "0x1F48660", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "IsSubsetOf", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "Resolve", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "IsSubsetOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		internal bool IsSubsetOf(EndpointPermission perm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F489CC", Offset = "0x1F489CC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "ToNumber", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsSubsetOf(string addr1, string addr2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48BC8", Offset = "0x1F48BC8", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ArrayList),
			typeof(ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "IntersectHostname", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(TransportType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal EndpointPermission Intersect(EndpointPermission perm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48CDC", Offset = "0x1F48CDC", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "Intersect", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(EndpointPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "Resolve", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		private string IntersectHostname(EndpointPermission perm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48E80", Offset = "0x1F48E80", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "IntersectHostname", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "ToNumber", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private string Intersect(string addr1, string addr2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48ABC", Offset = "0x1F48ABC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "IsSubsetOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "Resolve", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int ToNumber(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F487B4", Offset = "0x1F487B4", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "IntersectHostname", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "ToNumber", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal void Resolve()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49164", Offset = "0x1F49164", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void UndoResolve()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000EA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4916C", Offset = "0x1F4916C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static EndpointPermission()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F491DC", Offset = "0x1F491DC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal EndpointPermission()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BE2")]
		private static char[] dot_char;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string hostname;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int port;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private TransportType transport;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool resolved;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool hasWildcard;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IPAddress[] addresses;
	}
}
