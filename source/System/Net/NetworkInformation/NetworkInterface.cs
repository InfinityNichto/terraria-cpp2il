using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002A2")]
	public abstract class NetworkInterface
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C934", Offset = "0x1E1C934", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.TcpAddress", Member = "IsLocalHost", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static NetworkInterface[] GetAllNetworkInterfaces()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000446")]
		public virtual string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001289")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CA70", Offset = "0x1E1CA70", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600128A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CAA8", Offset = "0x1E1CAA8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual IPInterfaceProperties GetIPProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000447")]
		public virtual OperationalStatus OperationalStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x600128B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CAE0", Offset = "0x1E1CAE0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000448")]
		public virtual NetworkInterfaceType NetworkInterfaceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600128C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CB18", Offset = "0x1E1CB18", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600128D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CB50", Offset = "0x1E1CB50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected NetworkInterface()
		{
			throw null;
		}
	}
}
